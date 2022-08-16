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
    public partial class frmCadastro : Form
    {
        public DataTable Unidades { get; set; }
        public frmCadastro(DataTable unidades)
        {
            Unidades= unidades; 
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            Animacao.Arrastar(this);
            ucsCadastro.cbxCadastroIncluir.DataSource = Unidades;
            //ucsCadastro.cbxCadastroIncluir.DisplayMember = "Unidade";
            ucsCadastro.cbxCadastroIncluir.ValueMember = "SIGLA";
            ucsCadastro.cbxCadastroIncluir.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

    }
}
