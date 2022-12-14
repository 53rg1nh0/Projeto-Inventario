using ConexaoDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegrasDeNegocio
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string UserId { get; set; }
        public int Matricula { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public Unidade Unidade { get; set; }
        public Conexao Con { get; set; }

        public Cliente() { }

        public Cliente(string userId)
        {
            try
            {
                Con = new Conexao();
                DataTable t = new DataTable();

                t = Con.SqlCapturar("SELECT MATRICULA, NOME, AREA, CARGO, SIGLA FROM CLIENTE WHERE USERID = '" + userId + "'");

                try
                {
                    Nome = t.Rows[0]["NOME"].ToString();
                    UserId = userId;
                    Matricula = Convert.ToInt32(t.Rows[0]["MATRICULA"]);
                    Area = t.Rows[0]["AREA"].ToString();
                    Cargo = t.Rows[0]["CARGO"].ToString();
                    Unidade = new Unidade(t.Rows[0]["SIGLA"].ToString());
                }
                catch
                {
                    throw new ExcessaoRegraNegocio("Usuário inexisente!");
                }
            }
            catch(ExcessaoBanco ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //equipamento

        //METODOS DE INCERÇÃO DE CLIENTE NO BANCO (ENCAPSULAMENTO)
    }
}
