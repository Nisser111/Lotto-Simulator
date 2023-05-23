namespace Lotto_simulation
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
            this.WelcomeTextLabel = new System.Windows.Forms.Label();
            this.RuleLabel = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.SecoundNum = new System.Windows.Forms.TextBox();
            this.ThirdNum = new System.Windows.Forms.TextBox();
            this.FourthNum = new System.Windows.Forms.TextBox();
            this.FivethNum = new System.Windows.Forms.TextBox();
            this.SixthNum = new System.Windows.Forms.TextBox();
            this.YourNumbersLabel = new System.Windows.Forms.Label();
            this.JoinGameBtn = new System.Windows.Forms.Button();
            this.RandomNumBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeTextLabel
            // 
            this.WelcomeTextLabel.AutoSize = true;
            this.WelcomeTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeTextLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeTextLabel.Location = new System.Drawing.Point(163, 51);
            this.WelcomeTextLabel.Name = "WelcomeTextLabel";
            this.WelcomeTextLabel.Size = new System.Drawing.Size(470, 32);
            this.WelcomeTextLabel.TabIndex = 0;
            this.WelcomeTextLabel.Text = "WITAJ W SYMULATORZE LOTERII LOTTO\r\n";
            this.WelcomeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeTextLabel.Click += new System.EventHandler(this.WelcomeTextLabel_Click);
            // 
            // RuleLabel
            // 
            this.RuleLabel.Location = new System.Drawing.Point(177, 83);
            this.RuleLabel.Name = "RuleLabel";
            this.RuleLabel.Size = new System.Drawing.Size(441, 39);
            this.RuleLabel.TabIndex = 1;
            this.RuleLabel.Text = "Wpisz sześć cyfr z zakresu od 1 do 49 lub wybierz opcje chybił trafił zostaną one" +
    " wtedy dla ciebie wylosowane. Pamiętaj, że liczby nie mogą się powtarzać.\r\n";
            this.RuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RuleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNum
            // 
            this.FirstNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNum.Location = new System.Drawing.Point(251, 215);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(31, 33);
            this.FirstNum.TabIndex = 1;
            this.FirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecoundNum
            // 
            this.SecoundNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecoundNum.Location = new System.Drawing.Point(303, 215);
            this.SecoundNum.Name = "SecoundNum";
            this.SecoundNum.Size = new System.Drawing.Size(31, 33);
            this.SecoundNum.TabIndex = 2;
            this.SecoundNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThirdNum
            // 
            this.ThirdNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdNum.Location = new System.Drawing.Point(354, 215);
            this.ThirdNum.Name = "ThirdNum";
            this.ThirdNum.Size = new System.Drawing.Size(31, 33);
            this.ThirdNum.TabIndex = 3;
            this.ThirdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FourthNum
            // 
            this.FourthNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourthNum.Location = new System.Drawing.Point(407, 215);
            this.FourthNum.Name = "FourthNum";
            this.FourthNum.Size = new System.Drawing.Size(31, 33);
            this.FourthNum.TabIndex = 4;
            this.FourthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FivethNum
            // 
            this.FivethNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FivethNum.Location = new System.Drawing.Point(460, 215);
            this.FivethNum.Name = "FivethNum";
            this.FivethNum.Size = new System.Drawing.Size(31, 33);
            this.FivethNum.TabIndex = 5;
            this.FivethNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SixthNum
            // 
            this.SixthNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixthNum.Location = new System.Drawing.Point(511, 215);
            this.SixthNum.Name = "SixthNum";
            this.SixthNum.Size = new System.Drawing.Size(31, 33);
            this.SixthNum.TabIndex = 6;
            this.SixthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YourNumbersLabel
            // 
            this.YourNumbersLabel.AutoSize = true;
            this.YourNumbersLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourNumbersLabel.Location = new System.Drawing.Point(337, 179);
            this.YourNumbersLabel.Name = "YourNumbersLabel";
            this.YourNumbersLabel.Size = new System.Drawing.Size(119, 25);
            this.YourNumbersLabel.TabIndex = 8;
            this.YourNumbersLabel.Text = "Twoje liczby";
            // 
            // JoinGameBtn
            // 
            this.JoinGameBtn.Location = new System.Drawing.Point(346, 276);
            this.JoinGameBtn.Name = "JoinGameBtn";
            this.JoinGameBtn.Size = new System.Drawing.Size(100, 23);
            this.JoinGameBtn.TabIndex = 8;
            this.JoinGameBtn.Text = "Wejdź do gry";
            this.JoinGameBtn.UseVisualStyleBackColor = true;
            this.JoinGameBtn.Click += new System.EventHandler(this.JoinGameBtn_Click);
            // 
            // RandomNumBtn
            // 
            this.RandomNumBtn.Location = new System.Drawing.Point(234, 276);
            this.RandomNumBtn.Name = "RandomNumBtn";
            this.RandomNumBtn.Size = new System.Drawing.Size(100, 23);
            this.RandomNumBtn.TabIndex = 7;
            this.RandomNumBtn.Text = "Chybił trafił";
            this.RandomNumBtn.UseVisualStyleBackColor = true;
            this.RandomNumBtn.Click += new System.EventHandler(this.RandomNumBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(458, 276);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Wyczyść";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(257, 254);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(279, 15);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Click += new System.EventHandler(this.ErrorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RandomNumBtn);
            this.Controls.Add(this.JoinGameBtn);
            this.Controls.Add(this.YourNumbersLabel);
            this.Controls.Add(this.SixthNum);
            this.Controls.Add(this.FivethNum);
            this.Controls.Add(this.FourthNum);
            this.Controls.Add(this.ThirdNum);
            this.Controls.Add(this.SecoundNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.RuleLabel);
            this.Controls.Add(this.WelcomeTextLabel);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WelcomeTextLabel;
        private Label RuleLabel;
        private TextBox FirstNum;
        private TextBox SecoundNum;
        private TextBox ThirdNum;
        private TextBox FourthNum;
        private TextBox FivethNum;
        private TextBox SixthNum;
        private Label YourNumbersLabel;
        private Button JoinGameBtn;
        private Button RandomNumBtn;
        private Button ClearBtn;
        private Label ErrorLabel;
    }
}