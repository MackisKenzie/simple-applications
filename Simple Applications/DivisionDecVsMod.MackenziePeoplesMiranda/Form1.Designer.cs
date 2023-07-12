namespace DivisionDecVsMod.MackenziePeoplesMiranda
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DividendTextbox = new System.Windows.Forms.TextBox();
            this.DevisorTextbox = new System.Windows.Forms.TextBox();
            this.QuoTextbox = new System.Windows.Forms.TextBox();
            this.RemainderTextbox = new System.Windows.Forms.TextBox();
            this.AnswerDecTextbox = new System.Windows.Forms.TextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(51, 94);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(189, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DividendTextbox
            // 
            this.DividendTextbox.Location = new System.Drawing.Point(30, 28);
            this.DividendTextbox.Name = "DividendTextbox";
            this.DividendTextbox.Size = new System.Drawing.Size(72, 20);
            this.DividendTextbox.TabIndex = 1;
            this.DividendTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DevisorTextbox
            // 
            this.DevisorTextbox.Location = new System.Drawing.Point(187, 28);
            this.DevisorTextbox.Name = "DevisorTextbox";
            this.DevisorTextbox.Size = new System.Drawing.Size(71, 20);
            this.DevisorTextbox.TabIndex = 2;
            this.DevisorTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuoTextbox
            // 
            this.QuoTextbox.Location = new System.Drawing.Point(70, 172);
            this.QuoTextbox.Name = "QuoTextbox";
            this.QuoTextbox.ReadOnly = true;
            this.QuoTextbox.Size = new System.Drawing.Size(63, 20);
            this.QuoTextbox.TabIndex = 3;
            this.QuoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemainderTextbox
            // 
            this.RemainderTextbox.Location = new System.Drawing.Point(244, 175);
            this.RemainderTextbox.Name = "RemainderTextbox";
            this.RemainderTextbox.ReadOnly = true;
            this.RemainderTextbox.Size = new System.Drawing.Size(53, 20);
            this.RemainderTextbox.TabIndex = 4;
            this.RemainderTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnswerDecTextbox
            // 
            this.AnswerDecTextbox.Location = new System.Drawing.Point(111, 250);
            this.AnswerDecTextbox.Name = "AnswerDecTextbox";
            this.AnswerDecTextbox.ReadOnly = true;
            this.AnswerDecTextbox.Size = new System.Drawing.Size(100, 20);
            this.AnswerDecTextbox.TabIndex = 5;
            this.AnswerDecTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(12, 310);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(294, 46);
            this.ClearAllButton.TabIndex = 6;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dividend:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Divisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Divided by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Answer Via Interger Division (Mod)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remainder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quotient:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Answer Via Decimal Division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 368);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.AnswerDecTextbox);
            this.Controls.Add(this.RemainderTextbox);
            this.Controls.Add(this.QuoTextbox);
            this.Controls.Add(this.DevisorTextbox);
            this.Controls.Add(this.DividendTextbox);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "DivisionDecVsMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox DividendTextbox;
        private System.Windows.Forms.TextBox DevisorTextbox;
        private System.Windows.Forms.TextBox QuoTextbox;
        private System.Windows.Forms.TextBox RemainderTextbox;
        private System.Windows.Forms.TextBox AnswerDecTextbox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

