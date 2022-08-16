using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDB;
using RelacaoPespUni;

namespace UI
{
    public partial class uscCrudUnidades : UserControl
    {
        private string condicao = "";
        private int linha = 0;
        public uscCrudUnidades()
        {
            InitializeComponent();
            lblTitulo.Text = "Unidades Existentes";
            tlpCrudUnidade.RowStyles[1].Height = 0;
            tlpCrudUnidade.RowStyles[2].Height = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ApertarBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ApertarBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ApertarBotoes();
        }

        private void ckbAdicionar_Click(object sender, EventArgs e)
        {
            SelecionarCaixa(true, false, false, ckbAdicionar.Checked);
        }

        private void ckbExcluir_Click(object sender, EventArgs e)
        {
            SelecionarCaixa(false, true, false, ckbExcluir.Checked);
        }

        private void ckbEditar_Click(object sender, EventArgs e)
        {
            SelecionarCaixa(false, false, true, ckbEditar.Checked);
        }

        private void dgvAlterarUnidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ckbAdicionar.Checked)
            {
                txbCrudSigla.Text = dgvAlterarUnidade.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbUnidade.Text = dgvAlterarUnidade.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbUf.Text = dgvAlterarUnidade.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbRegiao.Text = dgvAlterarUnidade.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private int ProcuraLinhaNoDgv(string s, int numColunaProcurada)
        {
            for (int i = 0; i < dgvAlterarUnidade.RowCount; i++)
            {
                if (s == dgvAlterarUnidade.Rows[i].Cells[numColunaProcurada].Value.ToString())
                {
                    condicao = s;
                    linha = i;
                    return i;
                }
            }
            return -1;
        }

        private void ckbAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdicionar.Checked)
            {
                lblTitulo.Text = "Adicionar unidades não existente ao Banco de Dados";
            }
        }

        private void ckbExcluir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbExcluir.Checked)
            {
                lblTitulo.Text = "Excluir unidade no Banco de Dados";
            }

        }
        private void ckbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEditar.Checked)
            {
                lblTitulo.Text = "Editar unidade no Banco de Dados";
            }
        }
        private void SelecionarCaixa(bool a, bool b, bool c, bool d)
        {
            if (d)
            {
                Controles(a, b, c);
                tlpCrudUnidade.RowStyles[1].Height = 15;
                tlpCrudUnidade.RowStyles[2].Height = 31;

                txbCrudSigla.Text = "";
                txbUnidade.Text = "";
                txbUf.Text = "";
                txbRegiao.Text = "";
            }
            else
            {
                Controles(false, false, false);
                tlpCrudUnidade.RowStyles[1].Height = 0;
                tlpCrudUnidade.RowStyles[2].Height = 0;
            }

        }
        private void Controles(bool a, bool b, bool c)
        {
            ckbAdicionar.Checked = a;
            ckbExcluir.Checked = b;
            ckbEditar.Checked = c;

            btnAdicionar.Enabled = a;
            btnExcluir.Enabled = b;
            btnEditar.Enabled = c;

            if (!a && !b && !c)
            {
                lblTitulo.Text = "Unidades Existentes";
            }
            if (a || b || c)
            {
                Tabela.AtualizarUnidades();
                int linhas;

                dgvAlterarUnidade.DataSource = Tabela.Unidades;

                linhas = dgvAlterarUnidade.Rows.Count;

                if (!ckbAdicionar.Checked)
                {
                    string[] sigla = Tabela.Unidades
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("SIGLA"))
                    .ToArray();
                    string[] unidade = Tabela.Unidades
                   .AsEnumerable()
                   .Select<System.Data.DataRow, String>(x => x.Field<String>("UNIDADE"))
                   .ToArray();

                    txbCrudSigla.AutoCompleteCustomSource.AddRange(sigla);
                    txbUnidade.AutoCompleteCustomSource.AddRange(unidade);

                    txbUnidade.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txbUnidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                    txbCrudSigla.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txbCrudSigla.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
                else
                {
                    txbCrudSigla.AutoCompleteCustomSource.Clear();
                    txbUnidade.AutoCompleteCustomSource.Clear();
                }

                string[] uf = Tabela.Unidades
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("UF"))
                    .ToArray();
                string[] regiao = Tabela.Unidades
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("REGIAO"))
                    .ToArray();

                txbUf.AutoCompleteCustomSource.AddRange(uf);
                txbRegiao.AutoCompleteCustomSource.AddRange(regiao);

                txbUf.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbUf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                txbRegiao.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbRegiao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                
            }
        }

        private void ApertarBotoes()
        {
            try
            {
                Tabela.AtualizarUnidades();
                Unidade uni = new Unidade(txbCrudSigla.Text, txbUnidade.Text, txbUf.Text, txbRegiao.Text);
                if (ckbAdicionar.Checked)
                {
                    uni.IncerirNoBanco();
                }
                if (ckbEditar.Checked)
                {
                    uni.EditarNoBanco(condicao, linha);
                }
                if (ckbExcluir.Checked)
                {
                    uni.RemoverNoBanco(condicao);
                }
                txbCrudSigla.Text = "";
                txbUnidade.Text = "";
                txbUf.Text = "";
                txbRegiao.Text = "";
                MessageBox.Show("Operação realizada com sucesso!");
                dgvAlterarUnidade.DataSource = Tabela.Unidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txbCrudSigla_KeyUp(object sender, KeyEventArgs e)
        {
            if (!ckbAdicionar.Checked)
            {
                try
                {
                    Tabela.AtualizarUnidades();
                    dgvAlterarUnidade.DataSource = Tabela.Unidades;


                    if (e.KeyCode == Keys.Enter)
                    {
                        int i = ProcuraLinhaNoDgv(txbCrudSigla.SelectedText, 0);
                        if (i > 0)
                        {
                            txbUnidade.Text = dgvAlterarUnidade.Rows[i].Cells[1].Value.ToString();
                            txbUf.Text = dgvAlterarUnidade.Rows[i].Cells[2].Value.ToString();
                            txbRegiao.Text = dgvAlterarUnidade.Rows[i].Cells[3].Value.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }
    }
}
