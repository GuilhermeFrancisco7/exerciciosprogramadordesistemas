namespace calculodesconto
{
    public partial class frmCalcularDesconto : Form
    {
        float valorCompra, desconto, precoFinal;

        public frmCalcularDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valorCompra = float.Parse(txtValorCompra.Text); // Var valorCompra recebe o que for digitado no campo valor da compra incial

            desconto = float.Parse(txtValorDesconto.Text) / 100; // Var descontoAplicado recebe valor de desconto

            precoFinal = valorCompra - (valorCompra * desconto);

            lblValorDesconto.Text = precoFinal.ToString("C2");
        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtValorCompra.Text, out valorCompra) || float.Parse(txtValorCompra.Text) < 0)
            {
                MessageBox.Show("Insira um valor valído! \n Não Inserir letras ou Valor negativo!", "Valor invalido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void txtValorDesconto_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtValorDesconto.Text, out desconto) || float.Parse(txtValorCompra.Text) < 0)
            {
                MessageBox.Show("Insira um valor valído! \n Não Inserir letras ou Valor negativo!", "Valor invalido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
