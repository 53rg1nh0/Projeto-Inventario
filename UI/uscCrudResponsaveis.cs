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
using RegrasDeNegocio;

namespace UI
{
    public partial class uscCrudResponsaveis : UserControl
    {
        public uscCrudResponsaveis()
        {
            InitializeComponent();

            Tabela.AtualizarResponsaveis();

            dgvRsposavel.DataSource = Tabela.Responsaveis;

            lblCrudRsponsavelTitulo.Text = "Informações dos responsáveis";
            tlpCrudResposaveis.RowStyles[1].Height = 0;
            tlpCrudResposaveis.RowStyles[2].Height = 0;
        }

        private void ckbEditar_Click(object sender, EventArgs e)
        {
            if (ckbEditar.Checked)
            {
                tlpCrudResposaveis.RowStyles[1].Height = 15;
                tlpCrudResposaveis.RowStyles[2].Height = 30;
                btnEditar.Enabled = true;
            }
            else
            {
                tlpCrudResposaveis.RowStyles[1].Height = 0;
                tlpCrudResposaveis.RowStyles[2].Height = 0;
                btnEditar.Enabled = false;
            }
        }

    }
}
