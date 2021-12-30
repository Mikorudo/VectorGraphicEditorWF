
namespace VectorGraphicEditorWF
{
	partial class RotateAllFigureForm
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 1;
			this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(60, 110);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(178, 20);
			this.numericUpDown1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "На какой угол повернуть фигуру?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(95, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Повернуть фигуры";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Rotate);
			// 
			// RotateAllFigureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(304, 270);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "RotateAllFigureForm";
			this.Text = "Поворот фигур";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}