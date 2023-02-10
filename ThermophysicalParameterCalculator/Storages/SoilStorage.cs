using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThermophysicalParameterCalculator
{
	public class SoilStorage 
	{
		public static readonly string FileName = "SoilData.json";
		public static readonly string ResultsFileName = @"Results.json";

		public static void SaveSoilData(SoilData soilData)
		{
			var jsonData = JsonConvert.SerializeObject(soilData);

			FileProvider.Raplace(jsonData, FileName);

			MessageBox.Show("Данные сохранены в файле SoilData.json");
		}

		public static void SaveSoilResults(List<SoilCalculateResult> results)
		{
			var  jsonValue = JsonConvert.SerializeObject(results);
			FileProvider.Raplace(jsonValue, ResultsFileName);
		}
	}
}
