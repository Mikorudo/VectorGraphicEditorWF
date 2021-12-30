namespace VectorGraphicEditorWF
{
	partial class ChangeQuadForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(166, 316);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Изменить квадрат";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddQuadToDoc);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Первая точка, X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Первая точка, Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(182, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Вторая точка, X";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(182, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Вторая точка, Y";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(323, 55);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Point3Changed);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(320, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Третья точка, ( X; Y )";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(320, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Четвёртая точка, ( X; Y )";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(323, 109);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(121, 20);
			this.textBox5.TabIndex = 13;
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(44, 199);
			this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown5.TabIndex = 14;
			this.numericUpDown5.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			this.numericUpDown5.Leave += new System.EventHandler(this.ColorChanged);
			// 
			// numericUpDown6
			// 
			this.numericUpDown6.Location = new System.Drawing.Point(45, 249);
			this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(139, 20);
			this.numericUpDown6.TabIndex = 15;
			this.numericUpDown6.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			this.numericUpDown6.Leave += new System.EventHandler(this.ColorChanged);
			// 
			// numericUpDown7
			// 
			this.numericUpDown7.Location = new System.Drawing.Point(222, 199);
			this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown7.TabIndex = 16;
			this.numericUpDown7.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			this.numericUpDown7.Leave += new System.EventHandler(this.ColorChanged);
			// 
			// numericUpDown8
			// 
			this.numericUpDown8.Location = new System.Drawing.Point(222, 249);
			this.numericUpDown8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown8.TabIndex = 17;
			this.numericUpDown8.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown8.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			this.numericUpDown8.Leave += new System.EventHandler(this.ColorChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(42, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Канал красного";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(42, 233);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Канал зелёного";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(219, 183);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Канал синего";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(219, 233);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Прозрачность";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(382, 199);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 63);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Location = new System.Drawing.Point(44, 55);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 23;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.Points1or2Changed);
			this.numericUpDown1.Leave += new System.EventHandler(this.Points1or2Changed);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 3;
			this.numericUpDown2.Location = new System.Drawing.Point(44, 110);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 24;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.Points1or2Changed);
			this.numericUpDown2.Leave += new System.EventHandler(this.Points1or2Changed);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 3;
			this.numericUpDown3.Location = new System.Drawing.Point(185, 55);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown3.TabIndex = 25;
			this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDown3.ValueChanged += new System.EventHandler(this.Points1or2Changed);
			this.numericUpDown3.Leave += new System.EventHandler(this.Points1or2Changed);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.DecimalPlaces = 3;
			this.numericUpDown4.Location = new System.Drawing.Point(185, 110);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown4.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown4.TabIndex = 26;
			this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDown4.ValueChanged += new System.EventHandler(this.Points1or2Changed);
			this.numericUpDown4.Leave += new System.EventHandler(this.Points1or2Changed);
			// 
			// ChangeQuadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(484, 411);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numericUpDown8);
			this.Controls.Add(this.numericUpDown7);
			this.Controls.Add(this.numericUpDown6);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "ChangeQuadForm";
			this.Text = "Изменение квадрата";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.NumericUpDown numericUpDown6;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
	}
}