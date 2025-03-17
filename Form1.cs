using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenor
{
    public partial class frmValorMaiorOuMenor : Form
    {
        public frmValorMaiorOuMenor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textDigiteUmValor.Text);

            if(valor == 10)
            {
                MessageBox.Show("Valor Igual a 10!",
                                 "Verificando"
                                 );
            }
            else if (valor > 10)
            {
                MessageBox.Show("Valor maior que 10!",
                                 "Verificando"
                                 );
            }
            else
            {
                MessageBox.Show("Valor menor que 10!",
                                    "Verificando"
                                    );

            }
        }
    }
}
