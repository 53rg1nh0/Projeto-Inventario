namespace UI
{
    partial class Adminstrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrador));
            this.pnlAdminstrador = new System.Windows.Forms.Panel();
            this.lblAdminstradorInformacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbAdminstrador = new System.Windows.Forms.PictureBox();
            this.pnlAdminstrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdminstrador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminstrador
            // 
            this.pnlAdminstrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.pnlAdminstrador.Controls.Add(this.lblAdminstradorInformacao);
            this.pnlAdminstrador.Controls.Add(this.pictureBox1);
            this.pnlAdminstrador.Controls.Add(this.ptbAdminstrador);
            this.pnlAdminstrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminstrador.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminstrador.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdminstrador.Name = "pnlAdminstrador";
            this.pnlAdminstrador.Size = new System.Drawing.Size(870, 82);
            this.pnlAdminstrador.TabIndex = 0;
            // 
            // lblAdminstradorInformacao
            // 
            this.lblAdminstradorInformacao.AutoSize = true;
            this.lblAdminstradorInformacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminstradorInformacao.Location = new System.Drawing.Point(84, 9);
            this.lblAdminstradorInformacao.Name = "lblAdminstradorInformacao";
            this.lblAdminstradorInformacao.Size = new System.Drawing.Size(253, 65);
            this.lblAdminstradorInformacao.TabIndex = 2;
            this.lblAdminstradorInformacao.Text = "Responável: Sérgio Agostinho Fernandes Sousa\r\nCargo: Assistente de Tecnologia da " +
    "Informação\r\nMatrícula: 66003298\r\nTelefone: (85) 3266-6562\r\nUnidade: TISC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(675, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ptbAdminstrador
            // 
            this.ptbAdminstrador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbAdminstrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbAdminstrador.BackgroundImage")));
            this.ptbAdminstrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAdminstrador.Location = new System.Drawing.Point(10, 10);
            this.ptbAdminstrador.Margin = new System.Windows.Forms.Padding(10);
            this.ptbAdminstrador.Name = "ptbAdminstrador";
            this.ptbAdminstrador.Size = new System.Drawing.Size(70, 62);
            this.ptbAdminstrador.TabIndex = 0;
            this.ptbAdminstrador.TabStop = false;
            // 
            // Adminstrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdminstrador);
            this.Name = "Adminstrador";
            this.Size = new System.Drawing.Size(870, 82);
            this.pnlAdminstrador.ResumeLayout(false);
            this.pnlAdminstrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdminstrador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAdminstrador;
        private PictureBox ptbAdminstrador;
        private PictureBox pictureBox1;
        private Label lblAdminstradorInformacao;
    }
}
