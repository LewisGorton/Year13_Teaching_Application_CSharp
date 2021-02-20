namespace testForm
{
    partial class ModulusArgument
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
            this.Quit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.demandLabel = new System.Windows.Forms.Label();
            this.realLabel = new System.Windows.Forms.Label();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Button();
            this.realInput = new System.Windows.Forms.NumericUpDown();
            this.imagInput = new System.Windows.Forms.NumericUpDown();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.realInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Location = new System.Drawing.Point(1409, 12);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(42, 43);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.AliceBlue;
            this.Back.Location = new System.Drawing.Point(20, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(42, 43);
            this.Back.TabIndex = 1;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // demandLabel
            // 
            this.demandLabel.BackColor = System.Drawing.Color.White;
            this.demandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.demandLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.demandLabel.Location = new System.Drawing.Point(154, 59);
            this.demandLabel.Name = "demandLabel";
            this.demandLabel.Size = new System.Drawing.Size(1182, 104);
            this.demandLabel.TabIndex = 2;
            this.demandLabel.Text = "Input the real and imaginary components for the complex number:";
            this.demandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel
            // 
            this.realLabel.BackColor = System.Drawing.Color.White;
            this.realLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.realLabel.Location = new System.Drawing.Point(12, 233);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(742, 48);
            this.realLabel.TabIndex = 4;
            this.realLabel.Text = "Real Component:";
            this.realLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.BackColor = System.Drawing.Color.White;
            this.imaginaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imaginaryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imaginaryLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imaginaryLabel.Location = new System.Drawing.Point(798, 233);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(653, 48);
            this.imaginaryLabel.TabIndex = 6;
            this.imaginaryLabel.Text = "Imaginary Component:";
            this.imaginaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.output.Location = new System.Drawing.Point(681, 382);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(196, 101);
            this.output.TabIndex = 7;
            this.output.Text = "Calculate";
            this.output.UseVisualStyleBackColor = false;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // realInput
            // 
            this.realInput.DecimalPlaces = 4;
            this.realInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.realInput.Location = new System.Drawing.Point(12, 297);
            this.realInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.realInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.realInput.Name = "realInput";
            this.realInput.Size = new System.Drawing.Size(742, 62);
            this.realInput.TabIndex = 8;
            // 
            // imagInput
            // 
            this.imagInput.DecimalPlaces = 4;
            this.imagInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.imagInput.Location = new System.Drawing.Point(795, 297);
            this.imagInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.imagInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.imagInput.Name = "imagInput";
            this.imagInput.Size = new System.Drawing.Size(656, 62);
            this.imagInput.TabIndex = 9;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(62, 166);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 55);
            this.outputLabel.TabIndex = 10;
            // 
            // ModulusArgument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1463, 664);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.imagInput);
            this.Controls.Add(this.realInput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.realLabel);
            this.Controls.Add(this.demandLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Quit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModulusArgument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModulusArgument";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label demandLabel;
        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.NumericUpDown realInput;
        private System.Windows.Forms.NumericUpDown imagInput;
        private System.Windows.Forms.Label outputLabel;
    }
}