namespace testForm
{
    partial class ParameterGraph
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
            this.parameterInput = new System.Windows.Forms.NumericUpDown();
            this.bInput = new System.Windows.Forms.NumericUpDown();
            this.aInput = new System.Windows.Forms.NumericUpDown();
            this.Quit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.demandLabel = new System.Windows.Forms.Label();
            this.parameterLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.graphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parameterInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).BeginInit();
            this.SuspendLayout();
            // 
            // parameterInput
            // 
            this.parameterInput.DecimalPlaces = 4;
            this.parameterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.parameterInput.Location = new System.Drawing.Point(12, 626);
            this.parameterInput.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.parameterInput.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.parameterInput.Name = "parameterInput";
            this.parameterInput.Size = new System.Drawing.Size(315, 62);
            this.parameterInput.TabIndex = 69;
            // 
            // bInput
            // 
            this.bInput.DecimalPlaces = 4;
            this.bInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.bInput.Location = new System.Drawing.Point(12, 451);
            this.bInput.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.bInput.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(315, 62);
            this.bInput.TabIndex = 68;
            // 
            // aInput
            // 
            this.aInput.DecimalPlaces = 4;
            this.aInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aInput.Location = new System.Drawing.Point(12, 263);
            this.aInput.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.aInput.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            -2147483648});
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(315, 62);
            this.aInput.TabIndex = 67;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit.Location = new System.Drawing.Point(1339, 12);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(42, 43);
            this.Quit.TabIndex = 66;
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
            this.Back.TabIndex = 65;
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
            this.demandLabel.Location = new System.Drawing.Point(106, 49);
            this.demandLabel.Name = "demandLabel";
            this.demandLabel.Size = new System.Drawing.Size(1180, 95);
            this.demandLabel.TabIndex = 64;
            this.demandLabel.Text = "Please input your values of a, b and (Parameter Type):";
            this.demandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parameterLabel
            // 
            this.parameterLabel.BackColor = System.Drawing.Color.White;
            this.parameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.parameterLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.parameterLabel.Location = new System.Drawing.Point(12, 561);
            this.parameterLabel.Name = "parameterLabel";
            this.parameterLabel.Size = new System.Drawing.Size(315, 48);
            this.parameterLabel.TabIndex = 62;
            this.parameterLabel.Text = "(Parameter Type):";
            this.parameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bLabel
            // 
            this.bLabel.BackColor = System.Drawing.Color.White;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bLabel.Location = new System.Drawing.Point(12, 387);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(315, 48);
            this.bLabel.TabIndex = 61;
            this.bLabel.Text = "b:";
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aLabel
            // 
            this.aLabel.BackColor = System.Drawing.Color.White;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.aLabel.Location = new System.Drawing.Point(12, 203);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(315, 48);
            this.aLabel.TabIndex = 60;
            this.aLabel.Text = "a:";
            this.aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.Color.White;
            this.graphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.graphButton.Location = new System.Drawing.Point(12, 713);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(309, 56);
            this.graphButton.TabIndex = 70;
            this.graphButton.Text = "Display Loci";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // ParameterGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1393, 848);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.parameterInput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.demandLabel);
            this.Controls.Add(this.parameterLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParameterGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Halfline";
            this.Load += new System.EventHandler(this.Halfline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parameterInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown parameterInput;
        private System.Windows.Forms.NumericUpDown bInput;
        private System.Windows.Forms.NumericUpDown aInput;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label demandLabel;
        private System.Windows.Forms.Label parameterLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Button graphButton;
    }
}