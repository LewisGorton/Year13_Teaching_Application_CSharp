namespace testForm
{
    partial class DisplayComplex
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
            this.realLabel = new System.Windows.Forms.Label();
            this.imagLabel = new System.Windows.Forms.Label();
            this.demandLabel = new System.Windows.Forms.Label();
            this.realInput = new System.Windows.Forms.NumericUpDown();
            this.imagInput = new System.Windows.Forms.NumericUpDown();
            this.displayButton = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.realInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput)).BeginInit();
            this.SuspendLayout();
            // 
            // realLabel
            // 
            this.realLabel.AutoSize = true;
            this.realLabel.BackColor = System.Drawing.Color.White;
            this.realLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realLabel.Location = new System.Drawing.Point(83, 159);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(219, 31);
            this.realLabel.TabIndex = 0;
            this.realLabel.Text = "Real component:";
            // 
            // imagLabel
            // 
            this.imagLabel.AutoSize = true;
            this.imagLabel.BackColor = System.Drawing.Color.White;
            this.imagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagLabel.Location = new System.Drawing.Point(83, 285);
            this.imagLabel.Name = "imagLabel";
            this.imagLabel.Size = new System.Drawing.Size(282, 31);
            this.imagLabel.TabIndex = 1;
            this.imagLabel.Text = "Imaginary component:";
            // 
            // demandLabel
            // 
            this.demandLabel.BackColor = System.Drawing.Color.White;
            this.demandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandLabel.Location = new System.Drawing.Point(198, 71);
            this.demandLabel.Name = "demandLabel";
            this.demandLabel.Size = new System.Drawing.Size(1018, 55);
            this.demandLabel.TabIndex = 2;
            this.demandLabel.Text = "Input the real and complex components below:";
            this.demandLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.realInput.Location = new System.Drawing.Point(89, 202);
            this.realInput.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.realInput.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.realInput.Name = "realInput";
            this.realInput.Size = new System.Drawing.Size(306, 62);
            this.realInput.TabIndex = 3;
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
            this.imagInput.Location = new System.Drawing.Point(89, 330);
            this.imagInput.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.imagInput.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.imagInput.Name = "imagInput";
            this.imagInput.Size = new System.Drawing.Size(306, 62);
            this.imagInput.TabIndex = 4;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.White;
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(139, 420);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(207, 68);
            this.displayButton.TabIndex = 5;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Location = new System.Drawing.Point(1423, 25);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(42, 43);
            this.Quit.TabIndex = 68;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.AliceBlue;
            this.Back.Location = new System.Drawing.Point(37, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(42, 43);
            this.Back.TabIndex = 67;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DisplayComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1497, 592);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.imagInput);
            this.Controls.Add(this.realInput);
            this.Controls.Add(this.demandLabel);
            this.Controls.Add(this.imagLabel);
            this.Controls.Add(this.realLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayComplex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DisplayComplex";
            this.Load += new System.EventHandler(this.DisplayComplex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Label imagLabel;
        private System.Windows.Forms.Label demandLabel;
        private System.Windows.Forms.NumericUpDown realInput;
        private System.Windows.Forms.NumericUpDown imagInput;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Back;
    }
}