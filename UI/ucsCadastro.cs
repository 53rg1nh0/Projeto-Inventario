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

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential("serginhoagostinho@gmail.com", "fiwomfoxiakcjecn");
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    MailMessage mensagem = new MailMessage();

                    //mensagem.Sender = new MailAddress("serginhoagostinho@gmail.com", "Sergio");
                    mensagem.From = new MailAddress("sesousa@solarbr.com.br", "INVENTÁRIO TI");
                    mensagem.To.Add(new MailAddress("sesousa@solarbr.com.br","Sergio"));

                    mensagem.Subject = "Alterar senha Sistema Inventário TI";
                    mensagem.Body = "Aew!";

                    mensagem.IsBodyHtml = true;

                    client.Send(mensagem);

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
    }
}
