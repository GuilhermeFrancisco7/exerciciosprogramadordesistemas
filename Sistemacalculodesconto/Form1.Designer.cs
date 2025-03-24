namespace calculodesconto
{
    partial class frmCalcularDesconto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPorcentagemSimbol = new Label();
            btnCalcular = new Button();
            lblValorDesconto = new Label();
            txtValorDesconto = new TextBox();
            txtValorCompra = new TextBox();
            lblCompraComDesconto = new Label();
            lblInserirDesconto = new Label();
            lblInserirValorCompra = new Label();
            lbltitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SpringGreen;
            panel1.Controls.Add(lblPorcentagemSimbol);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(lblValorDesconto);
            panel1.Controls.Add(txtValorDesconto);
            panel1.Controls.Add(txtValorCompra);
            panel1.Controls.Add(lblCompraComDesconto);
            panel1.Controls.Add(lblInserirDesconto);
            panel1.Controls.Add(lblInserirValorCompra);
            panel1.Controls.Add(lbltitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // lblPorcentagemSimbol
            // 
            lblPorcentagemSimbol.AutoSize = true;
            lblPorcentagemSimbol.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentagemSimbol.ForeColor = Color.Crimson;
            lblPorcentagemSimbol.Location = new Point(358, 199);
            lblPorcentagemSimbol.Name = "lblPorcentagemSimbol";
            lblPorcentagemSimbol.Size = new Size(31, 30);
            lblPorcentagemSimbol.TabIndex = 8;
            lblPorcentagemSimbol.Text = "%";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.SeaGreen;
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(506, 279);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 39);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.BackColor = Color.Aquamarine;
            lblValorDesconto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorDesconto.ForeColor = Color.Black;
            lblValorDesconto.Location = new Point(353, 289);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(19, 21);
            lblValorDesconto.TabIndex = 6;
            lblValorDesconto.Text = "0";
            // 
            // txtValorDesconto
            // 
            txtValorDesconto.BackColor = Color.GreenYellow;
            txtValorDesconto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorDesconto.Location = new Point(311, 204);
            txtValorDesconto.Name = "txtValorDesconto";
            txtValorDesconto.Size = new Size(43, 29);
            txtValorDesconto.TabIndex = 5;
            txtValorDesconto.Click += txtValorDesconto_Click;
            // 
            // txtValorCompra
            // 
            txtValorCompra.BackColor = Color.GreenYellow;
            txtValorCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorCompra.Location = new Point(311, 128);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(130, 29);
            txtValorCompra.TabIndex = 4;
            txtValorCompra.TextChanged += txtValorCompra_TextChanged;
            // 
            // lblCompraComDesconto
            // 
            lblCompraComDesconto.AutoSize = true;
            lblCompraComDesconto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompraComDesconto.ForeColor = Color.Black;
            lblCompraComDesconto.Location = new Point(94, 289);
            lblCompraComDesconto.Name = "lblCompraComDesconto";
            lblCompraComDesconto.Size = new Size(253, 21);
            lblCompraComDesconto.TabIndex = 3;
            lblCompraComDesconto.Text = "Preço da Compra com desconto :";
            // 
            // lblInserirDesconto
            // 
            lblInserirDesconto.AutoSize = true;
            lblInserirDesconto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInserirDesconto.ForeColor = Color.Crimson;
            lblInserirDesconto.Location = new Point(94, 206);
            lblInserirDesconto.Name = "lblInserirDesconto";
            lblInserirDesconto.Size = new Size(205, 21);
            lblInserirDesconto.TabIndex = 2;
            lblInserirDesconto.Text = "Insira o Valor do desconto:";
            // 
            // lblInserirValorCompra
            // 
            lblInserirValorCompra.AutoSize = true;
            lblInserirValorCompra.BackColor = Color.SpringGreen;
            lblInserirValorCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInserirValorCompra.ForeColor = Color.Crimson;
            lblInserirValorCompra.Location = new Point(94, 130);
            lblInserirValorCompra.Name = "lblInserirValorCompra";
            lblInserirValorCompra.Size = new Size(192, 21);
            lblInserirValorCompra.TabIndex = 1;
            lblInserirValorCompra.Text = "Insira o Valor da Compra:";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(218, 29);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(319, 30);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Sistema de Calculo de Desconto";
            // 
            // frmCalcularDesconto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmCalcularDesconto";
            Text = "Calcular Desconto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbltitulo;
        private Label lblCompraComDesconto;
        private Label lblInserirDesconto;
        private Label lblInserirValorCompra;
        private Label lblValorDesconto;
        private TextBox txtValorDesconto;
        private TextBox txtValorCompra;
        private Button btnCalcular;
        private Label lblPorcentagemSimbol;
    }
}
