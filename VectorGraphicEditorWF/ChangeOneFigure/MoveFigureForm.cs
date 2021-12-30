using System;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class MoveFigureForm : Form
	{


		private MainForm mainForm;
		public MoveFigureForm()
		{
			InitializeComponent();
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
		}
		private void MoveFigure(object sender, EventArgs e)
		{
			try
			{
				mainForm.vectorDoc.figures[mainForm.selectedFigure].Move(Decimal.ToDouble(numericUpDown1.Value), Decimal.ToDouble(numericUpDown2.Value));
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка перемещения!");
				Close();
			}
			finally
			{
				MessageBox.Show("Успешное перемещение!");
				mainForm.RefreshChart(mainForm.vectorDoc);
				Close();
			}
		}
	}
}
