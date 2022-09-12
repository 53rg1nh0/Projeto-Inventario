﻿using ConexaoDB;
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
        public DataTable Unidades { get; set; }
        private string Senha = "";
        private int pagina = 1;
        public ucsCadastro()
        {
            Unidades = Tabela.Unidades;
            InitializeComponent();
            cbxCadastroIncluir.DataSource = Unidades;
            cbxCadastroIncluir.ValueMember = "SIGLA";
            cbxCadastroIncluir.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



        private void btnCadastroCadastrar_Click(object sender, EventArgs e)
        {
            string exp = @"^(\w+.)?\w+@solarbr.com.br$";
            string tel = @"^[(][0-9]{2}[)][ ]([0-9][ ])?[0-9]{4}[-][0-9]{4}$";
            string mat = @"^[1-9][0-9]{7}([0-9]{2})?$";

            string min = "[a-z]+";
            string mai = "[A-Z]+";
            string num = "[1-9]+";
            string esp = @"\W+";

            Regex re = new Regex(exp);
            Regex te = new Regex(tel);
            Regex ma = new Regex(mat);

            Regex s1 = new Regex(min);
            Regex s2 = new Regex(num);
            Regex s3 = new Regex(esp);
            Regex s4 = new Regex(mai);
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
                            if (s1.IsMatch(txbCadastroSenha.Text) && s2.IsMatch(txbCadastroSenha.Text) && s3.IsMatch(txbCadastroSenha.Text) && s4.IsMatch(txbCadastroSenha.Text) && txbCadastroSenha.Text.Length > 6)
                            {
                                pagina = 3;

                                PulaPagina();

                                txbCadastroMtricula.Focus();

                                lblCadastroTitulo.Text = "              Cadastrar Dados";

                            }

                            else
                            {
                                throw new Exception("Senha não atende aos requisitos mínimos de complexidade e segurança!");
                            }
                        }
                        else
                        {
                            if (Senha != txbCadastroSenhaTemp.Text)
                            {
                                throw new Exception("Senha de autenticação não confere com a enviada por e-mail!");
                            }
                            else if (txbCadastroConfirmar.Text == "" || txbCadastroSenha.Text == "")
                            {
                                throw new Exception("A senha alterada não pode ser nula!");
                            }
                            else if (txbCadastroSenha.Text != txbCadastroConfirmar.Text)
                            {
                                throw new Exception("Senhas não coincidem!");
                            }
                        }
                        break;

                    case 3:
                        if (ma.IsMatch(txbCadastroMtricula.Text) && te.IsMatch(mtbCadastroTelCorp.Text) && te.IsMatch(mtbCadastroTelPes.Text))
                        {
                            pagina = 4;

                            PulaPagina();

                            txbCadastroUnidades.Focus();

                            btnCadastroCadastrar.Text = "Cadastrar";

                            lblCadastroTitulo.Text = "           Cadastrar Unidades";
                        }
                        else
                        {
                            if (!ma.IsMatch(txbCadastroMtricula.Text))
                            {
                                throw new Exception("Matricula fora do padrão!");
                            }
                            else if (!te.IsMatch(mtbCadastroTelCorp.Text) || !te.IsMatch(mtbCadastroTelPes.Text))
                            {
                                throw new Exception("Não é um número válido!");
                            }

                        }
                        break;

                    case 4:
                        if (txbCadastroUnidades.Text != "")
                        {
                            Responsavel r = new Responsavel(mtbCadastroTelCorp.Text, mtbCadastroTelPes.Text, txbCadastroEmail.Text, txbCadastroUsuario.Text, txbCadastroSenha.Text);

                            r.IncerirNoBanco();
                            foreach (Object item in cbxCadastroExcluir.Items)
                            {
                                Relacao.IncerirNoBancoRespUni(txbCadastroUsuario.Text, item.ToString());
                            }
                            MessageBox.Show("Cadastro realizado com sucesso!");

                            pagina = 1;
                            txbCadastroUsuario.Text = "";
                            txbCadastroEmail.Text = "";
                            txbCadastroSenhaTemp.Text = "";
                            txbCadastroSenha.Text = "";
                            txbCadastroConfirmar.Text = "";
                            txbCadastroMtricula.Text = "";
                            mtbCadastroTelCorp.Text = "";
                            mtbCadastroTelPes.Text = "";
                            txbCadastroUnidades.Text = "";

                            foreach (Object item in cbxCadastroExcluir.Items)
                            {
                                Unidades.Rows.Add(item.ToString());
                            }
                            cbxCadastroExcluir.Items.Clear();
                            pnlCadastroCentral.Location = new Point(pnlCadastroCentral.Location.X, pnlCadastroCentral.Location.Y + 447);
                            Visible = false;
                        }
                        else
                        {
                            throw new Exception("Insira as unidades em que você é o responsavel local.");
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
            pnlCadastroCentral.Location = new Point(pnlCadastroCentral.Location.X, pnlCadastroCentral.Location.Y - 149);
        }

        private void btnCadastroIncluir_Click(object sender, EventArgs e)
        {
            cbxCadastroExcluir.Items.Add(cbxCadastroIncluir.Text);
            if (ReferenceEquals(Unidades, null))
            {
                Unidades = Tabela.Unidades;
            }
            Unidades.Rows.Remove(Unidades.Rows[cbxCadastroIncluir.SelectedIndex]);
            cbxCadastroIncluir.DataSource = Unidades;

            txbCadastroUnidades.Text = ListaUnidades();
        }

        private void btnCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (cbxCadastroExcluir.Items.Count > 0)
            {
                Unidades.Rows.Add(cbxCadastroExcluir.Text);
                cbxCadastroIncluir.DataSource = Unidades;
                cbxCadastroExcluir.Items.Remove(cbxCadastroExcluir.Text);
                txbCadastroUnidades.Text = ListaUnidades();
            }
        }

        private string ListaUnidades()
        {
            string result = "";

            foreach (Object item in cbxCadastroExcluir.Items)
            {
                result += item.ToString() + ", ";
            }
            return result;
        }

        private void btnCadastroVolta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
