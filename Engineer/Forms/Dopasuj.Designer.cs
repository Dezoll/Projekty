using System;

namespace Engineer.Forms
{
    partial class Dopasuj
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
            this.RedX = new System.Windows.Forms.NumericUpDown();
            this.RedY = new System.Windows.Forms.NumericUpDown();
            this.BlueX = new System.Windows.Forms.NumericUpDown();
            this.BlueY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueY)).BeginInit();
            this.SuspendLayout();
            // 
            // RedX
            // 
            this.RedX.Location = new System.Drawing.Point(658, 27);
            this.RedX.Name = "RedX";
            this.RedX.Size = new System.Drawing.Size(120, 22);
            this.RedX.TabIndex = 0;
            this.RedX.ValueChanged += new System.EventHandler(this.RedX_ValueChanged);
            // 
            // RedY
            // 
            this.RedY.Location = new System.Drawing.Point(658, 55);
            this.RedY.Name = "RedY";
            this.RedY.Size = new System.Drawing.Size(120, 22);
            this.RedY.TabIndex = 1;
            // 
            // BlueX
            // 
            this.BlueX.Location = new System.Drawing.Point(658, 191);
            this.BlueX.Name = "BlueX";
            this.BlueX.Size = new System.Drawing.Size(120, 22);
            this.BlueX.TabIndex = 2;
            // 
            // BlueY
            // 
            this.BlueY.Location = new System.Drawing.Point(658, 219);
            this.BlueY.Name = "BlueY";
            this.BlueY.Size = new System.Drawing.Size(120, 22);
            this.BlueY.TabIndex = 3;
            this.BlueY.ValueChanged += new System.EventHandler(this.BlueY_ValueChanged);
            // 
            // Dopasuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BlueY);
            this.Controls.Add(this.BlueX);
            this.Controls.Add(this.RedY);
            this.Controls.Add(this.RedX);
            this.Name = "Dopasuj";
            this.Text = "Dopasuj";
            this.Load += new System.EventHandler(this.Dopasuj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueY)).EndInit();
            this.ResumeLayout(false);

        }

        private void BlueY_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RedX_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown RedX;
        private System.Windows.Forms.NumericUpDown RedY;
        private System.Windows.Forms.NumericUpDown BlueX;
        private System.Windows.Forms.NumericUpDown BlueY;
    }
}