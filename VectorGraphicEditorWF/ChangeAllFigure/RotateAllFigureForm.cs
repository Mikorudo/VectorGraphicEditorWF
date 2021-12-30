using System;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class RotateAllFigureForm : Form
	{
		private MainForm mainForm;
		public RotateAllFigureForm()
		{
			InitializeComponent();
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
		}
		private void Rotate(object sender, EventArgs e)
		{
			try
			{
				mainForm.vectorDoc.Rotate(Decimal.ToDouble(numericUpDown1.Value));
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка поворта!");
				Close();
			}
			finally
			{
				MessageBox.Show("Успешный поворот!");
				mainForm.RefreshChart(mainForm.vectorDoc);
				Close();
			}
		}
	}
}
