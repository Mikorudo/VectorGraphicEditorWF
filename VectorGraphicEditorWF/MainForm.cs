using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VectorGraphicEditorWF
{
	public partial class MainForm : Form
	{
		private int series;
		internal int selectedFigure;
		private double intervalX;
		public double IntervalX
		{
			get { return intervalX; }
			set
			{
				if (value < 0)
				{
					intervalX = 0.01;
					MessageBox.Show("Отрицательное значение интервала");
				}
				if ((chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.Minimum) / 25 < value)
				{
					intervalX = 0.01;
					MessageBox.Show("Слишком большой интервал");
				}
				if ((chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.Minimum) / value > 10000)
				{
					intervalX = 0.01;
					MessageBox.Show("Слишком маленький интервал");
				}
				intervalX = value;
			}
		}
		internal VectorDoc vectorDoc;
		public MainForm()
		{
			InitializeComponent();
			IntervalX = 0.01;
			series = 0;
			vectorDoc = new VectorDoc();
		}
		internal void RefreshChart(VectorDoc vectorDoc)
		{
			chart1.Series.Clear();
			series = 0;
			int size = vectorDoc.GetSize();
			for (int i = 0; i < size; i++)
			{
				Type type = vectorDoc.figures[i].GetType();
				if (type == typeof(Circle))
				{
					Circle temp = vectorDoc.figures[i] as Circle;
					AddCircleToChart(temp);
				}
				if (type == typeof(Quad))
				{
					Quad temp = vectorDoc.figures[i] as Quad;
					AddQuadToChart(temp);
				}
			}
			WriteFigureList();
		}
		private void AddCircleToChart(Circle circle)
		{
			double left = circle.GetCenterX() - circle.Radius;
			double right = circle.GetCenterX() + circle.Radius;
			double x, y;
			series++;
			int num = series;
			chart1.Series.Add("Series" + chart1.Series.Count);
			num--;
			this.chart1.Series[num].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			this.chart1.Series[num].Color = circle.color;
			this.chart1.Series[num].BorderWidth = 3;
			x = left;
			while (x < right)
			{
				y = Math.Sqrt(circle.Radius * circle.Radius - (x - circle.GetCenterX()) * (x - circle.GetCenterX())) + circle.GetCenterY();
				this.chart1.Series[num].Points.AddXY(x, y);
				x += IntervalX;
			}
			x = right;
			while (x > left)
			{
				y = -Math.Sqrt(circle.Radius * circle.Radius - (x - circle.GetCenterX()) * (x - circle.GetCenterX())) + circle.GetCenterY();
				this.chart1.Series[num].Points.AddXY(x, y);
				x -= IntervalX;
			}
			x = left;
			y = Math.Sqrt(circle.Radius * circle.Radius - (x - circle.GetCenterX()) * (x - circle.GetCenterX())) + circle.GetCenterY();
			this.chart1.Series[num].Points.AddXY(x, y);
		}
		private void AddQuadToChart(Quad quad)
		{
			for (int i = 0; i < 4; i++)
			{
				chart1.Series.Add("Series" + series);
				this.chart1.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
				this.chart1.Series[series].Color = quad.color;
				this.chart1.Series[series].BorderWidth = 3;

				Point p1 = quad.getPoint(i % 4);
				double x = p1.x;
				double y = p1.y;
				this.chart1.Series[series].Points.AddXY(x, y);

				Point p2 = quad.getPoint((i + 1) % 4);
				x = p2.x;
				y = p2.y;
				this.chart1.Series[series].Points.AddXY(x, y);
				series++;
			}
		}
		private void OpenChartSettings(object sender, EventArgs e)
		{
			ChartSettingsForm chartSettings = new ChartSettingsForm();
			chartSettings.Owner = this;
			chartSettings.StartForm();
			chartSettings.Show();
		}
		private void OpenQuadAdding(object sender, EventArgs e)
		{
			AddQuadForm addQuadForm = new AddQuadForm();
			addQuadForm.Owner = this;
			addQuadForm.StartForm();
			addQuadForm.Show();
		}
		private void OpenCircleAdding(object sender, EventArgs e)
		{
			AddCircleForm addCircleForm = new AddCircleForm();
			addCircleForm.Owner = this;
			addCircleForm.StartForm();
			addCircleForm.Show();
		}
		private void OpenScaleFigure(object sender, EventArgs e)
		{
			ScaleFigureForm scaleFigureForm = new ScaleFigureForm();
			scaleFigureForm.Owner = this;
			scaleFigureForm.StartForm();
			scaleFigureForm.Show();
		}
		private void OpenRotateFigure(object sender, EventArgs e)
		{
			RotateFigureForm rotateFigureForm = new RotateFigureForm();
			rotateFigureForm.Owner = this;
			rotateFigureForm.StartForm();
			rotateFigureForm.Show();
		}
		private void OpenMoveFigure(object sender, EventArgs e)
		{
			MoveFigureForm moveFigureForm = new MoveFigureForm();
			moveFigureForm.Owner = this;
			moveFigureForm.StartForm();
			moveFigureForm.Show();
		}
		private void WriteFigureList()
		{
			comboBox1.Items.Clear();
			int quadCount = 0;
			int circleCount = 0;
			for (int i = 0; i < vectorDoc.GetSize(); i++)
			{
				string str = "";
				Type type = vectorDoc.figures[i].GetType();
				if (type == typeof(Circle))
				{
					circleCount++;
					str += "Круг №" + circleCount;
				}
				if (type == typeof(Quad))
				{
					quadCount++;
					str += "Квадрат №" + quadCount;
				}
				comboBox1.Items.Add(str);
			}
			if (vectorDoc.GetSize() > 0)
				comboBox1.SelectedIndex = selectedFigure;
		}
		private void SelectedFigureChanged(object sender, EventArgs e)
		{
			if (vectorDoc.GetSize() > 0)
			{
				selectedFigure = comboBox1.SelectedIndex;
				PrintColorExample();
				#region EnableButton
				button4.Enabled = true;
				button5.Enabled = true;
				button6.Enabled = true;
				button7.Enabled = true;
				button8.Enabled = true;
				button9.Enabled = true;
				button10.Enabled = true;
				#endregion
			}
			else
			{
				#region DisableButton
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button8.Enabled = false;
				button9.Enabled = false;
				button10.Enabled = false;
				#endregion
			}
		}
		private void PrintColorExample()
		{
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics grf = Graphics.FromImage(bmp);
			grf.Clear(vectorDoc.figures[selectedFigure].color);
			pictureBox1.Image = bmp;
			pictureBox1.Refresh();
		}
		private void CalculatePerimeter(object sender, EventArgs e)
		{
			double result = vectorDoc.figures[selectedFigure].CalculatePerimeter();
			MessageBox.Show("Периметр фигуры: " + result);
		}
		private void CalculateArea(object sender, EventArgs e)
		{
			double result = vectorDoc.figures[selectedFigure].CalculateArea();
			MessageBox.Show("Площадь фигуры: " + result);
		}
		private void DeleteFigure(object sender, EventArgs e)
		{
			vectorDoc.DeleteFigure(selectedFigure);
			if (vectorDoc.GetSize() > 0)
			{
				selectedFigure = 0;
				comboBox1.SelectedIndex = selectedFigure;
			}
			else
			{
				#region EnableButton
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button8.Enabled = false;
				button9.Enabled = false;
				button10.Enabled = false;
				#endregion
				selectedFigure = -1;
				comboBox1.SelectedIndex = selectedFigure;
			}
			WriteFigureList();
			RefreshChart(vectorDoc);
		}
		private void ChangeFigure(object sender, EventArgs e)
		{
			Type type = vectorDoc.figures[selectedFigure].GetType();
			if (type == typeof(Circle))
			{
				ChangeCircleForm changeCircleForm = new ChangeCircleForm();
				changeCircleForm.Owner = this;
				changeCircleForm.StartForm();
				changeCircleForm.Show();
			}
			if (type == typeof(Quad))
			{
				ChangeQuadForm changeQuadForm = new ChangeQuadForm();
				changeQuadForm.Owner = this;
				changeQuadForm.StartForm();
				changeQuadForm.Show();
			}
		}
		private void SaveInMemory(object sender, EventArgs e)
		{
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream stream = new FileStream("vectorDoc.dat", FileMode.OpenOrCreate))
			{
				try
				{
					formatter.Serialize(stream, vectorDoc);

				}
				catch (Exception)
				{
					MessageBox.Show("Ошибка в сохранении");
				}
				finally
				{
					MessageBox.Show("Сохранение прошло успешно");
				}
			}
		}
		private void LoadFromMemory(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("После загрузки все текущие данные будут утеряны. Вы уверены, что хотите продолжить?", "Загрузка из памяти", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream stream = new FileStream("vectorDoc.dat", FileMode.OpenOrCreate))
				{
					try
					{
						vectorDoc = formatter.Deserialize(stream) as VectorDoc;
					}
					catch (Exception)
					{
						MessageBox.Show("Ошибка в загрузке из памяти");
					}
					finally
					{
						MessageBox.Show("Загрузка из памяти успешно завершена!");
						RefreshChart(vectorDoc);
					}
				}
			}
		}
		private void DeleteAllFigure(object sender, EventArgs e)
		{
			vectorDoc = new VectorDoc();
			#region EnableButton
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;
			button10.Enabled = false;
			#endregion
			selectedFigure = -1;
			comboBox1.SelectedIndex = selectedFigure;
			RefreshChart(vectorDoc);
			WriteFigureList();
		}
		private void OpenMoveAllFigure(object sender, EventArgs e)
		{
			MoveAllFigureForm moveAllFigureForm = new MoveAllFigureForm();
			moveAllFigureForm.Owner = this;
			moveAllFigureForm.StartForm();
			moveAllFigureForm.Show();
		}
		private void OpenRotateAllFigureForm(object sender, EventArgs e)
		{
			RotateAllFigureForm rotateAllFigureForm = new RotateAllFigureForm();
			rotateAllFigureForm.Owner = this;
			rotateAllFigureForm.StartForm();
			rotateAllFigureForm.Show();
		}
		private void OpenScaleAllFigureForm(object sender, EventArgs e)
		{
			ScaleAllFigureForm scaleAllFigureForm = new ScaleAllFigureForm();
			scaleAllFigureForm.Owner = this;
			scaleAllFigureForm.StartForm();
			scaleAllFigureForm.Show();
		}
	}
}