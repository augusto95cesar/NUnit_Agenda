namespace Agenda.Aplication
{
    partial class Form1
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
            this.lblContatoNovo = new System.Windows.Forms.Label();
            this.textContatoNovo = new System.Windows.Forms.TextBox();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.textContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContatoNovo
            // 
            this.lblContatoNovo.AutoSize = true;
            this.lblContatoNovo.Location = new System.Drawing.Point(49, 30);
            this.lblContatoNovo.Name = "lblContatoNovo";
            this.lblContatoNovo.Size = new System.Drawing.Size(71, 13);
            this.lblContatoNovo.TabIndex = 0;
            this.lblContatoNovo.Text = "Contato novo";
            // 
            // textContatoNovo
            // 
            this.textContatoNovo.Location = new System.Drawing.Point(52, 57);
            this.textContatoNovo.Name = "textContatoNovo";
            this.textContatoNovo.Size = new System.Drawing.Size(335, 20);
            this.textContatoNovo.TabIndex = 1;
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.Location = new System.Drawing.Point(49, 91);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(72, 13);
            this.lblContatoSalvo.TabIndex = 2;
            this.lblContatoSalvo.Text = "Contato salvo";
            // 
            // textContatoSalvo
            // 
            this.textContatoSalvo.Location = new System.Drawing.Point(52, 117);
            this.textContatoSalvo.Name = "textContatoSalvo";
            this.textContatoSalvo.Size = new System.Drawing.Size(335, 20);
            this.textContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(312, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textContatoSalvo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.textContatoNovo);
            this.Controls.Add(this.lblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatoNovo;
        private System.Windows.Forms.TextBox textContatoNovo;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox textContatoSalvo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

