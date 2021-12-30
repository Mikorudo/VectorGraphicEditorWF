using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicEditorWF
{
	public partial class AddQuadForm : Form
	{
		private MainForm mainForm;

		private Point firstPoint;
		private Point secondPoint;
		private Point[] possibleThirdPoint;
		private int thirdPointIndex;
		private Point fouthPoint;
		Color color;

		public AddQuadForm()
		{
			InitializeComponent();
			mainForm = null;
			firstPoint = new Point(1, -1);
			secondPoint = new Point(-1, -1);
			possibleThirdPoint = new Point[4];
			CalculateThirdPoint();
			thirdPointIndex = 0;
			WriteThirdPoint();
			fouthPoint = new Point();
			CalculateFouthPoint();
			WriteFouthPoint();
			CalculateColor();
			PrintColorExample();
		}
		private void CalculateThirdPoint()
		{
			double dx = secondPoint.x - firstPoint.x;
			double dy = secondPoint.y - firstPoint.y;
			possibleThirdPoint[0] = new Point(secondPoint.x + dy, secondPoint.y - dx);
			possibleThirdPoint[1] = new Point(secondPoint.x - dy, secondPoint.y + dx);
		}
		private void CalculateFouthPoint()
		{
			double dx = secondPoint.x - firstPoint.x;
			double dy = secondPoint.y - firstPoint.y;
			switch (thirdPointIndex)
			{
				case 0: fouthPoint = new Point(firstPoint.x + dy, firstPoint.y - dx); break;
				case 1: fouthPoint = new Point(firstPoint.x - dy, firstPoint.y + dx); break;
				default: MessageBox.Show("Index error!"); break;
			}
		}
		private void CalculateColor()
		{
			int red = Decimal.ToInt32(numericUpDown5.Value);
			int green = Decimal.ToInt32(numericUpDown6.Value);
			int blue = Decimal.ToInt32(numericUpDown7.Value);
			int alpha = Decimal.ToInt32(numericUpDown8.Value);
			color = Color.FromArgb(alpha, red, green, blue);
		}
		private void WriteThirdPoint()
		{
			comboBox1.Items.Clear();
			for (int i = 0; i < 2; i++)
			{
				string str = "( ";
				str += possibleThirdPoint[i].x.ToString();
				str += "; ";
				str += possibleThirdPoint[i].y.ToString();
				str += " )";
				comboBox1.Items.Add(str);
			}
			comboBox1.SelectedIndex = thirdPointIndex;
		}
		private void WriteFouthPoint()
		{
			string str = "( ";
			str += fouthPoint.x.ToString();
			str += "; ";
			str += fouthPoint.y.ToString();
			str += " )";
			textBox5.Text = str;
		}
		private void PrintColorExample()
		{
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics grf = Graphics.FromImage(bmp);
			grf.Clear(color);
			pictureBox1.Image = bmp;
			pictureBox1.Refresh();
		}
		private void Points1or2Changed(object sender, EventArgs e)
		{
			firstPoint.x = Decimal.ToDouble(numericUpDown1.Value);
			firstPoint.y = Decimal.ToDouble(numericUpDown2.Value);
			secondPoint.x = Decimal.ToDouble(numericUpDown3.Value);
			secondPoint.y = Decimal.ToDouble(numericUpDown4.Value);
			CalculateThirdPoint();
			WriteThirdPoint();
			CalculateFouthPoint();
			WriteFouthPoint();
		}
		private void Point3Changed(object sender, EventArgs e)
		{
			CalculateThirdPoint();
			thirdPointIndex = comboBox1.SelectedIndex;
			CalculateFouthPoint();
			WriteFouthPoint();
		}
		private void ColorChanged(object sender, EventArgs e)
		{
			CalculateColor();
			PrintColorExample();
		}
		public void StartForm()
		{
			mainForm = this.Owner as MainForm;
		}
		private void AddQuadToDoc(object sender, EventArgs e)
		{
			try
			{
				CalculateThirdPoint();
				CalculateFouthPoint();
				Quad quad = new Quad(firstPoint, secondPoint, possibleThirdPoint[thirdPointIndex], fouthPoint, color);
				mainForm.vectorDoc.AddFigure(quad);
				quad = null;
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка!");
				this.Close();
			}
			finally
			{
				MessageBox.Show("Квадрат успешно добавлен!");
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
