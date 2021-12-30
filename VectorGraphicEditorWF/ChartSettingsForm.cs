using System;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class ChartSettingsForm : Form
	{
		private MainForm mainForm;
		public ChartSettingsForm()
		{
			InitializeComponent();
			mainForm = null;
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
			numericUpDown1.Value = Convert.ToDecimal(mainForm.chart1.ChartAreas[0].AxisX.Minimum);
			numericUpDown2.Value = Convert.ToDecimal(mainForm.chart1.ChartAreas[0].AxisX.Maximum);
			numericUpDown3.Value = Convert.ToDecimal(mainForm.chart1.ChartAreas[0].AxisY.Minimum);
			numericUpDown4.Value = Convert.ToDecimal(mainForm.chart1.ChartAreas[0].AxisY.Maximum);
			numericUpDown5.Value = Convert.ToDecimal(mainForm.IntervalX);
		}
		private void SaveSettings(object sender, EventArgs e)
		{
			mainForm.chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(numericUpDown1.Value);
			mainForm.chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(numericUpDown2.Value);
			mainForm.chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(numericUpDown3.Value);
			mainForm.chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(numericUpDown4.Value);
			mainForm.IntervalX = Convert.ToDouble(numericUpDown5.Value);
			MessageBox.Show("Настройки сохранены");
			mainForm.RefreshChart(mainForm.vectorDoc);
		}
		private void AxisXChanged(object sender, EventArgs e)
		{
			if (numericUpDown1.Value >= numericUpDown2.Value)
			{
				if (numericUpDown1.Value < 0)
					numericUpDown2.Value = numericUpDown1.Value + 10;
				else
					numericUpDown1.Value = numericUpDown2.Value - 10;
			}
		}
		private void AxisYChanged(object sender, EventArgs e)
		{
			if (numericUpDown3.Value >= numericUpDown4.Value)
			{
				if (numericUpDown3.Value < 0)
					numericUpDown4.Value = numericUpDown3.Value + 10;
				else
					numericUpDown3.Value = numericUpDown4.Value - 10;
			}
		}

		private void IntervalChanged(object sender, EventArgs e)
		{
			if ((numericUpDown4.Value - numericUpDown3.Value) / numericUpDown5.Value < 20)
				numericUpDown5.Value = (numericUpDown4.Value - numericUpDown3.Value) / 20;
			else if((numericUpDown4.Value - numericUpDown3.Value) / numericUpDown5.Value > 5000)
				numericUpDown5.Value = (numericUpDown4.Value - numericUpDown3.Value) / 5000;
		}
	}
}
