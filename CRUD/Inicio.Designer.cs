namespace CRUD
{
    partial class Inicio
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
            this.btEvento = new System.Windows.Forms.Button();
            this.btInstituicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEvento
            // 
            this.btEvento.Location = new System.Drawing.Point(50, 40);
            this.btEvento.Name = "btEvento";
            this.btEvento.Size = new System.Drawing.Size(344, 77);
            this.btEvento.TabIndex = 0;
            this.btEvento.Text = "Evento";
            this.btEvento.UseVisualStyleBackColor = true;
            this.btEvento.Click += new System.EventHandler(this.btEvento_Click);
            // 
            // btInstituicao
            // 
            this.btInstituicao.Location = new System.Drawing.Point(50, 159);
            this.btInstituicao.Name = "btInstituicao";
            this.btInstituicao.Size = new System.Drawing.Size(344, 77);
            this.btInstituicao.TabIndex = 1;
            this.btInstituicao.Text = "Instituição";
            this.btInstituicao.UseVisualStyleBackColor = true;
            this.btInstituicao.Click += new System.EventHandler(this.btInstituicao_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 278);
            this.Controls.Add(this.btInstituicao);
            this.Controls.Add(this.btEvento);
            this.Name = "Inicio";
            this.Text = "Início";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEvento;
        private System.Windows.Forms.Button btInstituicao;
    }
}

