namespace UI
{
    partial class ucsCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucsCadastro));
            this.pnlCadastroBack = new System.Windows.Forms.Panel();
            this.pnlCadastroButton = new System.Windows.Forms.Panel();
            this.btnCadastroVoltar = new System.Windows.Forms.Button();
            this.btnCadastroCadastrar = new System.Windows.Forms.Button();
            this.pnlCadastroTop = new System.Windows.Forms.Panel();
            this.lblCadastroTitulo = new System.Windows.Forms.Label();
            this.pnlCadastroFigura = new System.Windows.Forms.Panel();
            this.pnlCadastroCentral = new System.Windows.Forms.Panel();
            this.txbCadastroUsuario = new System.Windows.Forms.TextBox();
            this.lblCadastroEmail = new System.Windows.Forms.Label();
            this.txbCadastroEmail = new System.Windows.Forms.TextBox();
            this.lblCadastroMatricula = new System.Windows.Forms.Label();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.txbCadastroMtricula = new System.Windows.Forms.TextBox();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.lblCadastroSenhaTemp = new System.Windows.Forms.Label();
            this.txbCadastroConfirmar = new System.Windows.Forms.TextBox();
            this.txbCadastroSenhaTemp = new System.Windows.Forms.TextBox();
            this.lblCadastrarSenha = new System.Windows.Forms.Label();
            this.lblCadastroExcluir = new System.Windows.Forms.Label();
            this.lblCadastroConfirmar = new System.Windows.Forms.Label();
            this.lblCadastroIncluir = new System.Windows.Forms.Label();
            this.txbCadastroTelCorp = new System.Windows.Forms.TextBox();
            this.cbxCadastroExcluir = new System.Windows.Forms.ComboBox();
            this.txbCadastroTelPess = new System.Windows.Forms.TextBox();
            this.cbxCadastroIncluir = new System.Windows.Forms.ComboBox();
            this.lblCadastroTelCorp = new System.Windows.Forms.Label();
            this.lblCadastroUnidades = new System.Windows.Forms.Label();
            this.lblCadastroTelPess = new System.Windows.Forms.Label();
            this.txbCadastroUnidades = new System.Windows.Forms.TextBox();
            this.pnlCadastroBack.SuspendLayout();
            this.pnlCadastroButton.SuspendLayout();
            this.pnlCadastroTop.SuspendLayout();
            this.pnlCadastroCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroBack
            // 
            this.pnlCadastroBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.pnlCadastroBack.Controls.Add(this.pnlCadastroButton);
            this.pnlCadastroBack.Controls.Add(this.pnlCadastroTop);
            this.pnlCadastroBack.Controls.Add(this.pnlCadastroCentral);
            this.pnlCadastroBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroBack.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroBack.Name = "pnlCadastroBack";
            this.pnlCadastroBack.Size = new System.Drawing.Size(292, 771);
            this.pnlCadastroBack.TabIndex = 0;
            // 
            // pnlCadastroButton
            // 
            this.pnlCadastroButton.Controls.Add(this.btnCadastroVoltar);
            this.pnlCadastroButton.Controls.Add(this.btnCadastroCadastrar);
            this.pnlCadastroButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCadastroButton.Location = new System.Drawing.Point(0, 704);
            this.pnlCadastroButton.Name = "pnlCadastroButton";
            this.pnlCadastroButton.Size = new System.Drawing.Size(292, 67);
            this.pnlCadastroButton.TabIndex = 31;
            // 
            // btnCadastroVoltar
            // 
            this.btnCadastroVoltar.Location = new System.Drawing.Point(20, 25);
            this.btnCadastroVoltar.Name = "btnCadastroVoltar";
            this.btnCadastroVoltar.Size = new System.Drawing.Size(93, 23);
            this.btnCadastroVoltar.TabIndex = 3;
            this.btnCadastroVoltar.Tag = "12";
            this.btnCadastroVoltar.Text = "Voltar";
            this.btnCadastroVoltar.UseVisualStyleBackColor = true;
            this.btnCadastroVoltar.Click += new System.EventHandler(this.btnCadastroVoltar_Click);
            // 
            // btnCadastroCadastrar
            // 
            this.btnCadastroCadastrar.Location = new System.Drawing.Point(191, 25);
            this.btnCadastroCadastrar.Name = "btnCadastroCadastrar";
            this.btnCadastroCadastrar.Size = new System.Drawing.Size(93, 23);
            this.btnCadastroCadastrar.TabIndex = 4;
            this.btnCadastroCadastrar.Tag = "14";
            this.btnCadastroCadastrar.Text = "Prosseguir";
            this.btnCadastroCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastroCadastrar.Click += new System.EventHandler(this.btnCadastroCadastrar_Click);
            // 
            // pnlCadastroTop
            // 
            this.pnlCadastroTop.Controls.Add(this.lblCadastroTitulo);
            this.pnlCadastroTop.Controls.Add(this.pnlCadastroFigura);
            this.pnlCadastroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadastroTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroTop.Name = "pnlCadastroTop";
            this.pnlCadastroTop.Size = new System.Drawing.Size(292, 131);
            this.pnlCadastroTop.TabIndex = 30;
            // 
            // lblCadastroTitulo
            // 
            this.lblCadastroTitulo.AutoSize = true;
            this.lblCadastroTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCadastroTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCadastroTitulo.Location = new System.Drawing.Point(0, 106);
            this.lblCadastroTitulo.Name = "lblCadastroTitulo";
            this.lblCadastroTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblCadastroTitulo.TabIndex = 1;
            this.lblCadastroTitulo.Text = "                 Autenticação";
            this.lblCadastroTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCadastroFigura
            // 
            this.pnlCadastroFigura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCadastroFigura.BackgroundImage")));
            this.pnlCadastroFigura.Location = new System.Drawing.Point(93, 9);
            this.pnlCadastroFigura.Name = "pnlCadastroFigura";
            this.pnlCadastroFigura.Size = new System.Drawing.Size(100, 100);
            this.pnlCadastroFigura.TabIndex = 0;
            // 
            // pnlCadastroCentral
            // 
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroUsuario);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroEmail);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroEmail);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroMatricula);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroUsuario);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroMtricula);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroSenha);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroSenhaTemp);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroConfirmar);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroSenhaTemp);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastrarSenha);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroExcluir);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroConfirmar);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroIncluir);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroTelCorp);
            this.pnlCadastroCentral.Controls.Add(this.cbxCadastroExcluir);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroTelPess);
            this.pnlCadastroCentral.Controls.Add(this.cbxCadastroIncluir);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroTelCorp);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroUnidades);
            this.pnlCadastroCentral.Controls.Add(this.lblCadastroTelPess);
            this.pnlCadastroCentral.Controls.Add(this.txbCadastroUnidades);
            this.pnlCadastroCentral.Location = new System.Drawing.Point(29, 130);
            this.pnlCadastroCentral.Name = "pnlCadastroCentral";
            this.pnlCadastroCentral.Size = new System.Drawing.Size(239, 566);
            this.pnlCadastroCentral.TabIndex = 32;
            // 
            // txbCadastroUsuario
            // 
            this.txbCadastroUsuario.Location = new System.Drawing.Point(3, 27);
            this.txbCadastroUsuario.Name = "txbCadastroUsuario";
            this.txbCadastroUsuario.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroUsuario.TabIndex = 1;
            this.txbCadastroUsuario.Tag = "1";
            // 
            // lblCadastroEmail
            // 
            this.lblCadastroEmail.AutoSize = true;
            this.lblCadastroEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroEmail.Location = new System.Drawing.Point(3, 57);
            this.lblCadastroEmail.Name = "lblCadastroEmail";
            this.lblCadastroEmail.Size = new System.Drawing.Size(41, 15);
            this.lblCadastroEmail.TabIndex = 1;
            this.lblCadastroEmail.Text = "E-mail";
            // 
            // txbCadastroEmail
            // 
            this.txbCadastroEmail.Location = new System.Drawing.Point(3, 76);
            this.txbCadastroEmail.Name = "txbCadastroEmail";
            this.txbCadastroEmail.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroEmail.TabIndex = 2;
            this.txbCadastroEmail.Tag = "2";
            // 
            // lblCadastroMatricula
            // 
            this.lblCadastroMatricula.AutoSize = true;
            this.lblCadastroMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroMatricula.Location = new System.Drawing.Point(3, 296);
            this.lblCadastroMatricula.Name = "lblCadastroMatricula";
            this.lblCadastroMatricula.Size = new System.Drawing.Size(57, 15);
            this.lblCadastroMatricula.TabIndex = 29;
            this.lblCadastroMatricula.Text = "Matrícula";
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(3, 9);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblCadastroUsuario.TabIndex = 3;
            this.lblCadastroUsuario.Text = "Usuário";
            // 
            // txbCadastroMtricula
            // 
            this.txbCadastroMtricula.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroMtricula.Location = new System.Drawing.Point(3, 314);
            this.txbCadastroMtricula.Name = "txbCadastroMtricula";
            this.txbCadastroMtricula.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroMtricula.TabIndex = 8;
            this.txbCadastroMtricula.Tag = "6";
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroSenha.Location = new System.Drawing.Point(3, 212);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroSenha.TabIndex = 6;
            this.txbCadastroSenha.Tag = "4";
            // 
            // lblCadastroSenhaTemp
            // 
            this.lblCadastroSenhaTemp.AutoSize = true;
            this.lblCadastroSenhaTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroSenhaTemp.Location = new System.Drawing.Point(3, 146);
            this.lblCadastroSenhaTemp.Name = "lblCadastroSenhaTemp";
            this.lblCadastroSenhaTemp.Size = new System.Drawing.Size(101, 15);
            this.lblCadastroSenhaTemp.TabIndex = 26;
            this.lblCadastroSenhaTemp.Text = "Senha Temporária";
            // 
            // txbCadastroConfirmar
            // 
            this.txbCadastroConfirmar.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroConfirmar.Location = new System.Drawing.Point(3, 261);
            this.txbCadastroConfirmar.Name = "txbCadastroConfirmar";
            this.txbCadastroConfirmar.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroConfirmar.TabIndex = 7;
            this.txbCadastroConfirmar.Tag = "5";
            // 
            // txbCadastroSenhaTemp
            // 
            this.txbCadastroSenhaTemp.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroSenhaTemp.Location = new System.Drawing.Point(3, 163);
            this.txbCadastroSenhaTemp.Name = "txbCadastroSenhaTemp";
            this.txbCadastroSenhaTemp.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroSenhaTemp.TabIndex = 5;
            this.txbCadastroSenhaTemp.Tag = "3";
            // 
            // lblCadastrarSenha
            // 
            this.lblCadastrarSenha.AutoSize = true;
            this.lblCadastrarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastrarSenha.Location = new System.Drawing.Point(3, 195);
            this.lblCadastrarSenha.Name = "lblCadastrarSenha";
            this.lblCadastrarSenha.Size = new System.Drawing.Size(70, 15);
            this.lblCadastrarSenha.TabIndex = 7;
            this.lblCadastrarSenha.Text = "Nova Senha";
            // 
            // lblCadastroExcluir
            // 
            this.lblCadastroExcluir.AutoSize = true;
            this.lblCadastroExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroExcluir.Location = new System.Drawing.Point(171, 504);
            this.lblCadastroExcluir.Name = "lblCadastroExcluir";
            this.lblCadastroExcluir.Size = new System.Drawing.Size(42, 15);
            this.lblCadastroExcluir.TabIndex = 20;
            this.lblCadastroExcluir.Text = "Excluir";
            // 
            // lblCadastroConfirmar
            // 
            this.lblCadastroConfirmar.AutoSize = true;
            this.lblCadastroConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroConfirmar.Location = new System.Drawing.Point(3, 243);
            this.lblCadastroConfirmar.Name = "lblCadastroConfirmar";
            this.lblCadastroConfirmar.Size = new System.Drawing.Size(96, 15);
            this.lblCadastroConfirmar.TabIndex = 8;
            this.lblCadastroConfirmar.Text = "Confirmar Senha";
            // 
            // lblCadastroIncluir
            // 
            this.lblCadastroIncluir.AutoSize = true;
            this.lblCadastroIncluir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroIncluir.Location = new System.Drawing.Point(3, 504);
            this.lblCadastroIncluir.Name = "lblCadastroIncluir";
            this.lblCadastroIncluir.Size = new System.Drawing.Size(40, 15);
            this.lblCadastroIncluir.TabIndex = 19;
            this.lblCadastroIncluir.Text = "Incluir";
            // 
            // txbCadastroTelCorp
            // 
            this.txbCadastroTelCorp.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroTelCorp.Location = new System.Drawing.Point(3, 359);
            this.txbCadastroTelCorp.Name = "txbCadastroTelCorp";
            this.txbCadastroTelCorp.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroTelCorp.TabIndex = 9;
            this.txbCadastroTelCorp.Tag = "7";
            // 
            // cbxCadastroExcluir
            // 
            this.cbxCadastroExcluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxCadastroExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCadastroExcluir.FormattingEnabled = true;
            this.cbxCadastroExcluir.Location = new System.Drawing.Point(171, 521);
            this.cbxCadastroExcluir.Name = "cbxCadastroExcluir";
            this.cbxCadastroExcluir.Size = new System.Drawing.Size(65, 23);
            this.cbxCadastroExcluir.TabIndex = 13;
            this.cbxCadastroExcluir.Tag = "11";
            // 
            // txbCadastroTelPess
            // 
            this.txbCadastroTelPess.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroTelPess.Location = new System.Drawing.Point(3, 406);
            this.txbCadastroTelPess.Name = "txbCadastroTelPess";
            this.txbCadastroTelPess.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroTelPess.TabIndex = 10;
            this.txbCadastroTelPess.Tag = "8";
            // 
            // cbxCadastroIncluir
            // 
            this.cbxCadastroIncluir.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.cbxCadastroIncluir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxCadastroIncluir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxCadastroIncluir.CausesValidation = false;
            this.cbxCadastroIncluir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCadastroIncluir.FormattingEnabled = true;
            this.cbxCadastroIncluir.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbxCadastroIncluir.IntegralHeight = false;
            this.cbxCadastroIncluir.ItemHeight = 15;
            this.cbxCadastroIncluir.Location = new System.Drawing.Point(3, 521);
            this.cbxCadastroIncluir.MaxDropDownItems = 10;
            this.cbxCadastroIncluir.Name = "cbxCadastroIncluir";
            this.cbxCadastroIncluir.Size = new System.Drawing.Size(65, 23);
            this.cbxCadastroIncluir.TabIndex = 12;
            this.cbxCadastroIncluir.Tag = "10";
            // 
            // lblCadastroTelCorp
            // 
            this.lblCadastroTelCorp.AutoSize = true;
            this.lblCadastroTelCorp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroTelCorp.Location = new System.Drawing.Point(3, 342);
            this.lblCadastroTelCorp.Name = "lblCadastroTelCorp";
            this.lblCadastroTelCorp.Size = new System.Drawing.Size(117, 15);
            this.lblCadastroTelCorp.TabIndex = 11;
            this.lblCadastroTelCorp.Text = "Telefone Corporativo";
            // 
            // lblCadastroUnidades
            // 
            this.lblCadastroUnidades.AutoSize = true;
            this.lblCadastroUnidades.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroUnidades.Location = new System.Drawing.Point(3, 455);
            this.lblCadastroUnidades.Name = "lblCadastroUnidades";
            this.lblCadastroUnidades.Size = new System.Drawing.Size(56, 15);
            this.lblCadastroUnidades.TabIndex = 16;
            this.lblCadastroUnidades.Text = "Unidades";
            // 
            // lblCadastroTelPess
            // 
            this.lblCadastroTelPess.AutoSize = true;
            this.lblCadastroTelPess.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCadastroTelPess.Location = new System.Drawing.Point(3, 388);
            this.lblCadastroTelPess.Name = "lblCadastroTelPess";
            this.lblCadastroTelPess.Size = new System.Drawing.Size(93, 15);
            this.lblCadastroTelPess.TabIndex = 12;
            this.lblCadastroTelPess.Text = "Telefone Pessoal";
            // 
            // txbCadastroUnidades
            // 
            this.txbCadastroUnidades.BackColor = System.Drawing.SystemColors.Window;
            this.txbCadastroUnidades.Location = new System.Drawing.Point(3, 472);
            this.txbCadastroUnidades.Name = "txbCadastroUnidades";
            this.txbCadastroUnidades.Size = new System.Drawing.Size(233, 23);
            this.txbCadastroUnidades.TabIndex = 11;
            this.txbCadastroUnidades.Tag = "9";
            // 
            // ucsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCadastroBack);
            this.Name = "ucsCadastro";
            this.Size = new System.Drawing.Size(292, 771);
            this.pnlCadastroBack.ResumeLayout(false);
            this.pnlCadastroButton.ResumeLayout(false);
            this.pnlCadastroTop.ResumeLayout(false);
            this.pnlCadastroTop.PerformLayout();
            this.pnlCadastroCentral.ResumeLayout(false);
            this.pnlCadastroCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCadastroBack;
        private Panel pnlCadastroFigura;
        private Label lblCadastroEmail;
        private Button btnCadastroVoltar;
        private Button btnCadastroCadastrar;
        private Label lblCadastroExcluir;
        private Label lblCadastroIncluir;
        private Label lblCadastroUnidades;
        private TextBox txbCadastroUnidades;
        private Label lblCadastroTelPess;
        private Label lblCadastroTelCorp;
        private TextBox txbCadastroTelPess;
        private TextBox txbCadastroTelCorp;
        private Label lblCadastroConfirmar;
        private Label lblCadastrarSenha;
        private TextBox txbCadastroConfirmar;
        private TextBox txbCadastroSenha;
        private TextBox txbCadastroUsuario;
        private Label lblCadastroUsuario;
        private TextBox txbCadastroEmail;
        public ComboBox cbxCadastroExcluir;
        public ComboBox cbxCadastroIncluir;
        private Label lblCadastroSenhaTemp;
        private TextBox txbCadastroSenhaTemp;
        private Label lblCadastroMatricula;
        private TextBox txbCadastroMtricula;
        private Panel pnlCadastroButton;
        private Panel pnlCadastroTop;
        private Panel pnlCadastroCentral;
        private Label lblCadastroTitulo;
    }
}
