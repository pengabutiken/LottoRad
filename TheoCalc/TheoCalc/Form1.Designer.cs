namespace TheoCalc
{
    partial class Form1
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.UserInputLabel = new System.Windows.Forms.Label();
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.NumPadPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OneB = new System.Windows.Forms.Button();
            this.TwoB = new System.Windows.Forms.Button();
            this.ThreeB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.FourB = new System.Windows.Forms.Button();
            this.FiveB = new System.Windows.Forms.Button();
            this.SixB = new System.Windows.Forms.Button();
            this.SubB = new System.Windows.Forms.Button();
            this.SevenB = new System.Windows.Forms.Button();
            this.EightB = new System.Windows.Forms.Button();
            this.NineB = new System.Windows.Forms.Button();
            this.MultiplyB = new System.Windows.Forms.Button();
            this.ResetB = new System.Windows.Forms.Button();
            this.ZeroB = new System.Windows.Forms.Button();
            this.EqualsB = new System.Windows.Forms.Button();
            this.DivideB = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.InputPanel.SuspendLayout();
            this.NumPadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.UserInputLabel);
            this.InputPanel.Controls.Add(this.UserInputBox);
            this.InputPanel.Location = new System.Drawing.Point(13, 13);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(277, 83);
            this.InputPanel.TabIndex = 0;
            // 
            // UserInputLabel
            // 
            this.UserInputLabel.AutoSize = true;
            this.UserInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputLabel.Location = new System.Drawing.Point(207, 18);
            this.UserInputLabel.Name = "UserInputLabel";
            this.UserInputLabel.Size = new System.Drawing.Size(0, 36);
            this.UserInputLabel.TabIndex = 1;
            // 
            // UserInputBox
            // 
            this.UserInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputBox.Location = new System.Drawing.Point(3, 18);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.ReadOnly = true;
            this.UserInputBox.Size = new System.Drawing.Size(197, 49);
            this.UserInputBox.TabIndex = 0;
            // 
            // NumPadPanel
            // 
            this.NumPadPanel.Controls.Add(this.OneB);
            this.NumPadPanel.Controls.Add(this.TwoB);
            this.NumPadPanel.Controls.Add(this.ThreeB);
            this.NumPadPanel.Controls.Add(this.AddB);
            this.NumPadPanel.Controls.Add(this.FourB);
            this.NumPadPanel.Controls.Add(this.FiveB);
            this.NumPadPanel.Controls.Add(this.SixB);
            this.NumPadPanel.Controls.Add(this.SubB);
            this.NumPadPanel.Controls.Add(this.SevenB);
            this.NumPadPanel.Controls.Add(this.EightB);
            this.NumPadPanel.Controls.Add(this.NineB);
            this.NumPadPanel.Controls.Add(this.MultiplyB);
            this.NumPadPanel.Controls.Add(this.ResetB);
            this.NumPadPanel.Controls.Add(this.ZeroB);
            this.NumPadPanel.Controls.Add(this.EqualsB);
            this.NumPadPanel.Controls.Add(this.DivideB);
            this.NumPadPanel.Location = new System.Drawing.Point(13, 102);
            this.NumPadPanel.Name = "NumPadPanel";
            this.NumPadPanel.Size = new System.Drawing.Size(277, 257);
            this.NumPadPanel.TabIndex = 1;
            // 
            // OneB
            // 
            this.OneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneB.Location = new System.Drawing.Point(3, 3);
            this.OneB.Name = "OneB";
            this.OneB.Size = new System.Drawing.Size(64, 58);
            this.OneB.TabIndex = 0;
            this.OneB.Text = "1";
            this.OneB.UseVisualStyleBackColor = true;
            this.OneB.Click += new System.EventHandler(this.OneB_Click);
            // 
            // TwoB
            // 
            this.TwoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoB.Location = new System.Drawing.Point(73, 3);
            this.TwoB.Name = "TwoB";
            this.TwoB.Size = new System.Drawing.Size(64, 58);
            this.TwoB.TabIndex = 0;
            this.TwoB.Text = "2";
            this.TwoB.UseVisualStyleBackColor = true;
            this.TwoB.Click += new System.EventHandler(this.TwoB_Click);
            // 
            // ThreeB
            // 
            this.ThreeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeB.Location = new System.Drawing.Point(143, 3);
            this.ThreeB.Name = "ThreeB";
            this.ThreeB.Size = new System.Drawing.Size(62, 58);
            this.ThreeB.TabIndex = 0;
            this.ThreeB.Text = "3";
            this.ThreeB.UseVisualStyleBackColor = true;
            this.ThreeB.Click += new System.EventHandler(this.ThreeB_Click);
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddB.Location = new System.Drawing.Point(211, 3);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(63, 58);
            this.AddB.TabIndex = 0;
            this.AddB.Text = "+";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // FourB
            // 
            this.FourB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourB.Location = new System.Drawing.Point(3, 67);
            this.FourB.Name = "FourB";
            this.FourB.Size = new System.Drawing.Size(64, 58);
            this.FourB.TabIndex = 0;
            this.FourB.Text = "4";
            this.FourB.UseVisualStyleBackColor = true;
            this.FourB.Click += new System.EventHandler(this.FourB_Click);
            // 
            // FiveB
            // 
            this.FiveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveB.Location = new System.Drawing.Point(73, 67);
            this.FiveB.Name = "FiveB";
            this.FiveB.Size = new System.Drawing.Size(64, 58);
            this.FiveB.TabIndex = 0;
            this.FiveB.Text = "5";
            this.FiveB.UseVisualStyleBackColor = true;
            this.FiveB.Click += new System.EventHandler(this.FiveB_Click);
            // 
            // SixB
            // 
            this.SixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixB.Location = new System.Drawing.Point(143, 67);
            this.SixB.Name = "SixB";
            this.SixB.Size = new System.Drawing.Size(62, 58);
            this.SixB.TabIndex = 0;
            this.SixB.Text = "6";
            this.SixB.UseVisualStyleBackColor = true;
            this.SixB.Click += new System.EventHandler(this.SixB_Click);
            // 
            // SubB
            // 
            this.SubB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubB.Location = new System.Drawing.Point(211, 67);
            this.SubB.Name = "SubB";
            this.SubB.Size = new System.Drawing.Size(63, 58);
            this.SubB.TabIndex = 0;
            this.SubB.Text = "-";
            this.SubB.UseVisualStyleBackColor = true;
            this.SubB.Click += new System.EventHandler(this.SubB_Click);
            // 
            // SevenB
            // 
            this.SevenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenB.Location = new System.Drawing.Point(3, 131);
            this.SevenB.Name = "SevenB";
            this.SevenB.Size = new System.Drawing.Size(64, 58);
            this.SevenB.TabIndex = 0;
            this.SevenB.Text = "7";
            this.SevenB.UseVisualStyleBackColor = true;
            this.SevenB.Click += new System.EventHandler(this.SevenB_Click);
            // 
            // EightB
            // 
            this.EightB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightB.Location = new System.Drawing.Point(73, 131);
            this.EightB.Name = "EightB";
            this.EightB.Size = new System.Drawing.Size(64, 58);
            this.EightB.TabIndex = 0;
            this.EightB.Text = "8";
            this.EightB.UseVisualStyleBackColor = true;
            this.EightB.Click += new System.EventHandler(this.EightB_Click);
            // 
            // NineB
            // 
            this.NineB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineB.Location = new System.Drawing.Point(143, 131);
            this.NineB.Name = "NineB";
            this.NineB.Size = new System.Drawing.Size(62, 58);
            this.NineB.TabIndex = 0;
            this.NineB.Text = "9";
            this.NineB.UseVisualStyleBackColor = true;
            this.NineB.Click += new System.EventHandler(this.NineB_Click);
            // 
            // MultiplyB
            // 
            this.MultiplyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyB.Location = new System.Drawing.Point(211, 131);
            this.MultiplyB.Name = "MultiplyB";
            this.MultiplyB.Size = new System.Drawing.Size(63, 58);
            this.MultiplyB.TabIndex = 0;
            this.MultiplyB.Text = "x";
            this.MultiplyB.UseVisualStyleBackColor = true;
            this.MultiplyB.Click += new System.EventHandler(this.MultiplyB_Click);
            // 
            // ResetB
            // 
            this.ResetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetB.Location = new System.Drawing.Point(3, 195);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(64, 58);
            this.ResetB.TabIndex = 0;
            this.ResetB.Text = "C";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.ResetB_Click);
            // 
            // ZeroB
            // 
            this.ZeroB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroB.Location = new System.Drawing.Point(73, 195);
            this.ZeroB.Name = "ZeroB";
            this.ZeroB.Size = new System.Drawing.Size(64, 58);
            this.ZeroB.TabIndex = 0;
            this.ZeroB.Text = "0";
            this.ZeroB.UseVisualStyleBackColor = true;
            this.ZeroB.Click += new System.EventHandler(this.ZeroB_Click);
            // 
            // EqualsB
            // 
            this.EqualsB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EqualsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsB.Location = new System.Drawing.Point(143, 195);
            this.EqualsB.Name = "EqualsB";
            this.EqualsB.Size = new System.Drawing.Size(62, 58);
            this.EqualsB.TabIndex = 0;
            this.EqualsB.Text = "=";
            this.EqualsB.UseVisualStyleBackColor = false;
            this.EqualsB.Click += new System.EventHandler(this.EqualsB_Click);
            // 
            // DivideB
            // 
            this.DivideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideB.Location = new System.Drawing.Point(211, 195);
            this.DivideB.Name = "DivideB";
            this.DivideB.Size = new System.Drawing.Size(63, 58);
            this.DivideB.TabIndex = 0;
            this.DivideB.Text = "/";
            this.DivideB.UseVisualStyleBackColor = true;
            this.DivideB.Click += new System.EventHandler(this.DivideB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 371);
            this.Controls.Add(this.NumPadPanel);
            this.Controls.Add(this.InputPanel);
            this.MaximumSize = new System.Drawing.Size(320, 418);
            this.MinimumSize = new System.Drawing.Size(320, 418);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.NumPadPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.Label UserInputLabel;
        private System.Windows.Forms.FlowLayoutPanel NumPadPanel;
        private System.Windows.Forms.Button OneB;
        private System.Windows.Forms.Button TwoB;
        private System.Windows.Forms.Button ThreeB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button FourB;
        private System.Windows.Forms.Button FiveB;
        private System.Windows.Forms.Button SixB;
        private System.Windows.Forms.Button SubB;
        private System.Windows.Forms.Button SevenB;
        private System.Windows.Forms.Button EightB;
        private System.Windows.Forms.Button NineB;
        private System.Windows.Forms.Button MultiplyB;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.Button ZeroB;
        private System.Windows.Forms.Button EqualsB;
        private System.Windows.Forms.Button DivideB;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}

