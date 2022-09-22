using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows;
using DataTable = System.Data.DataTable;

namespace ConexaoDB
{
    public class Conexao
    {
        private const string caminhoBancoDeDados = @"C:\Users\sergi\OneDrive\Área de Trabalho\Inventario - Copia - Copia.accdb";
        private const string conString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+ caminhoBancoDeDados;

        bool timeOut = true;
        public OleDbConnection Con { get; set; }

        public Conexao()
        {
            try
            {
                Con = new OleDbConnection(conString);
            }
            catch (ExcessaoBanco)
            {
                throw new Exception("Erro ao conectar o Banco de Dados!");
            }
            
        }

        public void SqlInserir(string sqlComand)
        {
            using (Con)
            {
                OleDbCommand Comandos = new OleDbCommand(sqlComand, Con);
                Con.Open(); 
                try
                {
                    Comandos.ExecuteNonQuery();
                }
                catch (ExcessaoBanco)
                {
                    throw new ExcessaoBanco("Erro ao incerir os dados!");
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();    
                    }
                }
            }
        }

        public DataTable SqlCapturar(string sqlComand)
        {
            using (Con)
            {     
                try
                {
                    new Thread(TempoEstouro).Start();
                    OleDbCommand Comandos = new OleDbCommand(sqlComand, Con);
                    DataTable dt = new DataTable();
                    OleDbDataAdapter adp = new OleDbDataAdapter(Comandos);
                    adp.Fill(dt);
                    timeOut = false;
                    return dt;
                }
                catch (ExcessaoBanco)
                {
                    timeOut = false;
                    throw new ExcessaoBanco("Erro ao capturar os dados!");

                }
                catch (OleDbException)
                {
                    timeOut=false;
                    throw new ExcessaoBanco("Erro ao conectar o Banco de Dados! Verifique se está conectado na rede local da empresa.Caso não conecte a VPN!");
                }
                finally
                {
                    if(Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }

        }

        private void TempoEstouro()
        {
            Thread.Sleep(5000);
            if (timeOut)
            {
            
                //throw new ExcessaoBanco("Erro ao conectar o Banco de Dados! Verifique se está conectado na rede local da empresa.Caso não conecte a VPN!");

            }
        }

    }
}
