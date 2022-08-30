﻿namespace UI
{
    partial class ucsLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucsLogin));
            this.pnlLoginBack = new System.Windows.Forms.Panel();
            this.btnCadastroVoltar = new System.Windows.Forms.Button();
            this.ucsCadastro = new UI.ucsCadastro();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblEditarCadastro = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.txbLoginSenhaAntiga = new System.Windows.Forms.TextBox();
            this.lblSenhaAntiga = new System.Windows.Forms.Label();
            this.txbLoginNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlLoginBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginBack
            // 
            this.pnlLoginBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.pnlLoginBack.Controls.Add(this.btnCadastroVoltar);
            this.pnlLoginBack.Controls.Add(this.ucsCadastro);
            this.pnlLoginBack.Controls.Add(this.btnFechar);
            this.pnlLoginBack.Controls.Add(this.lblEditarCadastro);
            this.pnlLoginBack.Controls.Add(this.lblCadastrar);
            this.pnlLoginBack.Controls.Add(this.txbLoginSenhaAntiga);
            this.pnlLoginBack.Controls.Add(this.lblSenhaAntiga);
            this.pnlLoginBack.Controls.Add(this.txbLoginNome);
            this.pnlLoginBack.Controls.Add(this.lblUsuario);
            this.pnlLoginBack.Controls.Add(this.pnlLogin);
            this.pnlLoginBack.Controls.Add(this.btnNext);
            this.pnlLoginBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginBack.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginBack.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginBack.Name = "pnlLoginBack";
            this.pnlLoginBack.Size = new System.Drawing.Size(336, 344);
            this.pnlLoginBack.TabIndex = 0;
            // 
            // btnCadastroVoltar
            // 
            this.btnCadastroVoltar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCadastroVoltar.Location = new System.Drawing.Point(51, 301);
            this.btnCadastroVoltar.Name = "btnCadastroVoltar";
            this.btnCadastroVoltar.Size = new System.Drawing.Size(98, 23);
            this.btnCadastroVoltar.TabIndex = 14;
            this.btnCadastroVoltar.Text = "Voltar";
            this.btnCadastroVoltar.UseVisualStyleBackColor = true;
            this.btnCadastroVoltar.Visible = false;
            this.btnCadastroVoltar.Click += new System.EventHandler(this.btnCadastroVoltar_Click);
            // 
            // ucsCadastro
            // 
            this.ucsCadastro.Location = new System.Drawing.Point(23, 20);
            this.ucsCadastro.Name = "ucsCadastro";
            this.ucsCadastro.Size = new System.Drawing.Size(292, 321);
            this.ucsCadastro.TabIndex = 15;
            this.ucsCadastro.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(277, 20);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 32);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblEditarCadastro
            // 
            this.lblEditarCadastro.AutoSize = true;
            this.lblEditarCadastro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditarCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarCadastro.Location = new System.Drawing.Point(30, 294);
            this.lblEditarCadastro.Name = "lblEditarCadastro";
            this.lblEditarCadastro.Size = new System.Drawing.Size(51, 17);
            this.lblEditarCadastro.TabIndex = 4;
            this.lblEditarCadastro.Text = "Usuário";
            this.lblEditarCadastro.MouseEnter += new System.EventHandler(this.lblEditarCadastro_MouseEnter);
            this.lblEditarCadastro.MouseLeave += new System.EventHandler(this.lblEditarCadastro_MouseLeave);
            this.lblEditarCadastro.MouseHover += new System.EventHandler(this.lblEditarCadastro_MouseHover);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastrar.Location = new System.Drawing.Point(30, 278);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(51, 17);
            this.lblCadastrar.TabIndex = 3;
            this.lblCadastrar.Text = "Usuário";
            this.lblCadastrar.Click += new System.EventHandler(this.lblCadastrar_Click);
            this.lblCadastrar.MouseEnter += new System.EventHandler(this.lblCadastrar_MouseEnter);
            this.lblCadastrar.MouseLeave += new System.EventHandler(this.lblCadastrar_MouseLeave);
            this.lblCadastrar.MouseHover += new System.EventHandler(this.lblCadastrar_MouseHover);
            // 
            // txbLoginSenhaAntiga
            // 
            this.txbLoginSenhaAntiga.Location = new System.Drawing.Point(30, 254);
            this.txbLoginSenhaAntiga.Name = "txbLoginSenhaAntiga";
            this.txbLoginSenhaAntiga.Size = new System.Drawing.Size(278, 23);
            this.txbLoginSenhaAntiga.TabIndex = 2;
            this.txbLoginSenhaAntiga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbLoginSenhaAntiga_KeyUp);
            // 
            // lblSenhaAntiga
            // 
            this.lblSenhaAntiga.AutoSize = true;
            this.lblSenhaAntiga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenhaAntiga.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenhaAntiga.Location = new System.Drawing.Point(30, 230);
            this.lblSenhaAntiga.Name = "lblSenhaAntiga";
            this.lblSenhaAntiga.Size = new System.Drawing.Size(66, 21);
            this.lblSenhaAntiga.TabIndex = 3;
            this.lblSenhaAntiga.Text = "Usuário";
            // 
            // txbLoginNome
            // 
            this.txbLoginNome.Location = new System.Drawing.Point(28, 187);
            this.txbLoginNome.Name = "txbLoginNome";
            this.txbLoginNome.Size = new System.Drawing.Size(278, 23);
            this.txbLoginNome.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(28, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Location = new System.Drawing.Point(109, 46);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(100, 100);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(268, 277);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // ucsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLoginBack);
            this.Name = "ucsLogin";
            this.Size = new System.Drawing.Size(336, 344);
            this.pnlLoginBack.ResumeLayout(false);
            this.pnlLoginBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLoginBack;
        private Panel pnlLogin;
        public Label lblEditarCadastro;
        public Label lblCadastrar;
        public Label lblSenhaAntiga;
        public Label lblUsuario;
        public Button btnNext;
        public TextBox txbLoginSenhaAntiga;
        public TextBox txbLoginNome;
        public Button btnFechar;
        private Button btnCadastroVoltar;
        public ucsCadastro ucsCadastro;
    }
}
