using System;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class RotateFigureForm : Form
	{
		private MainForm mainForm;
		public RotateFigureForm()
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
				mainForm.vectorDoc.figures[mainForm.selectedFigure].Rotate(Decimal.ToDouble(numericUpDown1.Value));
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
