using System;
using System.Drawing;
using System.Windows.Forms;

namespace Engineer
{
    public partial class Kwadraty : Form
    {
        private Panel niebieskiPanel;
        private Label czerwonyKwadrat;
        private Label niebieskiKwadrat;
        private TextBox szerokoscTextBox;
        private TextBox wysokoscTextBox;

        public Kwadraty()
        {
            InitializujComponent();
            InicjalizujUI();
        }
        private void Kwadraty_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void InitializujComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Text = "Kwadraty";

            this.ResumeLayout(false);
        }

        private void InicjalizujUI()
        {
            niebieskiPanel = new Panel
            {
                BackColor = Color.Blue,
                Width = 300,
                Height = 300,
                Location = new Point(50, 50)
            };

            czerwonyKwadrat = new Label
            {
                BackColor = Color.Red,
                Width = 50,
                Height = 50,
                Location = new Point(niebieskiPanel.Width / 2 - 25, niebieskiPanel.Height / 2 - 25)
            };

            niebieskiKwadrat = new Label
            {
                BackColor = Color.Blue,
                Width = 50,
                Height = 50,
                Location = new Point(10, 10),
                Visible = false
            };

            szerokoscTextBox = new TextBox
            {
                Location = new Point(10, 350),
                Size = new Size(50, 20),
                Text = czerwonyKwadrat.Width.ToString()
            };

            wysokoscTextBox = new TextBox
            {
                Location = new Point(70, 350),
                Size = new Size(50, 20),
                Text = czerwonyKwadrat.Height.ToString()
            };

            niebieskiPanel.Controls.Add(niebieskiKwadrat);
            niebieskiPanel.Controls.Add(czerwonyKwadrat);
            Controls.Add(niebieskiPanel);
            Controls.Add(szerokoscTextBox);
            Controls.Add(wysokoscTextBox);

            czerwonyKwadrat.MouseDown += CzerwonyKwadrat_MouseDown;
            czerwonyKwadrat.MouseMove += CzerwonyKwadrat_MouseMove;
            czerwonyKwadrat.MouseUp += CzerwonyKwadrat_MouseUp;

            szerokoscTextBox.TextChanged += TextBox_TextChanged;
            wysokoscTextBox.TextChanged += TextBox_TextChanged;
        }

        private bool isDragging = false;
        private Point offset;

        private void CzerwonyKwadrat_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location;
        }

        private void CzerwonyKwadrat_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                czerwonyKwadrat.Left = Math.Max(0, Math.Min(niebieskiPanel.Width - czerwonyKwadrat.Width, e.X + czerwonyKwadrat.Left - offset.X));
                czerwonyKwadrat.Top = Math.Max(0, Math.Min(niebieskiPanel.Height - czerwonyKwadrat.Height, e.Y + czerwonyKwadrat.Top - offset.Y));
            }
        }

        private void CzerwonyKwadrat_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int szerokosc, wysokosc;

            if (int.TryParse(szerokoscTextBox.Text, out szerokosc) && int.TryParse(wysokoscTextBox.Text, out wysokosc))
            {
                czerwonyKwadrat.Width = szerokosc;
                czerwonyKwadrat.Height = wysokosc;
            }
        }
    }
}
