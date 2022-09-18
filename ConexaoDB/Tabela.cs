using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConexaoDB
{
    public class Tabela
    {
        public static DataTable Unidades;
        public static DataTable Responsaveis;
        public static DataTable Clientes;
        public static DataTable Equipamentos;

        public static void AtualizarUnidades()
        {
            Conexao conexao = new Conexao();
            Unidades = conexao.SqlCapturar("SELECT SIGLA,UNIDADE,UF,REGIAO " +
                "FROM UNIDADES " +
                "ORDER BY UF");
        }

        public static void AtualizarClientes()
        {
            Conexao conexao = new Conexao();
            Clientes = conexao.SqlCapturar("SELECT MATRICULA, NOME, USERID, AREA, CARGO, SIGLA_UNIDADE, PATRIMONIO " +
                "FROM CLIENTE " +
                "ORDER BY NOME");
        }
        public static void AtualizarResponsaveis()
        {
            Conexao conexao = new Conexao();
            var temp = conexao.SqlCapturar("SELECT C.NOME AS NOME, C.USERID AS USERID, C.AREA AS AREA, C.CARGO AS CARGO, " +
                "R.TELEFONECORPORATIVO AS TELEFONECORPORATIVO, R.TELEFONEPESSOAL AS TELEFONEPESSOAL, R.EMAIL AS EMAIL " +
                "FROM RESPONSAVEL R " +
                "LEFT JOIN CLIENTE C ON R.USERID_CLIENTE = C.USERID " +
                "ORDER BY C.NOME");
            temp.Columns.Add("UNIDADES", typeof(string));
            string s;
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(temp.Rows[i]["USERID"].ToString()))
                {
                    s = "";
                }
                else
                {
                    s = temp.Rows[i]["USERID"].ToString();
                }
                temp.Rows[i]["UNIDADES"] = UnidadePorResponsavel(s);
            }
            Responsaveis = temp;
        }

        public static string UnidadePorResponsavel(string userId)
        {
            Conexao conexao = new Conexao();
            DataTable ListaUnidades = new DataTable();
            string buffer = "";

            ListaUnidades = conexao.SqlCapturar("SELECT UNIDADERESPONSAVEL " +
                "FROM RELACAORESPUNI " +
                "WHERE RESPONSAVELUNIDADE = '" + userId + "'");
            for (int i = 0; i < ListaUnidades.Rows.Count; i++)
            {
                buffer += ListaUnidades.Rows[i]["UNIDADERESPONSAVEL"].ToString() + ", ";
            }
            return buffer;
        }

        public static void AtualizarEquipamentos()
        {
            Conexao conexao = new Conexao();
            Equipamentos = conexao.SqlCapturar("SELECT PATRIMONIO, STATUS, USERID, EQUIPAMENTO, SERIE, NOMENCLATURA, MODELO, MARCA, PROCESSADOR, MEMORIA, ARMAZENAMENTO " +
                "FROM EQUIPAMENTO");
        }
    }
}
