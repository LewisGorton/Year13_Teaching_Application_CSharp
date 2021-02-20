namespace testForm
{
    partial class Operations
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
            this.imagInput1 = new System.Windows.Forms.NumericUpDown();
            this.realInput1 = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.Button();
            this.imaginaryLabel1 = new System.Windows.Forms.Label();
            this.realLabel1 = new System.Windows.Forms.Label();
            this.imagInput2 = new System.Windows.Forms.NumericUpDown();
            this.realInput2 = new System.Windows.Forms.NumericUpDown();
            this.imaginaryLabel2 = new System.Windows.Forms.Label();
            this.realLabel2 = new System.Windows.Forms.Label();
            this.demandLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.modulusButton = new System.Windows.Forms.RadioButton();
            this.realButton = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // imagInput1
            // 
            this.imagInput1.DecimalPlaces = 4;
            this.imagInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagInput1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.imagInput1.Location = new System.Drawing.Point(384, 233);
            this.imagInput1.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.imagInput1.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.imagInput1.Name = "imagInput1";
            this.imagInput1.Size = new System.Drawing.Size(310, 62);
            this.imagInput1.TabIndex = 14;
            // 
            // realInput1
            // 
            this.realInput1.DecimalPlaces = 4;
            this.realInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realInput1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.realInput1.Location = new System.Drawing.Point(76, 233);
            this.realInput1.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.realInput1.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.realInput1.Name = "realInput1";
            this.realInput1.Size = new System.Drawing.Size(302, 62);
            this.realInput1.TabIndex = 13;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.output.Location = new System.Drawing.Point(1146, 354);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(180, 81);
            this.output.TabIndex = 12;
            this.output.Text = "Calculate";
            this.output.UseVisualStyleBackColor = false;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // imaginaryLabel1
            // 
            this.imaginaryLabel1.BackColor = System.Drawing.Color.White;
            this.imaginaryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imaginaryLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imaginaryLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imaginaryLabel1.Location = new System.Drawing.Point(700, 170);
            this.imaginaryLabel1.Name = "imaginaryLabel1";
            this.imaginaryLabel1.Size = new System.Drawing.Size(308, 48);
            this.imaginaryLabel1.TabIndex = 11;
            this.imaginaryLabel1.Text = "Imaginary Component:";
            this.imaginaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel1
            // 
            this.realLabel1.BackColor = System.Drawing.Color.White;
            this.realLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.realLabel1.Location = new System.Drawing.Point(386, 170);
            this.realLabel1.Name = "realLabel1";
            this.realLabel1.Size = new System.Drawing.Size(308, 48);
            this.realLabel1.TabIndex = 10;
            this.realLabel1.Text = "Real Component:";
            this.realLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagInput2
            // 
            this.imagInput2.DecimalPlaces = 4;
            this.imagInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagInput2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.imagInput2.Location = new System.Drawing.Point(1014, 233);
            this.imagInput2.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.imagInput2.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.imagInput2.Name = "imagInput2";
            this.imagInput2.Size = new System.Drawing.Size(312, 62);
            this.imagInput2.TabIndex = 19;
            // 
            // realInput2
            // 
            this.realInput2.DecimalPlaces = 4;
            this.realInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realInput2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.realInput2.Location = new System.Drawing.Point(699, 233);
            this.realInput2.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.realInput2.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.realInput2.Name = "realInput2";
            this.realInput2.Size = new System.Drawing.Size(309, 62);
            this.realInput2.TabIndex = 18;
            // 
            // imaginaryLabel2
            // 
            this.imaginaryLabel2.BackColor = System.Drawing.Color.White;
            this.imaginaryLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imaginaryLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imaginaryLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imaginaryLabel2.Location = new System.Drawing.Point(76, 170);
            this.imaginaryLabel2.Name = "imaginaryLabel2";
            this.imaginaryLabel2.Size = new System.Drawing.Size(304, 48);
            this.imaginaryLabel2.TabIndex = 16;
            this.imaginaryLabel2.Text = "Imaginary Component:";
            this.imaginaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel2
            // 
            this.realLabel2.BackColor = System.Drawing.Color.White;
            this.realLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.realLabel2.Location = new System.Drawing.Point(1014, 170);
            this.realLabel2.Name = "realLabel2";
            this.realLabel2.Size = new System.Drawing.Size(308, 48);
            this.realLabel2.TabIndex = 15;
            this.realLabel2.Text = "Real Component:";
            this.realLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // demandLabel
            // 
            this.demandLabel.BackColor = System.Drawing.Color.White;
            this.demandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.demandLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.demandLabel.Location = new System.Drawing.Point(157, 18);
            this.demandLabel.Name = "demandLabel";
            this.demandLabel.Size = new System.Drawing.Size(1068, 95);
            this.demandLabel.TabIndex = 20;
            this.demandLabel.Text = "Input the numbers that you want to (operation):";
            this.demandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.AliceBlue;
            this.Back.Location = new System.Drawing.Point(12, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 53);
            this.Back.TabIndex = 21;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Location = new System.Drawing.Point(1311, 6);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(42, 43);
            this.Quit.TabIndex = 22;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // modulusButton
            // 
            this.modulusButton.AutoSize = true;
            this.modulusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulusButton.Location = new System.Drawing.Point(78, 400);
            this.modulusButton.Name = "modulusButton";
            this.modulusButton.Size = new System.Drawing.Size(330, 35);
            this.modulusButton.TabIndex = 23;
            this.modulusButton.Text = "Modulus-Argument Form";
            this.modulusButton.UseVisualStyleBackColor = true;
            // 
            // realButton
            // 
            this.realButton.AutoSize = true;
            this.realButton.Checked = true;
            this.realButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realButton.Location = new System.Drawing.Point(78, 354);
            this.realButton.Name = "realButton";
            this.realButton.Size = new System.Drawing.Size(336, 35);
            this.realButton.TabIndex = 24;
            this.realButton.TabStop = true;
            this.realButton.Text = "Real and Imaginary Form";
            this.realButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(110, 97);
            this.outputLabel.MaximumSize = new System.Drawing.Size(999999, 100000000);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 55);
            this.outputLabel.TabIndex = 25;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1365, 670);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.realButton);
            this.Controls.Add(this.modulusButton);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.demandLabel);
            this.Controls.Add(this.imagInput2);
            this.Controls.Add(this.realInput2);
            this.Controls.Add(this.imaginaryLabel2);
            this.Controls.Add(this.realLabel2);
            this.Controls.Add(this.imagInput1);
            this.Controls.Add(this.realInput1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.imaginaryLabel1);
            this.Controls.Add(this.realLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Divide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown imagInput1;
        private System.Windows.Forms.NumericUpDown realInput1;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label imaginaryLabel1;
        private System.Windows.Forms.Label realLabel1;
        private System.Windows.Forms.NumericUpDown imagInput2;
        private System.Windows.Forms.NumericUpDown realInput2;
        private System.Windows.Forms.Label imaginaryLabel2;
        private System.Windows.Forms.Label realLabel2;
        private System.Windows.Forms.Label demandLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.RadioButton modulusButton;
        private System.Windows.Forms.RadioButton realButton;
        private System.Windows.Forms.Label outputLabel;
    }
}