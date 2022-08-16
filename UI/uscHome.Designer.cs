namespace UI
{
    partial class Home
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
            this.tlpHome = new System.Windows.Forms.TableLayoutPanel();
            this.adminstrador1 = new UI.Adminstrador();
            this.tlpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHome
            // 
            this.tlpHome.ColumnCount = 1;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.Controls.Add(this.adminstrador1, 0, 0);
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHome.Location = new System.Drawing.Point(0, 0);
            this.tlpHome.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 3;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHome.Size = new System.Drawing.Size(1005, 467);
            this.tlpHome.TabIndex = 0;
            // 
            // adminstrador1
            // 
            this.adminstrador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminstrador1.Location = new System.Drawing.Point(0, 0);
            this.adminstrador1.Margin = new System.Windows.Forms.Padding(0);
            this.adminstrador1.Name = "adminstrador1";
            this.adminstrador1.Size = new System.Drawing.Size(1005, 80);
            this.adminstrador1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpHome);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1005, 467);
            this.tlpHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpHome;
        private Adminstrador adminstrador1;
    }
}
