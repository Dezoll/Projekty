using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineer.Forms
{
    public partial class Rozdzielczosc_cfg : Form
    {
        public Rozdzielczosc_cfg()
        {
           
            InitializeComponent();
            this.Load += Rozdzielczosc_cfg_Load;
        }

        private void Rozdzielczosc_cfg_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
