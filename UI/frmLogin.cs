using RelacaoPespUni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ucsLogin.lblUsuario.Text = "Usuário";
            ucsLogin.lblSenhaAntiga.Text = "Senha";
            ucsLogin.lblCadastrar.Text = "Cadastrar";
            ucsLogin.lblEditarCadastro.Text = "Redefinir senha";
            ucsLogin.txbLoginSenhaAntiga.PasswordChar = '*';

            ucsLogin.btnNext.Click += Next;
            ucsLogin.btnFechar.Click += Fechar;
            Animacao.Arrastar(this);
        }

        private void Next(object sender, EventArgs e)
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
                        FrmInventario.Name = ucsLogin.txbLoginNome.Text;
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

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
