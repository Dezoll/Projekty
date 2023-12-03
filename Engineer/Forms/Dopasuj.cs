using System;
using System.Drawing;
using System.Windows.Forms;

namespace Engineer.Forms
{
    public partial class Dopasuj : Form
    {
        private Panel redPanel;
        private Panel bluePanel;
        private TextBox redTextBox;
        private TextBox blueTextBox;
        private NumericUpDown redXNumericUpDown;
        private NumericUpDown redYNumericUpDown;
        private NumericUpDown blueXNumericUpDown;
        private NumericUpDown blueYNumericUpDown;
        private Point mouseDownLocation;

       
        public Dopasuj()
        {
            InitializeComponent();
            InitializePanels();
            InitializeTextBoxes();
        }

        private void Dopasuj_Load(object sender, EventArgs e)
        {
            // Kod związany z zdarzeniem Load, jeśli jest taki, możesz go umieścić tutaj
        }

        private void InitializePanels()
        {
            redPanel = new Panel
            {
                BackColor = Color.Red,
                Location = new Point(50, 50),
                BorderStyle = BorderStyle.FixedSingle
            };

            bluePanel = new Panel
            {
                BackColor = Color.Blue,
                Location = new Point(50, 50),
                BorderStyle = BorderStyle.FixedSingle
            };

            redPanel.MouseDown += Panel_MouseDown;
            redPanel.MouseMove += RedPanel_MouseMove;
            bluePanel.MouseDown += Panel_MouseDown;
            bluePanel.MouseMove += Panel_MouseMove;

            Controls.Add(redPanel);
            Controls.Add(bluePanel);

            // Aktualizacja rozmiaru panelu na podstawie wartości z NumericUpDown
            UpdatePanelSize(redPanel, (int)RedX.Value, (int)RedY.Value);
            UpdatePanelSize(bluePanel, (int)BlueX.Value, (int)BlueY.Value);
        }

        private void InitializeTextBoxes()
        {
            redTextBox = new TextBox
            {
                Location = new Point(50, 170),
                Size = new Size(100, 20),
                TextAlign = HorizontalAlignment.Center
            };

            blueTextBox = new TextBox
            {
                Location = new Point(200, 170),
                Size = new Size(100, 20),
                TextAlign = HorizontalAlignment.Center
            };

            redXNumericUpDown = new NumericUpDown
            {
                Location = new Point(50, 200),
                Size = new Size(50, 20),
                TextAlign = HorizontalAlignment.Center,
                Minimum = 1,
                Maximum = 1000
            };

            redYNumericUpDown = new NumericUpDown
            {
                Location = new Point(150, 200),
                Size = new Size(50, 20),
                TextAlign = HorizontalAlignment.Center,
                Minimum = 1,
                Maximum = 1000
            };

            blueXNumericUpDown = new NumericUpDown
            {
                Location = new Point(200, 200),
                Size = new Size(50, 20),
                TextAlign = HorizontalAlignment.Center,
                Minimum = 1,
                Maximum = 1000
            };

            blueYNumericUpDown = new NumericUpDown
            {
                Location = new Point(300, 200),
                Size = new Size(50, 20),
                TextAlign = HorizontalAlignment.Center,
                Minimum = 1,
                Maximum = 1000
            };

            redTextBox.TextChanged += RedTextBox_TextChanged;
            blueTextBox.TextChanged += BlueTextBox_TextChanged;
            redXNumericUpDown.ValueChanged += RedNumericUpDown_ValueChanged;
            redYNumericUpDown.ValueChanged += RedNumericUpDown_ValueChanged;
            blueXNumericUpDown.ValueChanged += BlueNumericUpDown_ValueChanged;
            blueYNumericUpDown.ValueChanged += BlueNumericUpDown_ValueChanged;

            Controls.Add(redTextBox);
            Controls.Add(blueTextBox);
            Controls.Add(redXNumericUpDown);
            Controls.Add(redYNumericUpDown);
            Controls.Add(blueXNumericUpDown);
            Controls.Add(blueYNumericUpDown);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void RedPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel panel = sender as Panel;
                int newX = panel.Left + e.X - mouseDownLocation.X;
                int newY = panel.Top + e.Y - mouseDownLocation.Y;

                // Sprawdzenie czy nowa pozycja czerwonego panelu przecina się z niebieskim panelu
                Rectangle intersection = Rectangle.Intersect(new Rectangle(newX, newY, panel.Width, panel.Height), bluePanel.ClientRectangle);
                if (intersection == new Rectangle(newX, newY, panel.Width, panel.Height))
                {
                    // Ustawienie pozycji na granicach niebieskiego panelu, aby nie przekraczał ram z lewej i góry
                    panel.Left = Math.Max(bluePanel.Left, newX);
                    panel.Top = Math.Max(bluePanel.Top, newY);
                    UpdateTextBox(panel);
                }
                else
                {
                    // Ustawienie pozycji na granicach niebieskiego panelu, aby nie przekraczał ram
                    panel.Left = Math.Max(Math.Min(newX, bluePanel.Right - panel.Width), bluePanel.Left);
                    panel.Top = Math.Max(Math.Min(newY, bluePanel.Bottom - panel.Height), bluePanel.Top);
                }
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel panel = sender as Panel;
                int newX = panel.Left + e.X - mouseDownLocation.X;
                int newY = panel.Top + e.Y - mouseDownLocation.Y;

                // Sprawdzenie czy nowa pozycja panelu przecina się z granicami niebieskiego panelu
                if (newX < bluePanel.Left)
                {
                    newX = bluePanel.Left;
                }
                else if (newX + panel.Width > bluePanel.Right)
                {
                    newX = bluePanel.Right - panel.Width;
                }

                if (newY < bluePanel.Top)
                {
                    newY = bluePanel.Top;
                }
                else if (newY + panel.Height > bluePanel.Bottom)
                {
                    newY = bluePanel.Bottom - panel.Height;
                }

                panel.Left = newX;
                panel.Top = newY;

                UpdateTextBox(panel);
            }
        }

        private void UpdateTextBox(Panel panel)
        {
            if (panel == redPanel)
            {
                redTextBox.Text = $"{redPanel.Width} x {redPanel.Height}";
            }
            else if (panel == bluePanel)
            {
                blueTextBox.Text = $"{bluePanel.Width} x {bluePanel.Height}";
            }
        }

        private void RedTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePanelSize(redPanel, (int)RedX.Value, (int)RedY.Value);
        }

        private void BlueTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePanelSize(bluePanel, (int)BlueX.Value, (int)BlueY.Value);
        }

        private void RedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelSize(redPanel, (int)redXNumericUpDown.Value, (int)redYNumericUpDown.Value);
        }

        private void BlueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelSize(bluePanel, (int)blueXNumericUpDown.Value, (int)blueYNumericUpDown.Value);
        }

        private void UpdatePanelSize(Panel panel, int width, int height)
        {
            panel.Size = new Size(width, height);
        }
    }
}
