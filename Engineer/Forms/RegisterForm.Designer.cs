namespace Engineer
{
    partial class RegisterForm
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
			this.Napis = new System.Windows.Forms.Label();
			this.TBR1 = new System.Windows.Forms.TextBox();
			this.TBR2 = new System.Windows.Forms.TextBox();
			this.Zaloguj = new System.Windows.Forms.Button();
			this.L2 = new System.Windows.Forms.Label();
			this.L3 = new System.Windows.Forms.Label();
			this.TBR3 = new System.Windows.Forms.TextBox();
			this.L4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Napis
			// 
			this.Napis.AutoSize = true;
			this.Napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Napis.Location = new System.Drawing.Point(199, 31);
			this.Napis.Name = "Napis";
			this.Napis.Size = new System.Drawing.Size(376, 76);
			this.Napis.TabIndex = 0;
			this.Napis.Text = "Rejestracja";
			// 
			// TBR1
			// 
			this.TBR1.Location = new System.Drawing.Point(335, 143);
			this.TBR1.Name = "TBR1";
			this.TBR1.Size = new System.Drawing.Size(100, 22);
			this.TBR1.TabIndex = 1;
			this.TBR1.TextChanged += new System.EventHandler(this.TBR1_TextChanged);
			// 
			// TBR2
			// 
			this.TBR2.Location = new System.Drawing.Point(335, 203);
			this.TBR2.Name = "TBR2";
			this.TBR2.Size = new System.Drawing.Size(100, 22);
			this.TBR2.TabIndex = 2;
			this.TBR2.TextChanged += new System.EventHandler(this.TBR2_TextChanged);
			// 
			// Zaloguj
			// 
			this.Zaloguj.Location = new System.Drawing.Point(327, 307);
			this.Zaloguj.Name = "Zaloguj";
			this.Zaloguj.Size = new System.Drawing.Size(117, 68);
			this.Zaloguj.TabIndex = 3;
			this.Zaloguj.Text = "Stwórz konto";
			this.Zaloguj.UseVisualStyleBackColor = true;
			this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
			// 
			// L2
			// 
			this.L2.AutoSize = true;
			this.L2.Location = new System.Drawing.Point(365, 124);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(40, 16);
			this.L2.TabIndex = 4;
			this.L2.Text = "Login";
			// 
			// L3
			// 
			this.L3.AutoSize = true;
			this.L3.Location = new System.Drawing.Point(362, 184);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(43, 16);
			this.L3.TabIndex = 5;
			this.L3.Text = "Haslo";
			// 
			// TBR3
			// 
			this.TBR3.Location = new System.Drawing.Point(335, 261);
			this.TBR3.Name = "TBR3";
			this.TBR3.Size = new System.Drawing.Size(100, 22);
			this.TBR3.TabIndex = 6;
			// 
			// L4
			// 
			this.L4.AutoSize = true;
			this.L4.Location = new System.Drawing.Point(342, 242);
			this.L4.Name = "L4";
			this.L4.Size = new System.Drawing.Size(93, 16);
			this.L4.TabIndex = 7;
			this.L4.Text = "Powtorz Haslo";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.L4);
			this.Controls.Add(this.TBR3);
			this.Controls.Add(this.L3);
			this.Controls.Add(this.L2);
			this.Controls.Add(this.Zaloguj);
			this.Controls.Add(this.TBR2);
			this.Controls.Add(this.TBR1);
			this.Controls.Add(this.Napis);
			this.Name = "RegisterForm";
			this.Text = "Rejestracja";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Napis;
        private System.Windows.Forms.TextBox TBR1;
        private System.Windows.Forms.TextBox TBR2;
        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.TextBox TBR3;
        private System.Windows.Forms.Label L4;
    }
}