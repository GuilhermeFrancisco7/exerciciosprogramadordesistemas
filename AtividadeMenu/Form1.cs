using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel p = new Panel();

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(250, 193, 0);
            p.Size = new Size(132,5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(p);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            panelExtendido.Visible = !panelExtendido.Visible;
            if (panelExtendido.Visible)
            {
               
                panel5.Visible = false;
                panelExtendidoConsultar.Visible = false;
                panelImpressao.Visible = false;
            } // para tornar o menutelas invisivel quando estiver no panelExtendido;


           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;

            if (panel5.Visible)
            {
                panelExtendido.Visible = false;
                panelExtendidoConsultar.Visible = false;
                panelImpressao.Visible = false;
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            panelExtendidoConsultar.Visible = !panelExtendidoConsultar.Visible;

            if (panelExtendidoConsultar.Visible)
            {
                panelExtendido.Visible = false;
                panel5.Visible = false;
                panelImpressao.Visible = false;
            }
        }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            panelImpressao.Visible = !panelImpressao.Visible;

            if (panelImpressao.Visible)
            {
                panelExtendido.Visible = false;
                panel5.Visible = false;
                panelExtendidoConsultar.Visible = false;
            }
        }
    }
    
}
