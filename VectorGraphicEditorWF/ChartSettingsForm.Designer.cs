
namespace VectorGraphicEditorWF
{
	partial class ChartSettingsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Минимальное значение Оси X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Максимальное значение Оси X";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Минимальное значение Оси Y";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Максимальное значение Оси Y";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(116, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Шаг интервала по Ox";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(162, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SaveSettings);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Location = new System.Drawing.Point(36, 46);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            99998,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown1.TabIndex = 13;
			this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.AxisXChanged);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 3;
			this.numericUpDown2.Location = new System.Drawing.Point(35, 97);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            99998,
            0,
            0,
            -2147483648});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown2.TabIndex = 14;
			this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.AxisXChanged);
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 3;
			this.numericUpDown3.Location = new System.Drawing.Point(227, 45);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            99998,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown3.TabIndex = 15;
			this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.numericUpDown3.ValueChanged += new System.EventHandler(this.AxisYChanged);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.DecimalPlaces = 3;
			this.numericUpDown4.Location = new System.Drawing.Point(227, 97);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown4.Minimum = new decimal(new int[] {
            99998,
            0,
            0,
            -2147483648});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown4.TabIndex = 16;
			this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown4.ValueChanged += new System.EventHandler(this.AxisYChanged);
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.DecimalPlaces = 4;
			this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown5.Location = new System.Drawing.Point(118, 155);
			this.numericUpDown5.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(158, 20);
			this.numericUpDown5.TabIndex = 17;
			this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown5.ValueChanged += new System.EventHandler(this.IntervalChanged);
			// 
			// ChartSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(413, 246);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ChartSettingsForm";
			this.Text = "Настройки графика";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
	}
}