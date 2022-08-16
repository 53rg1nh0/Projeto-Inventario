namespace UI
{
    partial class uscCrudResponsaveis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscCrudResponsaveis));
            this.tlpCrudResposaveis = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRsposavel = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCoporativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonePessoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCrudTxb = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.ckbEditar = new System.Windows.Forms.CheckBox();
            this.lblCrudRsponsavelTitulo = new System.Windows.Forms.Label();
            this.tlpCrudLbl = new System.Windows.Forms.TableLayoutPanel();
            this.lblResposavelNome = new System.Windows.Forms.Label();
            this.lblResponsavelTipo = new System.Windows.Forms.Label();
            this.lblResposavelUnidades = new System.Windows.Forms.Label();
            this.tlpCrudResposaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsposavel)).BeginInit();
            this.tlpCrudTxb.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.tlpCrudLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCrudResposaveis
            // 
            this.tlpCrudResposaveis.ColumnCount = 1;
            this.tlpCrudResposaveis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudResposaveis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCrudResposaveis.Controls.Add(this.dgvRsposavel, 0, 3);
            this.tlpCrudResposaveis.Controls.Add(this.tlpCrudTxb, 0, 2);
            this.tlpCrudResposaveis.Controls.Add(this.tlpTitulo, 0, 0);
            this.tlpCrudResposaveis.Controls.Add(this.tlpCrudLbl, 0, 1);
            this.tlpCrudResposaveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrudResposaveis.Location = new System.Drawing.Point(0, 0);
            this.tlpCrudResposaveis.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCrudResposaveis.Name = "tlpCrudResposaveis";
            this.tlpCrudResposaveis.RowCount = 4;
            this.tlpCrudResposaveis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpCrudResposaveis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpCrudResposaveis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCrudResposaveis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudResposaveis.Size = new System.Drawing.Size(1166, 554);
            this.tlpCrudResposaveis.TabIndex = 0;
            // 
            // dgvRsposavel
            // 
            this.dgvRsposavel.AllowUserToAddRows = false;
            this.dgvRsposavel.AllowUserToDeleteRows = false;
            this.dgvRsposavel.AllowUserToResizeColumns = false;
            this.dgvRsposavel.AllowUserToResizeRows = false;
            this.dgvRsposavel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRsposavel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRsposavel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRsposavel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRsposavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRsposavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Area,
            this.Cargo,
            this.Unidades,
            this.USERID,
            this.TelefoneCoporativo,
            this.TelefonePessoal,
            this.Email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRsposavel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRsposavel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRsposavel.EnableHeadersVisualStyles = false;
            this.dgvRsposavel.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRsposavel.Location = new System.Drawing.Point(0, 72);
            this.dgvRsposavel.Margin = new System.Windows.Forms.Padding(0);
            this.dgvRsposavel.MultiSelect = false;
            this.dgvRsposavel.Name = "dgvRsposavel";
            this.dgvRsposavel.ReadOnly = true;
            this.dgvRsposavel.RowHeadersVisible = false;
            this.dgvRsposavel.RowTemplate.Height = 25;
            this.dgvRsposavel.Size = new System.Drawing.Size(1166, 482);
            this.dgvRsposavel.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "NOME";
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "AREA";
            this.Area.HeaderText = "ÁREA";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cargo.DataPropertyName = "CARGO";
            this.Cargo.HeaderText = "CARGO";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "UNIDADES";
            this.Unidades.HeaderText = "UNIDADES";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // USERID
            // 
            this.USERID.DataPropertyName = "USERID";
            this.USERID.HeaderText = "USERID";
            this.USERID.Name = "USERID";
            this.USERID.ReadOnly = true;
            this.USERID.Visible = false;
            // 
            // TelefoneCoporativo
            // 
            this.TelefoneCoporativo.DataPropertyName = "TELEFONECORPORATIVO";
            this.TelefoneCoporativo.HeaderText = "T. CORP.";
            this.TelefoneCoporativo.Name = "TelefoneCoporativo";
            this.TelefoneCoporativo.ReadOnly = true;
            // 
            // TelefonePessoal
            // 
            this.TelefonePessoal.DataPropertyName = "TELEFONEPESSOAL";
            this.TelefonePessoal.HeaderText = "T. PESSOAL";
            this.TelefonePessoal.Name = "TelefonePessoal";
            this.TelefonePessoal.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "E-MAIL";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // tlpCrudTxb
            // 
            this.tlpCrudTxb.ColumnCount = 3;
            this.tlpCrudTxb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudTxb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCrudTxb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCrudTxb.Controls.Add(this.textBox1, 0, 0);
            this.tlpCrudTxb.Controls.Add(this.cbbTipoUsuario, 2, 0);
            this.tlpCrudTxb.Controls.Add(this.txbUnidade, 1, 0);
            this.tlpCrudTxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrudTxb.Location = new System.Drawing.Point(0, 42);
            this.tlpCrudTxb.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCrudTxb.Name = "tlpCrudTxb";
            this.tlpCrudTxb.RowCount = 1;
            this.tlpCrudTxb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudTxb.Size = new System.Drawing.Size(1166, 30);
            this.tlpCrudTxb.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(903, 23);
            this.textBox1.TabIndex = 0;
            // 
            // cbbTipoUsuario
            // 
            this.cbbTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoUsuario.Items.AddRange(new object[] {
            "admin",
            "comum"});
            this.cbbTipoUsuario.Location = new System.Drawing.Point(1069, 3);
            this.cbbTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbbTipoUsuario.Name = "cbbTipoUsuario";
            this.cbbTipoUsuario.Size = new System.Drawing.Size(87, 23);
            this.cbbTipoUsuario.TabIndex = 10;
            // 
            // txbUnidade
            // 
            this.txbUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUnidade.Location = new System.Drawing.Point(919, 3);
            this.txbUnidade.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(137, 23);
            this.txbUnidade.TabIndex = 3;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 7;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulo.Controls.Add(this.btnEditar, 6, 0);
            this.tlpTitulo.Controls.Add(this.ckbEditar, 5, 0);
            this.tlpTitulo.Controls.Add(this.lblCrudRsponsavelTitulo, 0, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(1166, 27);
            this.tlpTitulo.TabIndex = 0;
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
            this.btnEditar.Location = new System.Drawing.Point(1066, 0);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 27);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // ckbEditar
            // 
            this.ckbEditar.AutoSize = true;
            this.ckbEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckbEditar.Location = new System.Drawing.Point(1051, 0);
            this.ckbEditar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ckbEditar.Name = "ckbEditar";
            this.ckbEditar.Size = new System.Drawing.Size(15, 24);
            this.ckbEditar.TabIndex = 11;
            this.ckbEditar.UseVisualStyleBackColor = true;
            this.ckbEditar.Click += new System.EventHandler(this.ckbEditar_Click);
            // 
            // lblCrudRsponsavelTitulo
            // 
            this.lblCrudRsponsavelTitulo.AutoSize = true;
            this.lblCrudRsponsavelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCrudRsponsavelTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCrudRsponsavelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCrudRsponsavelTitulo.Name = "lblCrudRsponsavelTitulo";
            this.lblCrudRsponsavelTitulo.Size = new System.Drawing.Size(776, 15);
            this.lblCrudRsponsavelTitulo.TabIndex = 12;
            this.lblCrudRsponsavelTitulo.Text = "Informações dos Responsáveis";
            // 
            // tlpCrudLbl
            // 
            this.tlpCrudLbl.ColumnCount = 3;
            this.tlpCrudLbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudLbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCrudLbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCrudLbl.Controls.Add(this.lblResposavelNome, 0, 0);
            this.tlpCrudLbl.Controls.Add(this.lblResponsavelTipo, 2, 0);
            this.tlpCrudLbl.Controls.Add(this.lblResposavelUnidades, 1, 0);
            this.tlpCrudLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrudLbl.Location = new System.Drawing.Point(0, 27);
            this.tlpCrudLbl.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCrudLbl.Name = "tlpCrudLbl";
            this.tlpCrudLbl.RowCount = 1;
            this.tlpCrudLbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrudLbl.Size = new System.Drawing.Size(1166, 15);
            this.tlpCrudLbl.TabIndex = 1;
            // 
            // lblResposavelNome
            // 
            this.lblResposavelNome.AutoSize = true;
            this.lblResposavelNome.Location = new System.Drawing.Point(3, 0);
            this.lblResposavelNome.Name = "lblResposavelNome";
            this.lblResposavelNome.Size = new System.Drawing.Size(40, 15);
            this.lblResposavelNome.TabIndex = 0;
            this.lblResposavelNome.Text = "Nome";
            // 
            // lblResponsavelTipo
            // 
            this.lblResponsavelTipo.AutoSize = true;
            this.lblResponsavelTipo.Location = new System.Drawing.Point(1069, 0);
            this.lblResponsavelTipo.Name = "lblResponsavelTipo";
            this.lblResponsavelTipo.Size = new System.Drawing.Size(73, 15);
            this.lblResponsavelTipo.TabIndex = 7;
            this.lblResponsavelTipo.Text = "Tipo Usuário";
            // 
            // lblResposavelUnidades
            // 
            this.lblResposavelUnidades.AutoSize = true;
            this.lblResposavelUnidades.Location = new System.Drawing.Point(919, 0);
            this.lblResposavelUnidades.Name = "lblResposavelUnidades";
            this.lblResposavelUnidades.Size = new System.Drawing.Size(51, 15);
            this.lblResposavelUnidades.TabIndex = 3;
            this.lblResposavelUnidades.Text = "Unidade";
            // 
            // uscCrudResponsaveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpCrudResposaveis);
            this.Name = "uscCrudResponsaveis";
            this.Size = new System.Drawing.Size(1166, 554);
            this.tlpCrudResposaveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsposavel)).EndInit();
            this.tlpCrudTxb.ResumeLayout(false);
            this.tlpCrudTxb.PerformLayout();
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.tlpCrudLbl.ResumeLayout(false);
            this.tlpCrudLbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpCrudResposaveis;
        private TableLayoutPanel tlpTitulo;
        public DataGridView dgvRsposavel;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Unidades;
        private DataGridViewTextBoxColumn USERID;
        private DataGridViewTextBoxColumn TelefoneCoporativo;
        private DataGridViewTextBoxColumn TelefonePessoal;
        private DataGridViewTextBoxColumn Email;
        public Button btnEditar;
        private CheckBox ckbEditar;
        private TextBox txbUnidade;
        private TextBox textBox1;
        private Label lblCrudRsponsavelTitulo;
        private Label lblResposavelUnidades;
        private Label lblResposavelNome;
        private ComboBox cbbTipoUsuario;
        private Label lblResponsavelTipo;
        public TableLayoutPanel tlpCrudTxb;
        public TableLayoutPanel tlpCrudLbl;
    }
}
