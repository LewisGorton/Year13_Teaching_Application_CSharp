namespace testForm
{
    partial class Midpoint
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
            this.imaginaryLabel2 = new System.Windows.Forms.Label();
            this.realLabel2 = new System.Windows.Forms.Label();
            this.imaginaryLabel1 = new System.Windows.Forms.Label();
            this.realLabel1 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.imagInput2 = new System.Windows.Forms.NumericUpDown();
            this.realInput2 = new System.Windows.Forms.NumericUpDown();
            this.imagInput1 = new System.Windows.Forms.NumericUpDown();
            this.realInput1 = new System.Windows.Forms.NumericUpDown();
            this.graphButton = new System.Windows.Forms.Button();
            this.demandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // imaginaryLabel2
            // 
            this.imaginaryLabel2.BackColor = System.Drawing.Color.White;
            this.imaginaryLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imaginaryLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imaginaryLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imaginaryLabel2.Location = new System.Drawing.Point(40, 596);
            this.imaginaryLabel2.Name = "imaginaryLabel2";
            this.imaginaryLabel2.Size = new System.Drawing.Size(345, 48);
            this.imaginaryLabel2.TabIndex = 52;
            this.imaginaryLabel2.Text = "Imaginary Component of b:";
            this.imaginaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel2
            // 
            this.realLabel2.BackColor = System.Drawing.Color.White;
            this.realLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.realLabel2.Location = new System.Drawing.Point(40, 448);
            this.realLabel2.Name = "realLabel2";
            this.realLabel2.Size = new System.Drawing.Size(343, 48);
            this.realLabel2.TabIndex = 51;
            this.realLabel2.Text = "Real Component of b:";
            this.realLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imaginaryLabel1
            // 
            this.imaginaryLabel1.BackColor = System.Drawing.Color.White;
            this.imaginaryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imaginaryLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imaginaryLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imaginaryLabel1.Location = new System.Drawing.Point(34, 147);
            this.imaginaryLabel1.Name = "imaginaryLabel1";
            this.imaginaryLabel1.Size = new System.Drawing.Size(349, 48);
            this.imaginaryLabel1.TabIndex = 50;
            this.imaginaryLabel1.Text = "Imaginary Component of a:";
            this.imaginaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel1
            // 
            this.realLabel1.BackColor = System.Drawing.Color.White;
            this.realLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.realLabel1.Location = new System.Drawing.Point(40, 297);
            this.realLabel1.Name = "realLabel1";
            this.realLabel1.Size = new System.Drawing.Size(343, 48);
            this.realLabel1.TabIndex = 49;
            this.realLabel1.Text = "Real Component of a:";
            this.realLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Location = new System.Drawing.Point(1434, 12);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(42, 43);
            this.Quit.TabIndex = 55;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.AliceBlue;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(42, 43);
            this.Back.TabIndex = 54;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
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
            this.imagInput2.Location = new System.Drawing.Point(40, 659);
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
            this.imagInput2.Size = new System.Drawing.Size(343, 62);
            this.imagInput2.TabIndex = 59;
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
            this.realInput2.Location = new System.Drawing.Point(40, 511);
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
            this.realInput2.Size = new System.Drawing.Size(343, 62);
            this.realInput2.TabIndex = 58;
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
            this.imagInput1.Location = new System.Drawing.Point(40, 360);
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
            this.imagInput1.Size = new System.Drawing.Size(343, 62);
            this.imagInput1.TabIndex = 57;
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
            this.realInput1.Location = new System.Drawing.Point(32, 210);
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
            this.realInput1.Size = new System.Drawing.Size(351, 62);
            this.realInput1.TabIndex = 56;
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.Color.White;
            this.graphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.graphButton.Location = new System.Drawing.Point(55, 771);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(293, 56);
            this.graphButton.TabIndex = 60;
            this.graphButton.Text = "Display Loci";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // demandLabel
            // 
            this.demandLabel.BackColor = System.Drawing.Color.White;
            this.demandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.demandLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.demandLabel.Location = new System.Drawing.Point(362, 29);
            this.demandLabel.Name = "demandLabel";
            this.demandLabel.Size = new System.Drawing.Size(768, 95);
            this.demandLabel.TabIndex = 74;
            this.demandLabel.Text = "Please input your two complex numbers:";
            this.demandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Midpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1488, 850);
            this.Controls.Add(this.demandLabel);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.imagInput2);
            this.Controls.Add(this.realInput2);
            this.Controls.Add(this.imagInput1);
            this.Controls.Add(this.realInput1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.imaginaryLabel2);
            this.Controls.Add(this.realLabel2);
            this.Controls.Add(this.imaginaryLabel1);
            this.Controls.Add(this.realLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Midpoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Midpoint";
            this.Load += new System.EventHandler(this.Midpoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label imaginaryLabel2;
        private System.Windows.Forms.Label realLabel2;
        private System.Windows.Forms.Label imaginaryLabel1;
        private System.Windows.Forms.Label realLabel1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.NumericUpDown imagInput2;
        private System.Windows.Forms.NumericUpDown realInput2;
        private System.Windows.Forms.NumericUpDown imagInput1;
        private System.Windows.Forms.NumericUpDown realInput1;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Label demandLabel;
    }
}