using ConexaoDB;
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
    public partial class ucsLogin : UserControl
    {
        public ucsLogin()
        {
            InitializeComponent();
        }

        private void lblCadastrar_MouseHover(object sender, EventArgs e)
        {
            lblCadastrar.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
        }

        private void lblCadastrar_MouseLeave(object sender, EventArgs e)
        {
            lblCadastrar.ForeColor = SystemColors.Control;
        }

        private void lblCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrar.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
        }
        private void lblEditarCadastro_MouseHover(object sender, EventArgs e)
        {
            lblEditarCadastro.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
        }

        private void lblEditarCadastro_MouseLeave(object sender, EventArgs e)
        {
            lblEditarCadastro.ForeColor = SystemColors.Control;
        }

        private void lblEditarCadastro_MouseEnter(object sender, EventArgs e)
        {
            lblEditarCadastro.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
        }

        private void txbLoginSenhaAntiga_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter && lblSenhaAntiga.Text=="Senha")
            {
                if (txbLoginNome.Text == "" || txbLoginSenhaAntiga.Text == "")
                {
                    MessageBox.Show("Não pode haver campos em branco!");
                }
                else
                {
                    try
                    {
                        Responsavel r = new Responsavel(txbLoginNome.Text);
                        if (r.Senha == txbLoginSenhaAntiga.Text)
                        {
                            frmLogin.ActiveForm.Close();
                        }
                        else
                        {
                            throw new Exception("Usuário ou senha imcorretos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txbLoginSenhaAntiga.Text = "";
                    }
                }
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            //frmCadastro f = new frmCadastro(Tabela.Unidades);
            //f.ShowDialog();
            ucsCadastro.Visible = true;
        }

        
    }
}
