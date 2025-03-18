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
            string texto = textDigiteUmValor.Text;
            bool sucess = int.TryParse(texto, out int numero);

            if (sucess)
            {
                if (numero > 10)
                {
                    MessageBox.Show($"O Número {numero} é Maior que 10!");
                }

                else if (numero < 10)
                {
                    MessageBox.Show($"O Número {numero} é Menor que 10!");
                }

                else
                {
                    MessageBox.Show($" O número digitado é igual a 10!");
                }

            }
            else
            {
                MessageBox.Show("Você digitou Letras! ",
                    "digite somente Números!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

    }
}