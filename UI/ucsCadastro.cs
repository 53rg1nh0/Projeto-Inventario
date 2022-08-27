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
        public ucsCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastroVoltar_Click(object sender, EventArgs e)
        {
            frmCadastro.ActiveForm.Close();
            frmLogin.ActiveForm.Opacity = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exp = @"(\w+.)?\w+@solarbr.com.br";
            Regex re = new Regex(exp);
            try
            {
                if (re.IsMatch(txbCadastroEmail.Text))
                {
                    Cliente c = new Cliente(txbCadastroUsuario.Text);

                    Senha = Responsavel.Autenticar(txbCadastroEmail.Text);

                    txbCadastroSenhaTemp.Enabled = true;
                    txbCadastroSenhaTemp.Focus();
                    txbCadastroSenha.Enabled = true;
                    txbCadastroConfirmar.Enabled = true;
                    txbCadastroMtricula.Enabled = true;

                    txbCadastroSenhaTemp.BorderStyle = BorderStyle.Fixed3D;
                    txbCadastroSenha.BorderStyle = BorderStyle.Fixed3D;
                    txbCadastroConfirmar.BorderStyle = BorderStyle.Fixed3D;
                    txbCadastroMtricula.BorderStyle = BorderStyle.Fixed3D;

                    txbCadastroSenhaTemp.BackColor = System.Drawing.SystemColors.Window;
                    txbCadastroSenha.BackColor = System.Drawing.SystemColors.Window;
                    txbCadastroConfirmar.BackColor = System.Drawing.SystemColors.Window;
                    txbCadastroMtricula.BackColor = System.Drawing.SystemColors.Window;

                    btnCadastroProsseguir2.Enabled = true;
                }
                else
                {
                    throw new Exception("E-mail não é valido! Apenas e-mail com domínio (solarbr.com.br)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCadastroProsseguir2_Click(object sender, EventArgs e)
        {
            if (Senha==txbCadastroSenhaTemp.Text && txbCadastroSenha.Text!="" && txbCadastroConfirmar.Text != "" && txbCadastroSenha.Text== txbCadastroConfirmar.Text)
            {
                txbCadastroTelCorp.Enabled = true;
                txbCadastroTelCorp.Focus();
                txbCadastroTelPess.Enabled = true;
                txbCadastroUnidades.Enabled = true;
                cbxCadastroIncluir.Enabled = true; 
                cbxCadastroExcluir.Enabled = true;

                txbCadastroTelCorp.BorderStyle = BorderStyle.Fixed3D;
                txbCadastroTelPess.BorderStyle = BorderStyle.Fixed3D;
                txbCadastroUnidades.BorderStyle = BorderStyle.Fixed3D;

                txbCadastroTelCorp.BackColor = System.Drawing.SystemColors.Window;
                txbCadastroTelPess.BackColor = System.Drawing.SystemColors.Window;
                txbCadastroUnidades.BackColor = System.Drawing.SystemColors.Window;
                cbxCadastroIncluir.BackColor = System.Drawing.SystemColors.Window;
                cbxCadastroExcluir.BackColor = System.Drawing.SystemColors.Window;

                btnCadastroProsseguir1.Enabled = false;
                btnCadastroCadastrar.Enabled = true;
            }
            else
            {

            }
        }
    }
}
