using System;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class ScaleFigureForm : Form
	{
		private MainForm mainForm;
		public ScaleFigureForm()
		{
			InitializeComponent();
			mainForm = null;
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
		}
		private void Scale(object sender, EventArgs e)
		{
			try
			{
				mainForm.vectorDoc.figures[mainForm.selectedFigure].Scale(Decimal.ToDouble(numericUpDown1.Value));
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка увеличения!");
				Close();
			}
			finally
			{
				MessageBox.Show("Успешное увеличение!");
				mainForm.RefreshChart(mainForm.vectorDoc);
				Close();
			}
		}
	}
}
