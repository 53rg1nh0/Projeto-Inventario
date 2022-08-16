using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDB;

namespace RelacaoPespUni
{

    public class Relacao
    {
        public static string ResponsavelPorUnidade(string siglaUnidade)
        {
            Conexao conexao = new Conexao();
            DataTable ListaResponsaveis = new DataTable();
            string buffer="";

            ListaResponsaveis=conexao.SqlCapturar("SELECT C.NOME AS RESPONSÁVEIS FROM (SELECT C.NOME, R.UNIDADERESPONSAVEL FROM CLIENTE C LEFT JOIN RELACAORESPUNI R ON C.USERID = R.RESPONSAVELUNIDADE) WHERE R.UNIDADERESPONSAVEL = '" + siglaUnidade+ "'");
            for(int i =0; i < ListaResponsaveis.Rows.Count - 1; i++)
            {
                buffer += ListaResponsaveis.Rows[i]["RESPONSÁVEIS"].ToString()+", ";
            }
            return buffer;
        }

        public static string UnidadePorResponsavel(string userId)
        {
            Conexao conexao = new Conexao();
            DataTable ListaUnidades =new DataTable();
            string buffer="";

            ListaUnidades=conexao.SqlCapturar("SELECT UNIDADERESPONSAVEL FROM RELACAORESPUNI WHERE RESPONSAVELUNIDADE = '" + userId + "'");
            for (int i = 0; i < ListaUnidades.Rows.Count - 1; i++)
            {
                buffer += ListaUnidades.Rows[i]["RESPONSÁVEIS"].ToString() + ", ";
            }
            return buffer;
        }

        public static void IncerirNoBancoRespUni(string userId,string siglaUnidade)
        {
            Conexao conexao = new Conexao();
            conexao.SqlInserir("INSERT INTO RELACAORESPUNI (RESPONSAVELUNIDADE, UNIDADERESPONSAVEL) VALUES ('" + userId + "', '" + siglaUnidade + "')");
        }
    }
}
