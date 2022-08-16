namespace UI
{
    partial class uscCrudUnidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscCrudUnidades));
            this.tlpCrudUnidade = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAlterarUnidade = new System.Windows.Forms.DataGridView();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Regiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCrudImputs = new System.Windows.Forms.TableLayoutPanel();
            this.txbRegiao = new System.Windows.Forms.TextBox();
            this.txbUf = new System.Windows.Forms.TextBox();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.txbCrudSigla = new System.Windows.Forms.TextBox();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.tlpAjustesTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.ckbAdicionar = new System.Windows.Forms.CheckBox();
            this.ckbExcluir = new System.Windows.Forms.CheckBox();
            this.ckbEditar = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpCrudUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarUnidade)).BeginInit();
            this.tlpCrudImputs.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.tlpAjustesTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCrudUnidade
            // 
            this.tlpCrudUnidade.ColumnCount = 1;
            this.tlpCrudUnidade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudUnidade.Controls.Add(this.dgvAlterarUnidade, 0, 3);
            this.tlpCrudUnidade.Controls.Add(this.tlpCrudImputs, 0, 2);
            this.tlpCrudUnidade.Controls.Add(this.tlpTitulo, 0, 1);
            this.tlpCrudUnidade.Controls.Add(this.tlpAjustesTitulo, 0, 0);
            this.tlpCrudUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrudUnidade.Location = new System.Drawing.Point(0, 0);
            this.tlpCrudUnidade.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCrudUnidade.Name = "tlpCrudUnidade";
            this.tlpCrudUnidade.RowCount = 4;
            this.tlpCrudUnidade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCrudUnidade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpCrudUnidade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCrudUnidade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudUnidade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCrudUnidade.Size = new System.Drawing.Size(860, 416);
            this.tlpCrudUnidade.TabIndex = 0;
            // 
            // dgvAlterarUnidade
            // 
            this.dgvAlterarUnidade.AllowUserToAddRows = false;
            this.dgvAlterarUnidade.AllowUserToDeleteRows = false;
            this.dgvAlterarUnidade.AllowUserToResizeColumns = false;
            this.dgvAlterarUnidade.AllowUserToResizeRows = false;
            this.dgvAlterarUnidade.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlterarUnidade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlterarUnidade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlterarUnidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlterarUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterarUnidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sigla,
            this.txb_Unidade,
            this.txb_Estado,
            this.txb_Regiao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlterarUnidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlterarUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlterarUnidade.EnableHeadersVisualStyles = false;
            this.dgvAlterarUnidade.Location = new System.Drawing.Point(0, 72);
            this.dgvAlterarUnidade.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAlterarUnidade.MultiSelect = false;
            this.dgvAlterarUnidade.Name = "dgvAlterarUnidade";
            this.dgvAlterarUnidade.ReadOnly = true;
            this.dgvAlterarUnidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAlterarUnidade.RowHeadersVisible = false;
            this.dgvAlterarUnidade.RowTemplate.Height = 25;
            this.dgvAlterarUnidade.Size = new System.Drawing.Size(860, 344);
            this.dgvAlterarUnidade.TabIndex = 0;
            this.dgvAlterarUnidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlterarUnidade_CellDoubleClick);
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "SIGLA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sigla.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            this.Sigla.Width = 60;
            // 
            // txb_Unidade
            // 
            this.txb_Unidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txb_Unidade.DataPropertyName = "UNIDADE";
            this.txb_Unidade.HeaderText = "       Unidade";
            this.txb_Unidade.Name = "txb_Unidade";
            this.txb_Unidade.ReadOnly = true;
            // 
            // txb_Estado
            // 
            this.txb_Estado.DataPropertyName = "UF";
            this.txb_Estado.HeaderText = "Estado";
            this.txb_Estado.Name = "txb_Estado";
            this.txb_Estado.ReadOnly = true;
            this.txb_Estado.Width = 60;
            // 
            // txb_Regiao
            // 
            this.txb_Regiao.DataPropertyName = "REGIAO";
            this.txb_Regiao.HeaderText = "       Regiao";
            this.txb_Regiao.Name = "txb_Regiao";
            this.txb_Regiao.ReadOnly = true;
            this.txb_Regiao.Width = 120;
            // 
            // tlpCrudImputs
            // 
            this.tlpCrudImputs.ColumnCount = 4;
            this.tlpCrudImputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCrudImputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudImputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCrudImputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCrudImputs.Controls.Add(this.txbRegiao, 3, 0);
            this.tlpCrudImputs.Controls.Add(this.txbUf, 2, 0);
            this.tlpCrudImputs.Controls.Add(this.txbUnidade, 1, 0);
            this.tlpCrudImputs.Controls.Add(this.txbCrudSigla, 0, 0);
            this.tlpCrudImputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrudImputs.Location = new System.Drawing.Point(0, 42);
            this.tlpCrudImputs.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCrudImputs.Name = "tlpCrudImputs";
            this.tlpCrudImputs.RowCount = 1;
            this.tlpCrudImputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudImputs.Size = new System.Drawing.Size(860, 30);
            this.tlpCrudImputs.TabIndex = 1;
            // 
            // txbRegiao
            // 
            this.txbRegiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRegiao.Location = new System.Drawing.Point(740, 0);
            this.txbRegiao.Margin = new System.Windows.Forms.Padding(0);
            this.txbRegiao.Name = "txbRegiao";
            this.txbRegiao.Size = new System.Drawing.Size(120, 23);
            this.txbRegiao.TabIndex = 4;
            // 
            // txbUf
            // 
            this.txbUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbUf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUf.Location = new System.Drawing.Point(680, 0);
            this.txbUf.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.txbUf.Name = "txbUf";
            this.txbUf.Size = new System.Drawing.Size(57, 23);
            this.txbUf.TabIndex = 3;
            // 
            // txbUnidade
            // 
            this.txbUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUnidade.Location = new System.Drawing.Point(60, 0);
            this.txbUnidade.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(617, 23);
            this.txbUnidade.TabIndex = 1;
            // 
            // txbCrudSigla
            // 
            this.txbCrudSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCrudSigla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbCrudSigla.Location = new System.Drawing.Point(0, 0);
            this.txbCrudSigla.Margin = new System.Windows.Forms.Padding(0, 0, 10, 3);
            this.txbCrudSigla.Name = "txbCrudSigla";
            this.txbCrudSigla.Size = new System.Drawing.Size(50, 23);
            this.txbCrudSigla.TabIndex = 5;
            this.txbCrudSigla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbCrudSigla_KeyUp);
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 4;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTitulo.Controls.Add(this.lblRegiao, 3, 0);
            this.tlpTitulo.Controls.Add(this.lblUf, 2, 0);
            this.tlpTitulo.Controls.Add(this.lblUnidade, 1, 0);
            this.tlpTitulo.Controls.Add(this.lblSigla, 0, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 27);
            this.tlpTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(860, 15);
            this.tlpTitulo.TabIndex = 3;
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(740, 0);
            this.lblRegiao.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(43, 15);
            this.lblRegiao.TabIndex = 3;
            this.lblRegiao.Text = "Regiao";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(680, 0);
            this.lblUf.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 15);
            this.lblUf.TabIndex = 2;
            this.lblUf.Text = "UF";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(60, 0);
            this.lblUnidade.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(51, 15);
            this.lblUnidade.TabIndex = 1;
            this.lblUnidade.Text = "Unidade";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(0, 0);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(32, 15);
            this.lblSigla.TabIndex = 0;
            this.lblSigla.Text = "Sigla";
            // 
            // tlpAjustesTitulo
            // 
            this.tlpAjustesTitulo.ColumnCount = 7;
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAjustesTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAjustesTitulo.Controls.Add(this.ckbAdicionar, 1, 0);
            this.tlpAjustesTitulo.Controls.Add(this.ckbExcluir, 3, 0);
            this.tlpAjustesTitulo.Controls.Add(this.ckbEditar, 5, 0);
            this.tlpAjustesTitulo.Controls.Add(this.btnEditar, 6, 0);
            this.tlpAjustesTitulo.Controls.Add(this.btnExcluir, 4, 0);
            this.tlpAjustesTitulo.Controls.Add(this.btnAdicionar, 2, 0);
            this.tlpAjustesTitulo.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpAjustesTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAjustesTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpAjustesTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAjustesTitulo.Name = "tlpAjustesTitulo";
            this.tlpAjustesTitulo.RowCount = 1;
            this.tlpAjustesTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAjustesTitulo.Size = new System.Drawing.Size(860, 27);
            this.tlpAjustesTitulo.TabIndex = 4;
            // 
            // ckbAdicionar
            // 
            this.ckbAdicionar.AutoSize = true;
            this.ckbAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckbAdicionar.Location = new System.Drawing.Point(485, 0);
            this.ckbAdicionar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ckbAdicionar.Name = "ckbAdicionar";
            this.ckbAdicionar.Size = new System.Drawing.Size(15, 24);
            this.ckbAdicionar.TabIndex = 5;
            this.ckbAdicionar.UseVisualStyleBackColor = true;
            this.ckbAdicionar.CheckedChanged += new System.EventHandler(this.ckbAdicionar_CheckedChanged);
            this.ckbAdicionar.Click += new System.EventHandler(this.ckbAdicionar_Click);
            // 
            // ckbExcluir
            // 
            this.ckbExcluir.AutoSize = true;
            this.ckbExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckbExcluir.Location = new System.Drawing.Point(615, 0);
            this.ckbExcluir.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ckbExcluir.Name = "ckbExcluir";
            this.ckbExcluir.Size = new System.Drawing.Size(15, 24);
            this.ckbExcluir.TabIndex = 6;
            this.ckbExcluir.UseVisualStyleBackColor = true;
            this.ckbExcluir.CheckedChanged += new System.EventHandler(this.ckbExcluir_CheckedChanged);
            this.ckbExcluir.Click += new System.EventHandler(this.ckbExcluir_Click);
            // 
            // ckbEditar
            // 
            this.ckbEditar.AutoSize = true;
            this.ckbEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckbEditar.Location = new System.Drawing.Point(745, 0);
            this.ckbEditar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ckbEditar.Name = "ckbEditar";
            this.ckbEditar.Size = new System.Drawing.Size(15, 24);
            this.ckbEditar.TabIndex = 6;
            this.ckbEditar.UseVisualStyleBackColor = true;
            this.ckbEditar.CheckedChanged += new System.EventHandler(this.ckbEditar_CheckedChanged);
            this.ckbEditar.Click += new System.EventHandler(this.ckbEditar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(760, 0);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 27);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(630, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 27);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(500, 0);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 27);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(464, 15);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "label1";
            // 
            // uscCrudUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpCrudUnidade);
            this.Name = "uscCrudUnidades";
            this.Size = new System.Drawing.Size(860, 416);
            this.tlpCrudUnidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarUnidade)).EndInit();
            this.tlpCrudImputs.ResumeLayout(false);
            this.tlpCrudImputs.PerformLayout();
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.tlpAjustesTitulo.ResumeLayout(false);
            this.tlpAjustesTitulo.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        public TextBox txbRegiao;
        public DataGridView dgvAlterarUnidade;
        public TableLayoutPanel tlpCrudUnidade;
        public TableLayoutPanel tlpCrudImputs;
        public TextBox txbUf;
        public TextBox txbUnidade;
        public Button btnAdicionar;
        public TableLayoutPanel tlpTitulo;
        public Label lblRegiao;
        public Label lblUf;
        public Label lblUnidade;
        public Label lblSigla;
        private DataGridViewTextBoxColumn Sigla;
        private DataGridViewTextBoxColumn txb_Unidade;
        private DataGridViewTextBoxColumn txb_Estado;
        private DataGridViewTextBoxColumn txb_Regiao;
        private CheckBox ckbAdicionar;
        private CheckBox ckbExcluir;
        private CheckBox ckbEditar;
        public Button btnEditar;
        public Button btnExcluir;
        private TableLayoutPanel tlpAjustesTitulo;
        private Label lblTitulo;
        private TextBox txbCrudSigla;
    }
}
