
namespace maioroumenor
{
    partial class frmValorMaiorOuMenor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDigiteUmValor = new System.Windows.Forms.TextBox();
            this.lblDigiteValor = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDigiteUmValor
            // 
            this.textDigiteUmValor.BackColor = System.Drawing.Color.PaleGreen;
            this.textDigiteUmValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDigiteUmValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDigiteUmValor.Location = new System.Drawing.Point(71, 72);
            this.textDigiteUmValor.Name = "textDigiteUmValor";
            this.textDigiteUmValor.Size = new System.Drawing.Size(196, 31);
            this.textDigiteUmValor.TabIndex = 0;
            // 
            // lblDigiteValor
            // 
            this.lblDigiteValor.AutoSize = true;
            this.lblDigiteValor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteValor.Location = new System.Drawing.Point(67, 48);
            this.lblDigiteValor.Name = "lblDigiteValor";
            this.lblDigiteValor.Size = new System.Drawing.Size(137, 21);
            this.lblDigiteValor.TabIndex = 1;
            this.lblDigiteValor.Text = "Digite um valor :";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(119, 144);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 30);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmValorMaiorOuMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 284);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblDigiteValor);
            this.Controls.Add(this.textDigiteUmValor);
            this.Name = "frmValorMaiorOuMenor";
            this.Text = "Valor Maior ou Menor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDigiteUmValor;
        private System.Windows.Forms.Label lblDigiteValor;
        private System.Windows.Forms.Button btnEnviar;
    }
}

