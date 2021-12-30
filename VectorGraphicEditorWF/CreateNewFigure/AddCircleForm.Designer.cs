namespace VectorGraphicEditorWF
{
	partial class AddCircleForm
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
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 3;
			this.numericUpDown3.Location = new System.Drawing.Point(207, 53);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown3.TabIndex = 47;
			this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.ValueChanged += new System.EventHandler(this.ParamsChanged);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 3;
			this.numericUpDown2.Location = new System.Drawing.Point(38, 108);
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
			this.numericUpDown2.TabIndex = 46;
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.ParamsChanged);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Location = new System.Drawing.Point(38, 53);
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
			this.numericUpDown1.TabIndex = 45;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.ParamsChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(382, 197);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 63);
			this.pictureBox1.TabIndex = 44;
			this.pictureBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(213, 231);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 13);
			this.label10.TabIndex = 43;
			this.label10.Text = "Прозрачность";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(213, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 42;
			this.label9.Text = "Канал синего";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(36, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "Канал зелёного";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(36, 181);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 13);
			this.label7.TabIndex = 40;
			this.label7.Text = "Канал красного";
			// 
			// numericUpDown7
			// 
			this.numericUpDown7.Location = new System.Drawing.Point(216, 247);
			this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown7.TabIndex = 39;
			this.numericUpDown7.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown7.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			// 
			// numericUpDown6
			// 
			this.numericUpDown6.Location = new System.Drawing.Point(216, 197);
			this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown6.TabIndex = 38;
			this.numericUpDown6.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(39, 247);
			this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(139, 20);
			this.numericUpDown5.TabIndex = 37;
			this.numericUpDown5.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(38, 197);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(140, 20);
			this.numericUpDown4.TabIndex = 36;
			this.numericUpDown4.ValueChanged += new System.EventHandler(this.ColorChanged);
			this.numericUpDown4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ColorChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Радиус";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Центр, Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Центр, X";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 314);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "Добавить круг";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddCircleToDoc);
			// 
			// AddCircleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(484, 411);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numericUpDown7);
			this.Controls.Add(this.numericUpDown6);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "AddCircleForm";
			this.Text = "Добавление круга";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.NumericUpDown numericUpDown6;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}