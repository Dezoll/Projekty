namespace Engineer
{
    partial class Dodaj
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
            this.NazwaTB = new System.Windows.Forms.TextBox();
            this.CenaTB = new System.Windows.Forms.TextBox();
            this.NazwaL = new System.Windows.Forms.Label();
            this.CenaL = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RodzajTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KolorTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaTB
            // 
            this.NazwaTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazwaTB.Location = new System.Drawing.Point(390, 152);
            this.NazwaTB.Name = "NazwaTB";
            this.NazwaTB.Size = new System.Drawing.Size(406, 22);
            this.NazwaTB.TabIndex = 0;
            this.NazwaTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CenaTB
            // 
            this.CenaTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CenaTB.Location = new System.Drawing.Point(390, 203);
            this.CenaTB.Name = "CenaTB";
            this.CenaTB.Size = new System.Drawing.Size(406, 22);
            this.CenaTB.TabIndex = 1;
            this.CenaTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NazwaL
            // 
            this.NazwaL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NazwaL.AutoSize = true;
            this.NazwaL.Location = new System.Drawing.Point(560, 133);
            this.NazwaL.Name = "NazwaL";
            this.NazwaL.Size = new System.Drawing.Size(48, 16);
            this.NazwaL.TabIndex = 2;
            this.NazwaL.Text = "Nazwa";
            // 
            // CenaL
            // 
            this.CenaL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CenaL.AutoSize = true;
            this.CenaL.Location = new System.Drawing.Point(566, 184);
            this.CenaL.Name = "CenaL";
            this.CenaL.Size = new System.Drawing.Size(39, 16);
            this.CenaL.TabIndex = 3;
            this.CenaL.Text = "Cena";
            this.CenaL.Click += new System.EventHandler(this.CenaL_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.Location = new System.Drawing.Point(351, 440);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(496, 207);
            this.Add.TabIndex = 4;
            this.Add.Text = "dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rodzaj";
            // 
            // RodzajTB
            // 
            this.RodzajTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RodzajTB.Location = new System.Drawing.Point(390, 256);
            this.RodzajTB.Name = "RodzajTB";
            this.RodzajTB.Size = new System.Drawing.Size(406, 22);
            this.RodzajTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolor";
            // 
            // KolorTB
            // 
            this.KolorTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KolorTB.Location = new System.Drawing.Point(390, 311);
            this.KolorTB.Name = "KolorTB";
            this.KolorTB.Size = new System.Drawing.Size(406, 22);
            this.KolorTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(90, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 111);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(297, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 111);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ustawienia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(502, 681);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 111);
            this.button3.TabIndex = 11;
            this.button3.Text = "Wyszukaj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(717, 681);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 111);
            this.button4.TabIndex = 12;
            this.button4.Text = "Baza";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(925, 681);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 111);
            this.button5.TabIndex = 13;
            this.button5.Text = "Kolory|Zadania";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(68, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 111);
            this.button6.TabIndex = 14;
            this.button6.Text = "dodaj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KolorTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RodzajTB);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CenaL);
            this.Controls.Add(this.NazwaL);
            this.Controls.Add(this.CenaTB);
            this.Controls.Add(this.NazwaTB);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Dodaj";
            this.Text = "Dodaj";
            this.Load += new System.EventHandler(this.Dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaTB;
        private System.Windows.Forms.TextBox CenaTB;
        private System.Windows.Forms.Label NazwaL;
        private System.Windows.Forms.Label CenaL;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RodzajTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KolorTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}