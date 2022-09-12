using ConexaoDB;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Adminstrador : UserControl
    {
        public Adminstrador(string usuario)
        {
            Conexao con = new Conexao();
            DataTable dt = new DataTable();
            string nome;
            string cargo;
            string matricula;
            string telefone;
            string unidade;

            dt = con.SqlCapturar("SELECT C.MATRICULA, C.NOME, C.CARGO, C.SIGLA, R.TELEFONECORPORATIVO FROM CLIENTE C INNER JOIN RESPONSAVEL R ON C.USERID = R.USERID_CLIENTE WHERE C.USERID ='" + usuario + "'");
            InitializeComponent();
            nome = dt.Rows[0]["NOME"].ToString();
            cargo= dt.Rows[0]["CARGO"].ToString();
            matricula= dt.Rows[0]["MATRICULA"].ToString();
            telefone= dt.Rows[0]["TELEFONECORPORATIVO"].ToString();
            unidade= dt.Rows[0]["SIGLA"].ToString();

            lblAdminstradorInformacao.Text = "Responsável: " + nome + "\nCargo: " + cargo + "\nMatrícula: " + matricula + "\nTelefone: " + telefone + "\nUnidade: " + unidade;
        }

        
    }
}
