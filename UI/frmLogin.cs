using ConexaoDB;
using RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class frmLogin : Form
    {
        private string senha;
        private bool editarCadastro = false;
        private ucsCadastro ucsCadastro1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ucsLogin.lblUsuario.Text = "Usuário";
            ucsLogin.lblSenhaAntiga.Text = "Senha";
            ucsLogin.lblCadastrar.Text = "Cadastrar";
            ucsLogin.lblEditarCadastro.Text = "Editar Cadastro";
            ucsLogin.txbLoginSenhaAntiga.PasswordChar = '*';

            ucsLogin.btnNext.Click += Next;
            ucsLogin.btnFechar.Click += Fechar;
            ucsLogin.lblEditarCadastro.Click += EditarCadastro;
            Animacao.Arrastar(this);
        }

        private void Next(object sender, EventArgs e)
        {
            if (!editarCadastro)
            {
                if (ucsLogin.txbLoginNome.Text == "" || ucsLogin.txbLoginSenhaAntiga.Text == "")
                {
                    MessageBox.Show("Não pode haver campos em branco!");
                }
                else
                {
                    try
                    {
                        Responsavel r = new Responsavel(ucsLogin.txbLoginNome.Text);
                        if (r.Senha == ucsLogin.txbLoginSenhaAntiga.Text)
                        {
                            r.Logar();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Usuário ou senha imcorretos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ucsLogin.txbLoginSenhaAntiga.Text = "";
                    }
                }
            }
            else
            {
                try
                {
                    Cliente c = new Cliente(ucsLogin.txbLoginNome.Text.ToLower());
                    Responsavel r = new Responsavel(ucsLogin.txbLoginNome.Text.ToLower());
                    senha = Responsavel.Autenticar(r.Email);

                    LayoutFormulario();
                    Animacao.Arrastar(this);
                }
                catch (ExcessaoRegraNegocio)
                {
                    MessageBox.Show("Usuário não existe");
                }
                catch (ExcessaoBanco ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EditarCadastro(object sender, EventArgs e)
        {
            if (!editarCadastro)
            {
                editarCadastro = true;
                ucsLogin.lblSenhaAntiga.Visible = false;
                ucsLogin.txbLoginSenhaAntiga.Visible = false;
                ucsLogin.lblCadastrar.Visible = false;
                ucsLogin.lblEditarCadastro.Text = "Voltar";
            }
            else
            {
                editarCadastro = false;
                ucsLogin.lblSenhaAntiga.Visible = true;
                ucsLogin.txbLoginSenhaAntiga.Visible = true;
                ucsLogin.lblCadastrar.Visible = true;
                ucsLogin.lblEditarCadastro.Text = "Editar Cadastro";
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (editarCadastro)
            {
                Application.Restart();
            }

        }

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LayoutFormulario()
        {
            this.ucsCadastro1 = new UI.ucsCadastro();
            this.ClientSize = new System.Drawing.Size(898, 267);
            this.Controls.Add(this.ucsCadastro1);

            ucsLogin.Dock = System.Windows.Forms.DockStyle.None;
            ucsLogin.Visible = false;

            this.ucsCadastro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucsCadastro1.Location = new System.Drawing.Point(0, 0);
            this.ucsCadastro1.Size = new System.Drawing.Size(898, 267);

            // 
            // pnlCadastroTop
            // 
            ucsCadastro1.pnlCadastroTop.Dock = System.Windows.Forms.DockStyle.None;
            ucsCadastro1.pnlCadastroTop.Location = new Point(10, 18);
            ucsCadastro1.pnlCadastroTop.Size = new Size(292, 119);
            // 
            // lblCadastroTitulo
            // 
            ucsCadastro1.lblCadastroTitulo.Text = "               Editar Cadastro";
            // 
            // pnlCadastroCentral
            // 
            ucsCadastro1.pnlCadastroCentral.Location = new System.Drawing.Point(9, 4);
            ucsCadastro1.pnlCadastroCentral.Size = new System.Drawing.Size(880, 264);
            // 
            // pnlCadastroButton
            // 
            ucsCadastro1.pnlCadastroButton.Location = new System.Drawing.Point(595, 215);
            ucsCadastro1.pnlCadastroButton.Size = new System.Drawing.Size(292, 43);
            ucsCadastro1.pnlCadastroButton.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // btnCadastroExcluir
            // 
            ucsCadastro1.btnCadastroExcluir.Location = new System.Drawing.Point(755, 65);
            ucsCadastro1.btnCadastroExcluir.Size = new System.Drawing.Size(40, 40);
            // 
            // btnCadastroIncluir
            // 
            ucsCadastro1.btnCadastroIncluir.Location = new System.Drawing.Point(673, 65);
            ucsCadastro1.btnCadastroIncluir.Size = new System.Drawing.Size(40, 40);
            // 
            // mtbCadastroTelPes
            // 
            ucsCadastro1.mtbCadastroTelPes.Location = new System.Drawing.Point(306, 79);
            ucsCadastro1.mtbCadastroTelPes.Size = new System.Drawing.Size(266, 23);

            // 
            // mtbCadastroTelCorp
            // 
            ucsCadastro1.mtbCadastroTelCorp.Location = new System.Drawing.Point(306, 30); ;
            ucsCadastro1.mtbCadastroTelCorp.Size = new System.Drawing.Size(266, 23);
            // 
            // txbCadastroUsuario
            // 
            ucsCadastro1.txbCadastroUsuario.Location = new System.Drawing.Point(17, 170);
            ucsCadastro1.txbCadastroUsuario.Size = new System.Drawing.Size(266, 23);
            // 
            // lblCadastroEmail
            // 
            ucsCadastro1.lblCadastroEmail.Location = new System.Drawing.Point(17, 200);
            ucsCadastro1.lblCadastroEmail.Size = new System.Drawing.Size(41, 15);
            // 
            // txbCadastroEmail
            // 
            ucsCadastro1.txbCadastroEmail.Location = new System.Drawing.Point(17, 219);
            ucsCadastro1.txbCadastroEmail.Size = new System.Drawing.Size(266, 23);
            // 
            // lblCadastroMatricula
            // 
            ucsCadastro1.lblCadastroMatricula.Location = new System.Drawing.Point(304, 201);
            ucsCadastro1.lblCadastroMatricula.Size = new System.Drawing.Size(57, 15);
            // 
            // lblCadastroUsuario
            // 
            ucsCadastro1.lblCadastroUsuario.Location = new System.Drawing.Point(17, 152);
            ucsCadastro1.lblCadastroUsuario.Size = new System.Drawing.Size(47, 15);
            // 
            // txbCadastroMtricula
            // 
            ucsCadastro1.txbCadastroMtricula.Location = new System.Drawing.Point(306, 219);
            ucsCadastro1.txbCadastroMtricula.Size = new System.Drawing.Size(266, 23);
            // 
            // txbCadastroSenha
            // 
            ucsCadastro1.txbCadastroSenha.Location = new System.Drawing.Point(306, 122);
            ucsCadastro1.txbCadastroSenha.Size = new System.Drawing.Size(266, 23);
            // 
            // lblCadastroSenhaTemp
            // 
            ucsCadastro1.lblCadastroSenhaTemp.Location = new System.Drawing.Point(598, 154);
            ucsCadastro1.lblCadastroSenhaTemp.Size = new System.Drawing.Size(46, 15);
            // 
            // txbCadastroConfirmar
            // 
            ucsCadastro1.txbCadastroConfirmar.Location = new System.Drawing.Point(306, 171);
            ucsCadastro1.txbCadastroConfirmar.Size = new System.Drawing.Size(266, 23);
            // 
            // txbCadastroSenhaTemp
            // 
            ucsCadastro1.txbCadastroSenhaTemp.Location = new System.Drawing.Point(600, 171);
            ucsCadastro1.txbCadastroSenhaTemp.Size = new System.Drawing.Size(266, 23);
            // 
            // lblCadastrarSenha
            // 
            ucsCadastro1.lblCadastrarSenha.Location = new System.Drawing.Point(304, 105);
            ucsCadastro1.lblCadastrarSenha.Size = new System.Drawing.Size(70, 15);
            // 
            // lblCadastroExcluir
            // 
            ucsCadastro1.lblCadastroExcluir.Location = new System.Drawing.Point(801, 87);
            ucsCadastro1.lblCadastroExcluir.Size = new System.Drawing.Size(42, 15);
            // 
            // lblCadastroConfirmar
            // 
            ucsCadastro1.lblCadastroConfirmar.Location = new System.Drawing.Point(304, 153);
            ucsCadastro1.lblCadastroConfirmar.Size = new System.Drawing.Size(96, 15);
            // 
            // lblCadastroIncluir
            // 
            ucsCadastro1.lblCadastroIncluir.Location = new System.Drawing.Point(602, 87);
            ucsCadastro1.lblCadastroIncluir.Size = new System.Drawing.Size(40, 15);
            // 
            // cbxCadastroExcluir
            // 
            ucsCadastro1.cbxCadastroExcluir.Location = new System.Drawing.Point(801, 104);
            ucsCadastro1.cbxCadastroExcluir.Size = new System.Drawing.Size(65, 23);
            // 
            // cbxCadastroIncluir
            // 
            ucsCadastro1.cbxCadastroIncluir.Location = new System.Drawing.Point(602, 104);
            ucsCadastro1.cbxCadastroIncluir.Size = new System.Drawing.Size(65, 23);
            // 
            // lblCadastroTelCorp
            // 
            ucsCadastro1.lblCadastroTelCorp.Location = new System.Drawing.Point(304, 12);
            ucsCadastro1.lblCadastroTelCorp.Size = new System.Drawing.Size(117, 15);
            // 
            // lblCadastroUnidades
            // 
            ucsCadastro1.lblCadastroUnidades.Location = new System.Drawing.Point(598, 13);
            ucsCadastro1.lblCadastroUnidades.Size = new System.Drawing.Size(56, 15);
            // 
            // lblCadastroTelPess
            // 
            ucsCadastro1.lblCadastroTelPess.Location = new System.Drawing.Point(304, 61);
            ucsCadastro1.lblCadastroTelPess.Size = new System.Drawing.Size(93, 15);
            // 
            // txbCadastroUnidades
            // 
            ucsCadastro1.txbCadastroUnidades.Location = new System.Drawing.Point(600, 30);
            ucsCadastro1.txbCadastroUnidades.Size = new System.Drawing.Size(266, 23);
            // 
            // ucsCadastro
            // 
            ucsCadastro1.Size = new System.Drawing.Size(898, 269);

        }

    }
}
