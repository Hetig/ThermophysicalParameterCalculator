namespace ThermophysicalParameterCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.soilType = new System.Windows.Forms.Label();
			this.soilSalinity = new System.Windows.Forms.Label();
			this.mainLabel = new System.Windows.Forms.Label();
			this.salinityTextBox = new System.Windows.Forms.TextBox();
			this.frozenGroundMoistureTextBox = new System.Windows.Forms.TextBox();
			this.totalHumidityTextBox = new System.Windows.Forms.TextBox();
			this.iceContentTextBox = new System.Windows.Forms.TextBox();
			this.iceContent = new System.Windows.Forms.Label();
			this.salinity = new System.Windows.Forms.Label();
			this.frozenGroundMoisture = new System.Windows.Forms.Label();
			this.totalHumidity = new System.Windows.Forms.Label();
			this.soilTypeComboBox = new System.Windows.Forms.ComboBox();
			this.soilSalinityComboBox = new System.Windows.Forms.ComboBox();
			this.dateTime = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.calculateButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveInputsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveResultTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.SoilTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoilSalinityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalinityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IceContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalHumidityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FrozenGroundMoistureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cps = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tbf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// soilType
			// 
			this.soilType.AutoSize = true;
			this.soilType.Location = new System.Drawing.Point(224, 109);
			this.soilType.Name = "soilType";
			this.soilType.Size = new System.Drawing.Size(80, 16);
			this.soilType.TabIndex = 1;
			this.soilType.Text = "Тип грунта";
			// 
			// soilSalinity
			// 
			this.soilSalinity.AutoSize = true;
			this.soilSalinity.Location = new System.Drawing.Point(156, 165);
			this.soilSalinity.Name = "soilSalinity";
			this.soilSalinity.Size = new System.Drawing.Size(148, 16);
			this.soilSalinity.TabIndex = 2;
			this.soilSalinity.Text = "Засоленность грунта";
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.mainLabel.Location = new System.Drawing.Point(247, 50);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(375, 29);
			this.mainLabel.TabIndex = 3;
			this.mainLabel.Text = "Введите необходимые данные";
			// 
			// salinityTextBox
			// 
			this.salinityTextBox.Location = new System.Drawing.Point(310, 213);
			this.salinityTextBox.Name = "salinityTextBox";
			this.salinityTextBox.Size = new System.Drawing.Size(281, 22);
			this.salinityTextBox.TabIndex = 5;
			// 
			// frozenGroundMoistureTextBox
			// 
			this.frozenGroundMoistureTextBox.Location = new System.Drawing.Point(310, 362);
			this.frozenGroundMoistureTextBox.Name = "frozenGroundMoistureTextBox";
			this.frozenGroundMoistureTextBox.Size = new System.Drawing.Size(281, 22);
			this.frozenGroundMoistureTextBox.TabIndex = 8;
			// 
			// totalHumidityTextBox
			// 
			this.totalHumidityTextBox.Location = new System.Drawing.Point(310, 311);
			this.totalHumidityTextBox.Name = "totalHumidityTextBox";
			this.totalHumidityTextBox.Size = new System.Drawing.Size(281, 22);
			this.totalHumidityTextBox.TabIndex = 7;
			// 
			// iceContentTextBox
			// 
			this.iceContentTextBox.Location = new System.Drawing.Point(310, 264);
			this.iceContentTextBox.Name = "iceContentTextBox";
			this.iceContentTextBox.Size = new System.Drawing.Size(281, 22);
			this.iceContentTextBox.TabIndex = 6;
			// 
			// iceContent
			// 
			this.iceContent.AutoSize = true;
			this.iceContent.Location = new System.Drawing.Point(193, 267);
			this.iceContent.Name = "iceContent";
			this.iceContent.Size = new System.Drawing.Size(102, 16);
			this.iceContent.TabIndex = 10;
			this.iceContent.Text = "Льдистость Itot";
			// 
			// salinity
			// 
			this.salinity.AutoSize = true;
			this.salinity.Location = new System.Drawing.Point(106, 219);
			this.salinity.Name = "salinity";
			this.salinity.Size = new System.Drawing.Size(189, 16);
			this.salinity.TabIndex = 9;
			this.salinity.Text = "Степень засоленности Dsal";
			// 
			// frozenGroundMoisture
			// 
			this.frozenGroundMoisture.AutoSize = true;
			this.frozenGroundMoisture.Location = new System.Drawing.Point(76, 362);
			this.frozenGroundMoisture.Name = "frozenGroundMoisture";
			this.frozenGroundMoisture.Size = new System.Drawing.Size(219, 16);
			this.frozenGroundMoisture.TabIndex = 12;
			this.frozenGroundMoisture.Text = "Влажность мерзлого грунта Wm";
			// 
			// totalHumidity
			// 
			this.totalHumidity.AutoSize = true;
			this.totalHumidity.Location = new System.Drawing.Point(111, 317);
			this.totalHumidity.Name = "totalHumidity";
			this.totalHumidity.Size = new System.Drawing.Size(184, 16);
			this.totalHumidity.TabIndex = 11;
			this.totalHumidity.Text = "Суммарная влажность Wtot";
			// 
			// soilTypeComboBox
			// 
			this.soilTypeComboBox.FormattingEnabled = true;
			this.soilTypeComboBox.Items.AddRange(new object[] {
            "Пески разных фракций",
            "Супеси и пылеватые пески",
            "Суглинок",
            "Глины",
            "Торф слаборазложившийся",
            "Торф среднеразложившийся"});
			this.soilTypeComboBox.Location = new System.Drawing.Point(310, 109);
			this.soilTypeComboBox.Name = "soilTypeComboBox";
			this.soilTypeComboBox.Size = new System.Drawing.Size(281, 24);
			this.soilTypeComboBox.TabIndex = 13;
			// 
			// soilSalinityComboBox
			// 
			this.soilSalinityComboBox.FormattingEnabled = true;
			this.soilSalinityComboBox.Items.AddRange(new object[] {
            "Незасоленный",
            "Засоленный (морской тип)",
            "Засоленный (континентальный тип)"});
			this.soilSalinityComboBox.Location = new System.Drawing.Point(310, 162);
			this.soilSalinityComboBox.Name = "soilSalinityComboBox";
			this.soilSalinityComboBox.Size = new System.Drawing.Size(281, 24);
			this.soilSalinityComboBox.TabIndex = 14;
			// 
			// dateTime
			// 
			this.dateTime.AutoSize = true;
			this.dateTime.Location = new System.Drawing.Point(1157, 39);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(44, 16);
			this.dateTime.TabIndex = 15;
			this.dateTime.Text = "label1";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(609, 357);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(143, 32);
			this.calculateButton.TabIndex = 16;
			this.calculateButton.Text = "Рассчитать";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
			this.menuStrip1.TabIndex = 17;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInputsDataToolStripMenuItem,
            this.saveResultTableToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.menuToolStripMenuItem.Text = "Меню";
			// 
			// saveInputsDataToolStripMenuItem
			// 
			this.saveInputsDataToolStripMenuItem.Name = "saveInputsDataToolStripMenuItem";
			this.saveInputsDataToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
			this.saveInputsDataToolStripMenuItem.Text = "Сохранить введенные данные в файл";
			this.saveInputsDataToolStripMenuItem.Click += new System.EventHandler(this.saveInputsDataToolStripMenuItem_Click);
			// 
			// saveResultTableToolStripMenuItem
			// 
			this.saveResultTableToolStripMenuItem.Name = "saveResultTableToolStripMenuItem";
			this.saveResultTableToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
			this.saveResultTableToolStripMenuItem.Text = "Сохранить таблицу результатов";
			this.saveResultTableToolStripMenuItem.Click += new System.EventHandler(this.saveResultTableToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoilTypeColumn,
            this.SoilSalinityColumn,
            this.SalinityColumn,
            this.IceContentColumn,
            this.TotalHumidityColumn,
            this.FrozenGroundMoistureColumn,
            this.Cps,
            this.Tbf});
			this.dataGridView.Location = new System.Drawing.Point(768, 68);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(683, 301);
			this.dataGridView.TabIndex = 18;
			// 
			// SoilTypeColumn
			// 
			this.SoilTypeColumn.HeaderText = "Тип грунта";
			this.SoilTypeColumn.MinimumWidth = 6;
			this.SoilTypeColumn.Name = "SoilTypeColumn";
			this.SoilTypeColumn.Width = 125;
			// 
			// SoilSalinityColumn
			// 
			this.SoilSalinityColumn.HeaderText = "Засоленность грунта";
			this.SoilSalinityColumn.MinimumWidth = 6;
			this.SoilSalinityColumn.Name = "SoilSalinityColumn";
			this.SoilSalinityColumn.Width = 125;
			// 
			// SalinityColumn
			// 
			this.SalinityColumn.HeaderText = "Степень засоленности";
			this.SalinityColumn.MinimumWidth = 6;
			this.SalinityColumn.Name = "SalinityColumn";
			this.SalinityColumn.Width = 125;
			// 
			// IceContentColumn
			// 
			this.IceContentColumn.HeaderText = "Льдистость";
			this.IceContentColumn.MinimumWidth = 6;
			this.IceContentColumn.Name = "IceContentColumn";
			this.IceContentColumn.Width = 125;
			// 
			// TotalHumidityColumn
			// 
			this.TotalHumidityColumn.HeaderText = "Суммарная влажность";
			this.TotalHumidityColumn.MinimumWidth = 6;
			this.TotalHumidityColumn.Name = "TotalHumidityColumn";
			this.TotalHumidityColumn.Width = 125;
			// 
			// FrozenGroundMoistureColumn
			// 
			this.FrozenGroundMoistureColumn.HeaderText = "Влажность мерзлого грунта";
			this.FrozenGroundMoistureColumn.MinimumWidth = 6;
			this.FrozenGroundMoistureColumn.Name = "FrozenGroundMoistureColumn";
			this.FrozenGroundMoistureColumn.Width = 125;
			// 
			// Cps
			// 
			this.Cps.HeaderText = "Концентрация порового раствора Cps";
			this.Cps.MinimumWidth = 6;
			this.Cps.Name = "Cps";
			this.Cps.Width = 125;
			// 
			// Tbf
			// 
			this.Tbf.HeaderText = "Температура начала замерзания грунта Tbf";
			this.Tbf.MinimumWidth = 6;
			this.Tbf.Name = "Tbf";
			this.Tbf.Width = 125;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1477, 516);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.dateTime);
			this.Controls.Add(this.soilSalinityComboBox);
			this.Controls.Add(this.soilTypeComboBox);
			this.Controls.Add(this.frozenGroundMoisture);
			this.Controls.Add(this.totalHumidity);
			this.Controls.Add(this.iceContent);
			this.Controls.Add(this.salinity);
			this.Controls.Add(this.frozenGroundMoistureTextBox);
			this.Controls.Add(this.totalHumidityTextBox);
			this.Controls.Add(this.iceContentTextBox);
			this.Controls.Add(this.salinityTextBox);
			this.Controls.Add(this.mainLabel);
			this.Controls.Add(this.soilSalinity);
			this.Controls.Add(this.soilType);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Калькулятор теплофизического параметра";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label soilType;
		private System.Windows.Forms.Label soilSalinity;
		private System.Windows.Forms.Label mainLabel;
		private System.Windows.Forms.TextBox salinityTextBox;
		private System.Windows.Forms.TextBox frozenGroundMoistureTextBox;
		private System.Windows.Forms.TextBox totalHumidityTextBox;
		private System.Windows.Forms.TextBox iceContentTextBox;
		private System.Windows.Forms.Label iceContent;
		private System.Windows.Forms.Label salinity;
		private System.Windows.Forms.Label frozenGroundMoisture;
		private System.Windows.Forms.Label totalHumidity;
		private System.Windows.Forms.ComboBox soilTypeComboBox;
		private System.Windows.Forms.ComboBox soilSalinityComboBox;
		private System.Windows.Forms.Label dateTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveInputsDataToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoilTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoilSalinityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SalinityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn IceContentColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalHumidityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FrozenGroundMoistureColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cps;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tbf;
		private System.Windows.Forms.ToolStripMenuItem saveResultTableToolStripMenuItem;
	}
}

