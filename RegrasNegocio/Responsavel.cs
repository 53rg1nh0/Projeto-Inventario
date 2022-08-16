using System;
using System.Collections.Generic;
using ConexaoDB;
using System.Text.RegularExpressions;
using System.Data;

namespace RelacaoPespUni
{
    public class Responsavel : Cliente
    {
        public string TelefoneCorporativo { get; set; }
        public string TelefonePessoal { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public Conexao Con { get; set; }

        //construtor
        public Responsavel(string telefoneCorporativo, string telefonePessoal, string email, string userId, string senha, string tipo)
        {
            TelefoneCorporativo = telefoneCorporativo;
            TelefonePessoal = telefonePessoal;
            Email = email;
            UserId = userId;
            Senha = senha;
            Tipo = tipo;
            Con = new Conexao();
        }

        public Responsavel(string userID)
        {
            Con = new Conexao();
            DataTable t = new DataTable();
            t = Con.SqlCapturar("SELECT C.MATRICULA AS MATRICULA, C.SIGLA AS SIGLA, C.NOME AS NOME, C.AREA AS AREA, C.CARGO AS CARGO, R.SENHA AS SENHA,R.TELEFONECORPORATIVO AS TELCORP, R.TELEFONEPESSOAL AS TELPESSOAL,R.EMAIL AS EMAIL, R.TIPO AS TIPO FROM CLIENTE C INNER JOIN RESPONSAVEL R ON C.USERID = R.USERID_CLIENTE WHERE C.USERID ='" + userID + "'");
            if (t.Rows.Count != 0)
            {
                Matricula = Convert.ToInt32(t.Rows[0]["MATRICULA"]);
                Nome = t.Rows[0]["NOME"].ToString();
                UserId = userID;
                Area = t.Rows[0]["AREA"].ToString();
                Cargo = t.Rows[0]["CARGO"].ToString();
                Sigla = t.Rows[0]["SIGLA"].ToString();
                Unidade = new Unidade(Sigla);

                Senha = t.Rows[0]["SENHA"].ToString();
                TelefoneCorporativo = t.Rows[0]["TELCORP"].ToString();
                TelefonePessoal= t.Rows[0]["TELPESSOAL"].ToString();
                Email = t.Rows[0]["EMAIL"].ToString(); 
                Tipo = t.Rows[0]["TIPO"].ToString();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Usuário ou senha imcorretos!");
            }
        }


        //propriedade movimentação
    }
}
