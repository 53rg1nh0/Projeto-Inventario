using RelacaoPespUni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ucsCadastro : UserControl
    {
        private string Senha = "";
        private int pagina = 1;
        public ucsCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastroVoltar_Click(object sender, EventArgs e)
        {
            frmCadastro.ActiveForm.Close();
            frmLogin.ActiveForm.Opacity = 100;
        }

        private void btnCadastroCadastrar_Click(object sender, EventArgs e)
        {
            string exp = @"(\w+.)?\w+@solarbr.com.br";
            Regex re = new Regex(exp);
            try
            {
                switch (pagina)
                {
                    case 1:
                        if (re.IsMatch(txbCadastroEmail.Text))
                        {
                            Cliente c = new Cliente(txbCadastroUsuario.Text);

                            Senha = Responsavel.Autenticar(txbCadastroEmail.Text);

                            pagina = 2;

                            PulaPagina();

                            txbCadastroSenhaTemp.Focus();

                            lblCadastroTitulo.Text = "                 Alterar Senha";
                        }
                        else
                        {
                            throw new Exception("E-mail não é valido! Apenas e-mail com domínio (solarbr.com.br)");
                        }

                        break;
                    case 2:
                        if (Senha == txbCadastroSenhaTemp.Text && txbCadastroSenha.Text != "" && txbCadastroConfirmar.Text != "" && txbCadastroSenha.Text == txbCadastroConfirmar.Text)
                        {

                            pagina = 3;

                            PulaPagina();

                            txbCadastroUnidades.Focus();

                            lblCadastroTitulo.Text = "              Cadastrar Dados";
                        }
                        else
                        {
                            if(Senha != txbCadastroSenhaTemp.Text)
                            {
                                throw new Exception("Senha de autenticação não confere com a enviada por e-mail!");
                            }
                            else if(txbCadastroConfirmar.Text == "" || txbCadastroSenha.Text == "")
                            {
                                throw new Exception("A senha alterada não pode ser nula!");
                            }
                            else if (txbCadastroSenha.Text != txbCadastroConfirmar.Text)
                            {
                                throw new Exception("Senhas não coincidem!");
                            }
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PulaPagina()
        {
            pnlCadastroCentral.Location = new Point(pnlCadastroCentral.Location.X, pnlCadastroCentral.Location.Y - 145);
        }


    }
}
