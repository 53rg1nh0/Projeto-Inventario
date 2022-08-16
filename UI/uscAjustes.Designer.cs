namespace UI
{
    partial class Ajustes
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAjustes = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInformacao = new System.Windows.Forms.TableLayoutPanel();
            this.gpbConfiguracao = new System.Windows.Forms.GroupBox();
            this.gpbModelo = new System.Windows.Forms.GroupBox();
            this.uscCrudUnidades = new UI.uscCrudUnidades();
            this.gpbDocumentacao = new System.Windows.Forms.GroupBox();
            this.uscCrudResponsaveis1 = new UI.uscCrudResponsaveis();
            this.tlpAjustes.SuspendLayout();
            this.tlpInformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAjustes
            // 
            this.tlpAjustes.ColumnCount = 1;
            this.tlpAjustes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAjustes.Controls.Add(this.tlpInformacao, 0, 2);
            this.tlpAjustes.Controls.Add(this.gpbDocumentacao, 0, 0);
            this.tlpAjustes.Controls.Add(this.uscCrudResponsaveis1, 0, 1);
            this.tlpAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAjustes.Location = new System.Drawing.Point(0, 0);
            this.tlpAjustes.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAjustes.Name = "tlpAjustes";
            this.tlpAjustes.RowCount = 3;
            this.tlpAjustes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAjustes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAjustes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAjustes.Size = new System.Drawing.Size(948, 455);
            this.tlpAjustes.TabIndex = 0;
            // 
            // tlpInformacao
            // 
            this.tlpInformacao.ColumnCount = 3;
            this.tlpInformacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInformacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInformacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInformacao.Controls.Add(this.gpbConfiguracao, 2, 0);
            this.tlpInformacao.Controls.Add(this.gpbModelo, 1, 0);
            this.tlpInformacao.Controls.Add(this.uscCrudUnidades, 0, 0);
            this.tlpInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInformacao.Location = new System.Drawing.Point(0, 277);
            this.tlpInformacao.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInformacao.Name = "tlpInformacao";
            this.tlpInformacao.Padding = new System.Windows.Forms.Padding(10);
            this.tlpInformacao.RowCount = 1;
            this.tlpInformacao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInformacao.Size = new System.Drawing.Size(948, 178);
            this.tlpInformacao.TabIndex = 0;
            // 
            // gpbConfiguracao
            // 
            this.gpbConfiguracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbConfiguracao.Location = new System.Drawing.Point(716, 13);
            this.gpbConfiguracao.Margin = new System.Windows.Forms.Padding(10, 3, 5, 10);
            this.gpbConfiguracao.Name = "gpbConfiguracao";
            this.gpbConfiguracao.Padding = new System.Windows.Forms.Padding(0);
            this.gpbConfiguracao.Size = new System.Drawing.Size(217, 145);
            this.gpbConfiguracao.TabIndex = 2;
            this.gpbConfiguracao.TabStop = false;
            this.gpbConfiguracao.Text = "Configuração Existentes de Equipamentos";
            // 
            // gpbModelo
            // 
            this.gpbModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpbModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbModelo.Location = new System.Drawing.Point(484, 13);
            this.gpbModelo.Margin = new System.Windows.Forms.Padding(10, 3, 5, 10);
            this.gpbModelo.Name = "gpbModelo";
            this.gpbModelo.Padding = new System.Windows.Forms.Padding(0);
            this.gpbModelo.Size = new System.Drawing.Size(217, 145);
            this.gpbModelo.TabIndex = 1;
            this.gpbModelo.TabStop = false;
            this.gpbModelo.Text = "Modelos de Equipamentos Existentes";
            // 
            // uscCrudUnidades
            // 
            this.uscCrudUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCrudUnidades.Location = new System.Drawing.Point(10, 10);
            this.uscCrudUnidades.Margin = new System.Windows.Forms.Padding(0);
            this.uscCrudUnidades.Name = "uscCrudUnidades";
            this.uscCrudUnidades.Size = new System.Drawing.Size(464, 158);
            this.uscCrudUnidades.TabIndex = 3;
            // 
            // gpbDocumentacao
            // 
            this.gpbDocumentacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDocumentacao.Location = new System.Drawing.Point(10, 3);
            this.gpbDocumentacao.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.gpbDocumentacao.Name = "gpbDocumentacao";
            this.gpbDocumentacao.Size = new System.Drawing.Size(928, 94);
            this.gpbDocumentacao.TabIndex = 2;
            this.gpbDocumentacao.TabStop = false;
            this.gpbDocumentacao.Text = "Termos/Relatórios";
            // 
            // uscCrudResponsaveis1
            // 
            this.uscCrudResponsaveis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCrudResponsaveis1.Location = new System.Drawing.Point(10, 110);
            this.uscCrudResponsaveis1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.uscCrudResponsaveis1.Name = "uscCrudResponsaveis1";
            this.uscCrudResponsaveis1.Size = new System.Drawing.Size(928, 167);
            this.uscCrudResponsaveis1.TabIndex = 3;
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAjustes);
            this.Name = "Ajustes";
            this.Size = new System.Drawing.Size(948, 455);
            this.tlpAjustes.ResumeLayout(false);
            this.tlpInformacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpAjustes;
        private TableLayoutPanel tlpInformacao;
        private GroupBox gpbDocumentacao;
        private GroupBox gpbConfiguracao;
        private GroupBox gpbModelo;
        public uscCrudUnidades uscCrudUnidades;
        private uscCrudResponsaveis uscCrudResponsaveis1;
    }
}
