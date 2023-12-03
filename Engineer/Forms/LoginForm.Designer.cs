namespace Engineer
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Naglowek = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Haslo_TB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.LinkLabel();
            this.Rejestracjatext = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naglowek
            // 
            this.Naglowek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Naglowek.AutoSize = true;
            this.Naglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naglowek.Location = new System.Drawing.Point(264, 9);
            this.Naglowek.Name = "Naglowek";
            this.Naglowek.Size = new System.Drawing.Size(422, 91);
            this.Naglowek.TabIndex = 1;
            this.Naglowek.Text = "Logowanie";
            this.Naglowek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_TB
            // 
            this.Login_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_TB.Location = new System.Drawing.Point(327, 134);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(290, 22);
            this.Login_TB.TabIndex = 2;
            this.Login_TB.Text = "Login";
            this.Login_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login_TB.Click += new System.EventHandler(this.textBox1_Click);
            this.Login_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Haslo_TB
            // 
            this.Haslo_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Haslo_TB.Location = new System.Drawing.Point(327, 174);
            this.Haslo_TB.Name = "Haslo_TB";
            this.Haslo_TB.Size = new System.Drawing.Size(290, 22);
            this.Haslo_TB.TabIndex = 3;
            this.Haslo_TB.Text = "Haslo";
            this.Haslo_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Haslo_TB.Click += new System.EventHandler(this.textBox2_Click);
            this.Haslo_TB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(53, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj do bazy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rejestracja.AutoSize = true;
            this.Rejestracja.Location = new System.Drawing.Point(426, 224);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(91, 16);
            this.Rejestracja.TabIndex = 5;
            this.Rejestracja.TabStop = true;
            this.Rejestracja.Text = "Zarejestruj sie";
            this.Rejestracja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Rejestracja_LinkClicked);
            // 
            // Rejestracjatext
            // 
            this.Rejestracjatext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rejestracjatext.AutoSize = true;
            this.Rejestracjatext.Location = new System.Drawing.Point(419, 210);
            this.Rejestracjatext.Name = "Rejestracjatext";
            this.Rejestracjatext.Size = new System.Drawing.Size(109, 16);
            this.Rejestracjatext.TabIndex = 6;
            this.Rejestracjatext.Text = "Nie masz konta? ";
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Button.Location = new System.Drawing.Point(411, 263);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(128, 90);
            this.Login_Button.TabIndex = 7;
            this.Login_Button.Text = "Zaloguj";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(738, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dopasuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(738, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kwadraty";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 523);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Rejestracjatext);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Haslo_TB);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.Naglowek);
            this.MinimumSize = new System.Drawing.Size(975, 570);
            this.Name = "LoginForm";
            this.Text = "Glowny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Naglowek;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.TextBox Haslo_TB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel Rejestracja;
        private System.Windows.Forms.Label Rejestracjatext;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

