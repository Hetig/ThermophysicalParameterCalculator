using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ThermophysicalParameterCalculator
{
	public partial class MainForm : Form
	{
		private SoilData currentSoilData;
		private List<SoilCalculateResult> resultsList = new List<SoilCalculateResult>();

		public MainForm()
		{
			InitializeComponent();
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			dateTime.Text = DateTime.Now.ToString("HH:mm:ss (dd MMMM yyyy)");
		}
		private void ValidateInputs()
		{
			if (soilTypeComboBox.SelectedItem is null || soilSalinityComboBox.SelectedItem is null || salinityTextBox.Text is null ||
				iceContentTextBox.Text is null || totalHumidityTextBox.Text is null || frozenGroundMoistureTextBox.Text is null)
			{
				MessageBox.Show("Проверьте корректность введенных данных. Поля не должны быть пустымыи", "Ошибка");
				return;
			}

			var soilType = soilTypeComboBox.SelectedItem.ToString();
			var soilTypesList = Enum.GetValues(typeof(SoilTypes)).Cast<SoilTypes>().Select(t => t.ToString());

			var soilSalinity = soilSalinityComboBox.SelectedItem.ToString();
			var soilSalinityList = Enum.GetValues(typeof(SoilSalinity)).Cast<SoilSalinity>().Select(s => s.ToString());

			if (soilTypesList.Contains(soilType) || soilSalinityList.Contains(soilSalinity))
			{
				MessageBox.Show("Проверьте корректность введенных данных. Выберите позицию из выпадающего списка", "Ошибка");
				return;
			}

			var salinityParseResult = double.TryParse(salinityTextBox.Text, out var salinity);
			var iceContentParseResult = double.TryParse(iceContentTextBox.Text, out var iceContent);
			var totalHumidityParseResult = double.TryParse(totalHumidityTextBox.Text, out var totalHumidity);
			var frozenGroundMoistureParseResult = double.TryParse(frozenGroundMoistureTextBox.Text, out var frozenGroundMoisture);

			if (!salinityParseResult || !iceContentParseResult || !totalHumidityParseResult || !frozenGroundMoistureParseResult)
			{
				MessageBox.Show("Проверьте корректность введенных данных. Введите числовые значения", "Ошибка");
				return;
			}

			currentSoilData = new SoilData((SoilTypes)soilTypeComboBox.SelectedIndex,
									(SoilSalinity)soilSalinityComboBox.SelectedIndex,
									salinity,
									iceContent,
									totalHumidity,
									frozenGroundMoisture);
		}

		private SoilCalculateResult GetCalculatedResult()
		{
			return new SoilCalculateResult
			(
				(SoilTypes)soilTypeComboBox.SelectedIndex,
				(SoilSalinity)soilSalinityComboBox.SelectedIndex,
				currentSoilData.Dsal,
				currentSoilData.Itot,
				currentSoilData.Wtot,
				currentSoilData.Wm
			);
		}

		private void AddResultInTable(SoilCalculateResult soilResult)
		{
			dataGridView.Rows.Add(
				soilResult.SoilType,
				soilResult.SoilSalinity,
				soilResult.Dsal,
				soilResult.Itot,
				soilResult.Wtot,
				soilResult.Wm,
				soilResult.Cps,
				soilResult.Tbf);
		}

		private void ShowResultsInTable(List<SoilCalculateResult> results)
		{
			foreach (var result in results)
			{
				AddResultInTable(result);
			}
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			ValidateInputs();
			var calculatedResult = GetCalculatedResult();
			AddResultInTable(calculatedResult);
			resultsList.Add(calculatedResult);
		}

		private void saveInputsDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ValidateInputs();
			if (currentSoilData == null)
			{
				MessageBox.Show("Заполните поля, чтобы сохранить данные в файле", "Ошибка");
				return;
			}

			SoilStorage.SaveSoilData(currentSoilData);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (File.Exists(SoilStorage.ResultsFileName))
			{
				var jsonValue = FileProvider.GetValue(SoilStorage.ResultsFileName);
				resultsList = JsonConvert.DeserializeObject<List<SoilCalculateResult>>(jsonValue);
				ShowResultsInTable(resultsList);
			}
		}

		private void saveResultTableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SoilStorage.SaveSoilResults(resultsList);
			MessageBox.Show("Содержимое таблицы сохранено в файл Results.json");
		}
	}
}
