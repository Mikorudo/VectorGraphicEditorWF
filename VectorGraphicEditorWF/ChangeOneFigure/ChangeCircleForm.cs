using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class ChangeCircleForm : Form
	{
		private MainForm mainForm;
		private int changeableFigure;

		private Point center;
		private double radius;
		Color color;

		public ChangeCircleForm()
		{
			InitializeComponent();
			mainForm = null;
			center = new Point(0, 0);
			radius = 1.0;
			CalculateColor();
			PrintColorExample();
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
			changeableFigure = mainForm.selectedFigure;
			Circle temp = mainForm.vectorDoc.figures[changeableFigure] as Circle;
			numericUpDown1.Value = Convert.ToDecimal(temp.GetCenterX());
			numericUpDown2.Value = Convert.ToDecimal(temp.GetCenterY());
			numericUpDown3.Value = Convert.ToDecimal(temp.Radius);
			Color color = temp.color;
			numericUpDown4.Value = Convert.ToDecimal(color.R);
			numericUpDown5.Value = Convert.ToDecimal(color.G);
			numericUpDown6.Value = Convert.ToDecimal(color.B);
			numericUpDown7.Value = Convert.ToDecimal(color.A);
			CalculateColor();
			PrintColorExample();
		}
		private void ParamsChanged(object sender, EventArgs e)
		{
			center.x = Decimal.ToDouble(numericUpDown1.Value);
			center.y = Decimal.ToDouble(numericUpDown2.Value);
			radius = Decimal.ToDouble(numericUpDown3.Value);
		}
		private void CalculateColor()
		{
			int red = Decimal.ToInt32(numericUpDown4.Value);
			int green = Decimal.ToInt32(numericUpDown5.Value);
			int blue = Decimal.ToInt32(numericUpDown6.Value);
			int alpha = Decimal.ToInt32(numericUpDown7.Value);
			color = Color.FromArgb(alpha, red, green, blue);
		}
		private void PrintColorExample()
		{
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics grf = Graphics.FromImage(bmp);
			grf.Clear(color);
			pictureBox1.Image = bmp;
			pictureBox1.Refresh();
		}
		private void ColorChanged(object sender, EventArgs e)
		{
			CalculateColor();
			PrintColorExample();
		}
		private void AddCircleToDoc(object sender, EventArgs e)
		{
			try
			{
				mainForm.vectorDoc.figures[changeableFigure] = new Circle(center, radius, color);
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка!");
				this.Close();
			}
			finally
			{
				MessageBox.Show("Круг успешно изменён!");
				mainForm.RefreshChart(mainForm.vectorDoc);
				this.Close();
			}
		}

		private void ColorChanged(object sender, KeyEventArgs e)
		{
			CalculateColor();
			PrintColorExample();
		}
	}
}
