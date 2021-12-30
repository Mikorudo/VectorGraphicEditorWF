
namespace VectorGraphicEditorWF
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button16 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chart1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.button16);
			this.splitContainer1.Panel2.Controls.Add(this.button15);
			this.splitContainer1.Panel2.Controls.Add(this.button14);
			this.splitContainer1.Panel2.Controls.Add(this.button13);
			this.splitContainer1.Panel2.Controls.Add(this.button12);
			this.splitContainer1.Panel2.Controls.Add(this.button11);
			this.splitContainer1.Panel2.Controls.Add(this.button10);
			this.splitContainer1.Panel2.Controls.Add(this.button9);
			this.splitContainer1.Panel2.Controls.Add(this.button8);
			this.splitContainer1.Panel2.Controls.Add(this.button7);
			this.splitContainer1.Panel2.Controls.Add(this.button6);
			this.splitContainer1.Panel2.Controls.Add(this.button5);
			this.splitContainer1.Panel2.Controls.Add(this.button4);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel2.Controls.Add(this.button3);
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Size = new System.Drawing.Size(857, 508);
			this.splitContainer1.SplitterDistance = 518;
			this.splitContainer1.TabIndex = 0;
			// 
			// chart1
			// 
			chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.AxisX.Maximum = 5D;
			chartArea1.AxisX.Minimum = -5D;
			chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.AxisY.Maximum = 5D;
			chartArea1.AxisY.Minimum = -5D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.Fuchsia;
			series1.MarkerColor = System.Drawing.Color.Thistle;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(518, 508);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(47, 246);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(261, 23);
			this.button16.TabIndex = 58;
			this.button16.Text = "Повернуть все фигуры";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.OpenRotateAllFigureForm);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(47, 217);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(261, 23);
			this.button15.TabIndex = 57;
			this.button15.Text = "Увеличить все фигуры";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.OpenScaleAllFigureForm);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(47, 188);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(261, 23);
			this.button14.TabIndex = 56;
			this.button14.Text = "Переместить все фигуры";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.OpenMoveAllFigure);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(47, 159);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(261, 23);
			this.button13.TabIndex = 55;
			this.button13.Text = "Удалить все фигуры";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.DeleteAllFigure);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(47, 88);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(261, 23);
			this.button12.TabIndex = 54;
			this.button12.Text = "Загрузить из памяти";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.LoadFromMemory);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(47, 59);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(261, 23);
			this.button11.TabIndex = 53;
			this.button11.Text = "Сохранить в память";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.SaveInMemory);
			// 
			// button10
			// 
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(47, 398);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(121, 25);
			this.button10.TabIndex = 52;
			this.button10.Text = "Переместить фигуру";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.OpenMoveFigure);
			// 
			// button9
			// 
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(187, 459);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(121, 25);
			this.button9.TabIndex = 51;
			this.button9.Text = "Посчитать площадь";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.CalculateArea);
			// 
			// button8
			// 
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(47, 459);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(121, 25);
			this.button8.TabIndex = 50;
			this.button8.Text = "Посчитать периметр";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.CalculatePerimeter);
			// 
			// button7
			// 
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(187, 399);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(121, 23);
			this.button7.TabIndex = 49;
			this.button7.Text = "Повернуть фигуру";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.OpenRotateFigure);
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(187, 370);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(121, 23);
			this.button6.TabIndex = 48;
			this.button6.Text = "Увеличить фигуру";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.OpenScaleFigure);
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(47, 430);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(261, 23);
			this.button5.TabIndex = 47;
			this.button5.Text = "Изменить фигуру";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ChangeFigure);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(47, 370);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 23);
			this.button4.TabIndex = 46;
			this.button4.Text = "Удалить фигуру";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.DeleteFigure);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(285, 343);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 21);
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(187, 314);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Добавить круг";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.OpenCircleAdding);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(47, 314);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Добавить квадрат";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.OpenQuadAdding);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(47, 343);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(222, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedFigureChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(108, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Настройки графика";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OpenChartSettings);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(857, 508);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "Графический редактор";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
	}
}

