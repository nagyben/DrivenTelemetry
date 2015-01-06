namespace DrivenTelemetryWinForms {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btn_StartLogging = new System.Windows.Forms.Button();
			this.btn_StopLogging = new System.Windows.Forms.Button();
			this.btn_Connect = new System.Windows.Forms.Button();
			this.btn_ClearData = new System.Windows.Forms.Button();
			this.txt_CsvFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_SaveToCSV = new System.Windows.Forms.Button();
			this.combo_Ports = new System.Windows.Forms.ComboBox();
			this.btn_RefreshCOM = new System.Windows.Forms.Button();
			this.BG1 = new System.ComponentModel.BackgroundWorker();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.chart2, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_StartLogging, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_StopLogging, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_Connect, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_ClearData, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.txt_CsvFilePath, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.btn_SaveToCSV, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.combo_Ports, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_RefreshCOM, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.chart3, 1, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1396, 684);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.tableLayoutPanel1.SetColumnSpan(this.chart1, 2);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(120, 126);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(1273, 160);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			this.tableLayoutPanel1.SetColumnSpan(this.chart2, 2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(120, 292);
			this.chart2.Name = "chart2";
			this.chart2.Size = new System.Drawing.Size(1273, 160);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// btn_StartLogging
			// 
			this.btn_StartLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_StartLogging.Location = new System.Drawing.Point(3, 126);
			this.btn_StartLogging.Name = "btn_StartLogging";
			this.btn_StartLogging.Size = new System.Drawing.Size(111, 160);
			this.btn_StartLogging.TabIndex = 2;
			this.btn_StartLogging.Text = "Start logging";
			this.btn_StartLogging.UseVisualStyleBackColor = true;
			this.btn_StartLogging.Click += new System.EventHandler(this.btn_StartLogging_Click);
			// 
			// btn_StopLogging
			// 
			this.btn_StopLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_StopLogging.Location = new System.Drawing.Point(3, 292);
			this.btn_StopLogging.Name = "btn_StopLogging";
			this.btn_StopLogging.Size = new System.Drawing.Size(111, 160);
			this.btn_StopLogging.TabIndex = 3;
			this.btn_StopLogging.Text = "Stop logging";
			this.btn_StopLogging.UseVisualStyleBackColor = true;
			this.btn_StopLogging.Click += new System.EventHandler(this.btn_StopLogging_Click);
			// 
			// btn_Connect
			// 
			this.btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Connect.Location = new System.Drawing.Point(3, 83);
			this.btn_Connect.Name = "btn_Connect";
			this.btn_Connect.Size = new System.Drawing.Size(111, 37);
			this.btn_Connect.TabIndex = 4;
			this.btn_Connect.Text = "Connect";
			this.btn_Connect.UseVisualStyleBackColor = true;
			this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
			// 
			// btn_ClearData
			// 
			this.btn_ClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearData.Location = new System.Drawing.Point(3, 624);
			this.btn_ClearData.Name = "btn_ClearData";
			this.tableLayoutPanel1.SetRowSpan(this.btn_ClearData, 2);
			this.btn_ClearData.Size = new System.Drawing.Size(111, 57);
			this.btn_ClearData.TabIndex = 6;
			this.btn_ClearData.Text = "Clear data";
			this.btn_ClearData.UseVisualStyleBackColor = true;
			this.btn_ClearData.Click += new System.EventHandler(this.btn_ClearData_Click);
			// 
			// txt_CsvFilePath
			// 
			this.txt_CsvFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_CsvFilePath.Location = new System.Drawing.Point(120, 654);
			this.txt_CsvFilePath.Name = "txt_CsvFilePath";
			this.txt_CsvFilePath.Size = new System.Drawing.Size(633, 22);
			this.txt_CsvFilePath.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 634);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(633, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Save data to file";
			// 
			// btn_SaveToCSV
			// 
			this.btn_SaveToCSV.Location = new System.Drawing.Point(759, 654);
			this.btn_SaveToCSV.Name = "btn_SaveToCSV";
			this.btn_SaveToCSV.Size = new System.Drawing.Size(75, 23);
			this.btn_SaveToCSV.TabIndex = 9;
			this.btn_SaveToCSV.Text = "Save";
			this.btn_SaveToCSV.UseVisualStyleBackColor = true;
			this.btn_SaveToCSV.Click += new System.EventHandler(this.btn_SaveToCSV_Click);
			// 
			// combo_Ports
			// 
			this.combo_Ports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.combo_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo_Ports.FormattingEnabled = true;
			this.combo_Ports.Location = new System.Drawing.Point(3, 3);
			this.combo_Ports.Name = "combo_Ports";
			this.combo_Ports.Size = new System.Drawing.Size(111, 24);
			this.combo_Ports.Sorted = true;
			this.combo_Ports.TabIndex = 5;
			// 
			// btn_RefreshCOM
			// 
			this.btn_RefreshCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RefreshCOM.Location = new System.Drawing.Point(3, 33);
			this.btn_RefreshCOM.Name = "btn_RefreshCOM";
			this.btn_RefreshCOM.Size = new System.Drawing.Size(111, 44);
			this.btn_RefreshCOM.TabIndex = 10;
			this.btn_RefreshCOM.Text = "Refresh COM Ports";
			this.btn_RefreshCOM.UseVisualStyleBackColor = true;
			this.btn_RefreshCOM.Click += new System.EventHandler(this.btn_RefreshCOM_Click);
			// 
			// BG1
			// 
			this.BG1.WorkerReportsProgress = true;
			this.BG1.WorkerSupportsCancellation = true;
			this.BG1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.BG1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BG1_ProgressChanged);
			// 
			// chart3
			// 
			this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			this.tableLayoutPanel1.SetColumnSpan(this.chart3, 2);
			legend3.Name = "Legend1";
			this.chart3.Legends.Add(legend3);
			this.chart3.Location = new System.Drawing.Point(120, 458);
			this.chart3.Name = "chart3";
			this.chart3.Size = new System.Drawing.Size(1273, 160);
			this.chart3.TabIndex = 11;
			this.chart3.Text = "chart3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1420, 708);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Driven Telemetry Logger";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Button btn_StartLogging;
		private System.ComponentModel.BackgroundWorker BG1;
		private System.Windows.Forms.Button btn_StopLogging;
		private System.Windows.Forms.Button btn_Connect;
		private System.Windows.Forms.ComboBox combo_Ports;
		private System.Windows.Forms.Button btn_ClearData;
		private System.Windows.Forms.TextBox txt_CsvFilePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_SaveToCSV;
		private System.Windows.Forms.Button btn_RefreshCOM;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
	}
}

