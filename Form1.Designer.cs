namespace Calculate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelResault = new System.Windows.Forms.Panel();
            this.textResult = new System.Windows.Forms.TextBox();
            this.panelGridButton = new System.Windows.Forms.Panel();
            this.kpAnswer = new System.Windows.Forms.Button();
            this.kpDot = new System.Windows.Forms.Button();
            this.kp0 = new System.Windows.Forms.Button();
            this.kpChange = new System.Windows.Forms.Button();
            this.kpPlus = new System.Windows.Forms.Button();
            this.kp3 = new System.Windows.Forms.Button();
            this.kp2 = new System.Windows.Forms.Button();
            this.kp1 = new System.Windows.Forms.Button();
            this.kpMinus = new System.Windows.Forms.Button();
            this.kp6 = new System.Windows.Forms.Button();
            this.kp5 = new System.Windows.Forms.Button();
            this.kp4 = new System.Windows.Forms.Button();
            this.kpMultiply = new System.Windows.Forms.Button();
            this.kp9 = new System.Windows.Forms.Button();
            this.kp8 = new System.Windows.Forms.Button();
            this.kp7 = new System.Windows.Forms.Button();
            this.kpDivide = new System.Windows.Forms.Button();
            this.kpTg = new System.Windows.Forms.Button();
            this.kpCos = new System.Windows.Forms.Button();
            this.kpSin = new System.Windows.Forms.Button();
            this.kpBackSpace = new System.Windows.Forms.Button();
            this.kpC = new System.Windows.Forms.Button();
            this.kpCE = new System.Windows.Forms.Button();
            this.kpProcent = new System.Windows.Forms.Button();
            this.panelResault.SuspendLayout();
            this.panelGridButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResault
            // 
            this.panelResault.Controls.Add(this.textResult);
            this.panelResault.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResault.Location = new System.Drawing.Point(0, 0);
            this.panelResault.Name = "panelResault";
            this.panelResault.Size = new System.Drawing.Size(354, 100);
            this.panelResault.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textResult.Location = new System.Drawing.Point(0, 0);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(354, 100);
            this.textResult.TabIndex = 0;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelGridButton
            // 
            this.panelGridButton.Controls.Add(this.kpAnswer);
            this.panelGridButton.Controls.Add(this.kpDot);
            this.panelGridButton.Controls.Add(this.kp0);
            this.panelGridButton.Controls.Add(this.kpChange);
            this.panelGridButton.Controls.Add(this.kpPlus);
            this.panelGridButton.Controls.Add(this.kp3);
            this.panelGridButton.Controls.Add(this.kp2);
            this.panelGridButton.Controls.Add(this.kp1);
            this.panelGridButton.Controls.Add(this.kpMinus);
            this.panelGridButton.Controls.Add(this.kp6);
            this.panelGridButton.Controls.Add(this.kp5);
            this.panelGridButton.Controls.Add(this.kp4);
            this.panelGridButton.Controls.Add(this.kpMultiply);
            this.panelGridButton.Controls.Add(this.kp9);
            this.panelGridButton.Controls.Add(this.kp8);
            this.panelGridButton.Controls.Add(this.kp7);
            this.panelGridButton.Controls.Add(this.kpDivide);
            this.panelGridButton.Controls.Add(this.kpTg);
            this.panelGridButton.Controls.Add(this.kpCos);
            this.panelGridButton.Controls.Add(this.kpSin);
            this.panelGridButton.Controls.Add(this.kpBackSpace);
            this.panelGridButton.Controls.Add(this.kpC);
            this.panelGridButton.Controls.Add(this.kpCE);
            this.panelGridButton.Controls.Add(this.kpProcent);
            this.panelGridButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridButton.Location = new System.Drawing.Point(0, 100);
            this.panelGridButton.Name = "panelGridButton";
            this.panelGridButton.Size = new System.Drawing.Size(354, 521);
            this.panelGridButton.TabIndex = 1;
            // 
            // kpAnswer
            // 
            this.kpAnswer.Location = new System.Drawing.Point(260, 430);
            this.kpAnswer.Name = "kpAnswer";
            this.kpAnswer.Size = new System.Drawing.Size(85, 85);
            this.kpAnswer.TabIndex = 23;
            this.kpAnswer.Text = "=";
            this.kpAnswer.UseVisualStyleBackColor = true;
            this.kpAnswer.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpDot
            // 
            this.kpDot.Location = new System.Drawing.Point(175, 430);
            this.kpDot.Name = "kpDot";
            this.kpDot.Size = new System.Drawing.Size(85, 85);
            this.kpDot.TabIndex = 22;
            this.kpDot.Text = ".";
            this.kpDot.UseVisualStyleBackColor = true;
            this.kpDot.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp0
            // 
            this.kp0.Location = new System.Drawing.Point(90, 430);
            this.kp0.Name = "kp0";
            this.kp0.Size = new System.Drawing.Size(85, 85);
            this.kp0.TabIndex = 21;
            this.kp0.Text = "0";
            this.kp0.UseVisualStyleBackColor = true;
            this.kp0.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpChange
            // 
            this.kpChange.Location = new System.Drawing.Point(5, 430);
            this.kpChange.Name = "kpChange";
            this.kpChange.Size = new System.Drawing.Size(85, 85);
            this.kpChange.TabIndex = 20;
            this.kpChange.Text = "±";
            this.kpChange.UseVisualStyleBackColor = true;
            // 
            // kpPlus
            // 
            this.kpPlus.Location = new System.Drawing.Point(260, 345);
            this.kpPlus.Name = "kpPlus";
            this.kpPlus.Size = new System.Drawing.Size(85, 85);
            this.kpPlus.TabIndex = 19;
            this.kpPlus.Text = "+";
            this.kpPlus.UseVisualStyleBackColor = true;
            this.kpPlus.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp3
            // 
            this.kp3.Location = new System.Drawing.Point(175, 345);
            this.kp3.Name = "kp3";
            this.kp3.Size = new System.Drawing.Size(85, 85);
            this.kp3.TabIndex = 18;
            this.kp3.Text = "3";
            this.kp3.UseVisualStyleBackColor = true;
            this.kp3.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp2
            // 
            this.kp2.Location = new System.Drawing.Point(90, 345);
            this.kp2.Name = "kp2";
            this.kp2.Size = new System.Drawing.Size(85, 85);
            this.kp2.TabIndex = 17;
            this.kp2.Text = "2";
            this.kp2.UseVisualStyleBackColor = true;
            this.kp2.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp1
            // 
            this.kp1.Location = new System.Drawing.Point(5, 345);
            this.kp1.Name = "kp1";
            this.kp1.Size = new System.Drawing.Size(85, 85);
            this.kp1.TabIndex = 16;
            this.kp1.Text = "1";
            this.kp1.UseVisualStyleBackColor = true;
            this.kp1.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpMinus
            // 
            this.kpMinus.Location = new System.Drawing.Point(260, 260);
            this.kpMinus.Name = "kpMinus";
            this.kpMinus.Size = new System.Drawing.Size(85, 85);
            this.kpMinus.TabIndex = 15;
            this.kpMinus.Text = "-";
            this.kpMinus.UseVisualStyleBackColor = true;
            this.kpMinus.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp6
            // 
            this.kp6.Location = new System.Drawing.Point(175, 260);
            this.kp6.Name = "kp6";
            this.kp6.Size = new System.Drawing.Size(85, 85);
            this.kp6.TabIndex = 14;
            this.kp6.Text = "6";
            this.kp6.UseVisualStyleBackColor = true;
            this.kp6.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp5
            // 
            this.kp5.Location = new System.Drawing.Point(90, 260);
            this.kp5.Name = "kp5";
            this.kp5.Size = new System.Drawing.Size(85, 85);
            this.kp5.TabIndex = 13;
            this.kp5.Text = "5";
            this.kp5.UseVisualStyleBackColor = true;
            this.kp5.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp4
            // 
            this.kp4.Location = new System.Drawing.Point(5, 260);
            this.kp4.Name = "kp4";
            this.kp4.Size = new System.Drawing.Size(85, 85);
            this.kp4.TabIndex = 12;
            this.kp4.Text = "4";
            this.kp4.UseVisualStyleBackColor = true;
            this.kp4.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpMultiply
            // 
            this.kpMultiply.Location = new System.Drawing.Point(260, 175);
            this.kpMultiply.Name = "kpMultiply";
            this.kpMultiply.Size = new System.Drawing.Size(85, 85);
            this.kpMultiply.TabIndex = 11;
            this.kpMultiply.Text = "*";
            this.kpMultiply.UseVisualStyleBackColor = true;
            this.kpMultiply.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp9
            // 
            this.kp9.Location = new System.Drawing.Point(175, 175);
            this.kp9.Name = "kp9";
            this.kp9.Size = new System.Drawing.Size(85, 85);
            this.kp9.TabIndex = 10;
            this.kp9.Text = "9";
            this.kp9.UseVisualStyleBackColor = true;
            this.kp9.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp8
            // 
            this.kp8.Location = new System.Drawing.Point(90, 175);
            this.kp8.Name = "kp8";
            this.kp8.Size = new System.Drawing.Size(85, 85);
            this.kp8.TabIndex = 9;
            this.kp8.Text = "8";
            this.kp8.UseVisualStyleBackColor = true;
            this.kp8.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kp7
            // 
            this.kp7.Location = new System.Drawing.Point(5, 175);
            this.kp7.Name = "kp7";
            this.kp7.Size = new System.Drawing.Size(85, 85);
            this.kp7.TabIndex = 8;
            this.kp7.Text = "7";
            this.kp7.UseVisualStyleBackColor = true;
            this.kp7.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpDivide
            // 
            this.kpDivide.Location = new System.Drawing.Point(260, 90);
            this.kpDivide.Name = "kpDivide";
            this.kpDivide.Size = new System.Drawing.Size(85, 85);
            this.kpDivide.TabIndex = 7;
            this.kpDivide.Text = "/";
            this.kpDivide.UseVisualStyleBackColor = true;
            this.kpDivide.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // kpTg
            // 
            this.kpTg.Location = new System.Drawing.Point(175, 90);
            this.kpTg.Name = "kpTg";
            this.kpTg.Size = new System.Drawing.Size(85, 85);
            this.kpTg.TabIndex = 6;
            this.kpTg.Text = "tg(x)";
            this.kpTg.UseVisualStyleBackColor = true;
            // 
            // kpCos
            // 
            this.kpCos.Location = new System.Drawing.Point(90, 90);
            this.kpCos.Name = "kpCos";
            this.kpCos.Size = new System.Drawing.Size(85, 85);
            this.kpCos.TabIndex = 5;
            this.kpCos.Text = "cos(x)";
            this.kpCos.UseVisualStyleBackColor = true;
            // 
            // kpSin
            // 
            this.kpSin.Location = new System.Drawing.Point(5, 90);
            this.kpSin.Name = "kpSin";
            this.kpSin.Size = new System.Drawing.Size(85, 85);
            this.kpSin.TabIndex = 4;
            this.kpSin.Text = "sin(x)";
            this.kpSin.UseVisualStyleBackColor = true;
            // 
            // kpBackSpace
            // 
            this.kpBackSpace.Location = new System.Drawing.Point(260, 5);
            this.kpBackSpace.Name = "kpBackSpace";
            this.kpBackSpace.Size = new System.Drawing.Size(85, 85);
            this.kpBackSpace.TabIndex = 3;
            this.kpBackSpace.Text = "<-";
            this.kpBackSpace.UseVisualStyleBackColor = true;
            this.kpBackSpace.Click += new System.EventHandler(this.kpBackSpace_Click);
            // 
            // kpC
            // 
            this.kpC.Location = new System.Drawing.Point(175, 5);
            this.kpC.Name = "kpC";
            this.kpC.Size = new System.Drawing.Size(85, 85);
            this.kpC.TabIndex = 2;
            this.kpC.Text = "C";
            this.kpC.UseVisualStyleBackColor = true;
            this.kpC.Click += new System.EventHandler(this.kpC_Click);
            // 
            // kpCE
            // 
            this.kpCE.Location = new System.Drawing.Point(90, 5);
            this.kpCE.Name = "kpCE";
            this.kpCE.Size = new System.Drawing.Size(85, 85);
            this.kpCE.TabIndex = 1;
            this.kpCE.Text = "CE";
            this.kpCE.UseVisualStyleBackColor = true;
            this.kpCE.Click += new System.EventHandler(this.kpCE_Click);
            // 
            // kpProcent
            // 
            this.kpProcent.Location = new System.Drawing.Point(5, 5);
            this.kpProcent.Name = "kpProcent";
            this.kpProcent.Size = new System.Drawing.Size(85, 85);
            this.kpProcent.TabIndex = 0;
            this.kpProcent.Text = "%";
            this.kpProcent.UseVisualStyleBackColor = true;
            this.kpProcent.Click += new System.EventHandler(this.buttonBaseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 621);
            this.Controls.Add(this.panelGridButton);
            this.Controls.Add(this.panelResault);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 660);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 660);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мирошниченко Владимир | Калькулятор";
            this.panelResault.ResumeLayout(false);
            this.panelResault.PerformLayout();
            this.panelGridButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelResault;
        private TextBox textResult;
        private Panel panelGridButton;
        private Button kpAnswer;
        private Button kpDot;
        private Button kp0;
        private Button kpChange;
        private Button kpPlus;
        private Button kp3;
        private Button kp2;
        private Button kp1;
        private Button kpMinus;
        private Button kp6;
        private Button kp5;
        private Button kp4;
        private Button kpMultiply;
        private Button kp9;
        private Button kp8;
        private Button kp7;
        private Button kpDivide;
        private Button kpTg;
        private Button kpCos;
        private Button kpSin;
        private Button kpBackSpace;
        private Button kpC;
        private Button kpCE;
        private Button kpProcent;
    }
}