using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace DrivenTelemetryWinForms {
	public partial class Form1 : Form {

		public const string VERSION = "0.1";

		private DataTable DT = new DataTable();
		private SerialPort COMPORT;
		private const string PORTSTRING = "COM1";
		private const int POLL_INTERVAL = 250; // poll interval in milliseconds
		private string[] Available_Ports;

#region "INITIALIZERS"

		/* INITIALIZERS */
		/* These functions set up the form, COM port and logging */

		public Form1() {
			InitializeComponent();

			this.Text = "Driven Telemetry Client v" + VERSION;

			InitializeDataTable();

			/* Chart Initializers */
			InitializeVoltsChart();
			InitializeAmpsChart();
			InitializeThrottleChart();


			InitializeCOMDropDown();
		}

		private void InitializeVoltsChart() {
			chart1.Series.Add("Volts");
			chart1.Series["Volts"].XValueMember = "Time";
			chart1.Series["Volts"].YValueMembers = "Volts";
			chart1.Series["Volts"].ChartType = SeriesChartType.Line;
			chart1.DataSource = DT;
			chart1.DataBind();

			/* X Axis formats */
				// Time format
			chart1.Series["Volts"].XValueType = ChartValueType.DateTime;
			chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

			/* Y Axis formats */
			chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;

			/* Line formats */
			chart1.Series["Volts"].BorderWidth = 2;
			chart1.Series["Volts"].Color = Color.Red;

			/* Tooltip */
			chart1.Series["Volts"].ToolTip = "Name #SERIESNAME : X - #VALX{F2} , Y - #VALY{F2}";
		}

		private void InitializeAmpsChart() {
			chart2.Series.Add("Amps");
			chart2.Series["Amps"].XValueMember = "Time";
			chart2.Series["Amps"].YValueMembers = "Amps";
			chart2.Series["Amps"].ChartType = SeriesChartType.Line;
			chart2.DataSource = DT;
			chart2.DataBind();

			/* X Axis formats */
				// Time format
			chart2.Series["Amps"].XValueType = ChartValueType.DateTime;
			chart2.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

			/* Y Axis formats */
			chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;
			
			/* Line formats */
			chart2.Series["Amps"].BorderWidth = 2;
			chart2.Series["Amps"].Color = Color.Blue;
		}

		private void InitializeThrottleChart() {
			chart3.Series.Add("Throttle");
			chart3.Series["Throttle"].XValueMember = "Time";
			chart3.Series["Throttle"].YValueMembers = "Throttle";
			chart3.Series["Throttle"].ChartType = SeriesChartType.Line;
			chart3.DataSource = DT;
			chart3.DataBind();

			/* X Axis formats */
			// Time format
			chart3.Series["Throttle"].XValueType = ChartValueType.DateTime;
			chart3.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

			/* Y Axis formats */
			chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;

			/* Line formats */
			chart3.Series["Throttle"].BorderWidth = 2;
			chart3.Series["Throttle"].Color = Color.Purple;
		}

		private void InitializeDataTable() {
			DT.Clear();
			DT.Columns.Add("Time", typeof(DateTime));
			DT.Columns.Add("Volts", typeof(double));
			DT.Columns.Add("Amps", typeof(double));
			DT.Columns.Add("Throttle", typeof(int));
		}

		private void InitializeCOMDropDown() {
			Available_Ports = SerialPort.GetPortNames();
			combo_Ports.DataSource = Available_Ports;
		}

#endregion

#region "DATA SERIALIZATION FUNCTIONS"
		private void SaveDataTable() {
			StringBuilder sb = new StringBuilder();

			IEnumerable<string> columnNames = DT.Columns.Cast<DataColumn>().
											  Select(column => column.ColumnName);
			sb.AppendLine(string.Join(",", columnNames));

			foreach (DataRow row in DT.Rows) {
				IEnumerable<string> fields = row.ItemArray.Select(field => field.ToCSVFormat());
				sb.AppendLine(string.Join(",", fields));
			}

			File.WriteAllText(txt_CsvFilePath.Text, sb.ToString());
		}
#endregion

#region "PRIVATE FUNCTIONS"

		private bool RandomGenerator() {
			Random rand = new Random((int)DateTime.Now.Millisecond);
			AddReading(rand.Next(15, 25), rand.Next(0, 30), rand.Next(0,100));

			return true;
		}

		private bool COMRead() {
			if (COMPORT.IsOpen) {
				string data = COMPORT.ReadLine();

				// TODO: extract data from string

				// Return true for successful value completion
				return true;
			} else {
				// comport is not open, return false
				MessageBox.Show("Warning: " + COMPORT.ToString() + " is not open!");
				return false;
			}
		}

		private void AddReading(double volts, double amps, int throttle) {
			DT.Rows.Add(DateTime.Now, volts, amps, throttle);
		}

		private void UpdateCharts() {
			chart1.DataBind();
			chart2.DataBind();
			chart3.DataBind();

			chart1.Update();
			chart2.Update();
			chart3.Update();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
			// BackgroundWorker reads the comport and adds data to the datatable
			while (BG1.CancellationPending != true) {
				if (! RandomGenerator()) {
					// if the function returns false then we need to stop and figure out what to do
					MessageBox.Show("Something went wrong");
					break;
				}
				BG1.ReportProgress(1);
				Thread.Sleep(POLL_INTERVAL);
			}
		}

		private void BG1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
			// We don't care about the progress percentage therefore we can use the value
			// as a signalling variable
			// 1 - continue receiving data
			// 0 - stop requested

			switch (e.ProgressPercentage) {
				case 0:
					// stop requested
					if (BG1.WorkerSupportsCancellation == true) {
						BG1.CancelAsync();
					}
					break;
				case 1:
					// continue working
					// update charts in ProgressChanged event
					UpdateCharts();
					break;
				default:
					break;
			}
		}

		private void SelectCOMPort(string port) {
			COMPORT = new SerialPort(port);

			try {
				COMPORT.Open();
			} catch (Exception) {
				MessageBox.Show("Could not connect to " + port + "!");
			}
			
		}

		private void SuggestCSVFileName() {
			// suggested filename will be in the format
			// [date ddMMMyy] - [start time hh:mm] - [end time hh:mm]

			// Get DateTime from DataTable
			DateTime start_time = (DateTime)DT.Rows[0]["Time"];
			DateTime end_time = (DateTime)DT.Rows[DT.Rows.Count - 1]["Time"];

			// create parts of filename
			string datepart = start_time.ToString("dd MMM yy");
			string startpart = start_time.ToString("HHmmss");
			string endpart = end_time.ToString("HHmmss");

			// enter into textbox
			txt_CsvFilePath.Text = datepart + " " + startpart + " - " + endpart + ".csv";

		}

#endregion

#region "BUTTONS"

		private void btn_StartLogging_Click(object sender, EventArgs e) {
			if (BG1.IsBusy != true) {
				BG1.RunWorkerAsync();
			}
		}

		private void btn_StopLogging_Click(object sender, EventArgs e) {
			if (BG1.IsBusy == true) {
				BG1.CancelAsync();
			}

			SuggestCSVFileName();
		}

		private void btn_Connect_Click(object sender, EventArgs e) {
			// first get the selected port from the dropdown list
			string port = (string)combo_Ports.SelectedItem;

			// Connect to COM port
			if (port != null && port.Length >= 4) {
				SelectCOMPort(port);
			}
		}

		private void btn_ClearData_Click(object sender, EventArgs e) {
			DT.Clear();
			UpdateCharts();
		}

		private void btn_SaveToCSV_Click(object sender, EventArgs e) {
			SaveDataTable();
		}

		private void btn_RefreshCOM_Click(object sender, EventArgs e) {
			InitializeCOMDropDown();
		}

#endregion
		
	}
}

