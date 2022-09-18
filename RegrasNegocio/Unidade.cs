using ConexaoDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace RegrasDeNegocio
{
    public class Unidade
    {

        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public string Estado { get; private set; }
        public string Regiao { get; private set; }
        public Conexao Con { get; private set; }


        public Unidade(string sigla, string nome, string estado, string regiao)
        {
            string padraoSigla = "[A-Z]{3}";
            string padraoEstado = "[A-Z]{2}";

            Con = new Conexao();
            if (Regex.IsMatch(sigla, padraoSigla) && sigla.Length == 3)
            {
                Sigla = sigla;
            }
            else
            {
                throw new ExcessaoRegraNegocio("Sigla deve conter apenas três letras maiúscula!");
            }

            if (nome != "")
            {
                Nome = nome;
            }
            else
            {
                throw new ExcessaoRegraNegocio("Campos vazios não permitidos");
            }

            if (Regex.IsMatch(estado, padraoEstado) && estado.Length == 2)
            {
                Estado = estado;
            }
            else
            {
                throw new ExcessaoRegraNegocio("UF deve conter apenas duas Letras maúsculas!");
            }

            if (regiao != "")
            {
                Regiao = regiao;
            }
            else
            {
                throw new ExcessaoRegraNegocio("Campos vazios não permitidos!");
            }
        }

        public Unidade(string sigla)
        {

            Con = new Conexao();
            DataTable t = new DataTable();
            t = Con.SqlCapturar("SELECT REGIAO, UF, UNIDADE FROM UNIDADES WHERE SIGLA ='" + sigla + "'");
            if (t.Rows.Count == 1)
            {
                Sigla = sigla;
                Nome = t.Rows[0]["UNIDADE"].ToString();
                Estado = t.Rows[0]["UF"].ToString();
                Regiao = t.Rows[0]["REGIAO"].ToString();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Unidade não cadastrada. Quebra de banco!");
            }

        }

        public void IncerirNoBanco()
        {
            Tabela.AtualizarUnidades();
            DataRow[] linhaSIgla = Tabela.Unidades.Select("Sigla= '" + Sigla + "'");
            DataRow[] linhaUnidade = Tabela.Unidades.Select("Unidade= '" + Nome + "'");

            if (linhaSIgla.Length == 0 && linhaUnidade.Length == 0)
            {
                Con.SqlInserir("INSERT INTO UNIDADES (REGIAO, UF, UNIDADE,SIGLA) VALUES ('" + Regiao + "', '" + Estado + "', '" + Nome + "', '" + Sigla + "')");
                Tabela.AtualizarUnidades();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Não pode ser adicionado uma mesma unidade!");
            }
        }

        public void EditarNoBanco(string condicao, int linha)
        {
            Tabela.AtualizarUnidades();
            Tabela.Unidades.Rows.RemoveAt(linha);
            DataRow[] linhaSIgla = Tabela.Unidades.Select("Sigla= '" + Sigla + "'");
            DataRow[] linhaUnidade = Tabela.Unidades.Select("Unidade= '" + Nome + "'");

            if (linhaSIgla.Length == 0 && linhaUnidade.Length == 0)
            {
                Tabela.AtualizarUnidades();
                Con.SqlInserir("UPDATE UNIDADES SET REGIAO = '" + Regiao + "', UF = '" + Estado + "', UNIDADE = '" + Nome + "', SIGLA = '" + Sigla + "' WHERE SIGLA = '" + condicao + "'");
                Tabela.AtualizarUnidades();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Não pode ser adicionado uma mesma unidade!");
            }
        }

        public void RemoverNoBanco(string condicao)
        {
            Tabela.AtualizarUnidades();
            Con.SqlInserir("DELETE FROM UNIDADES WHERE SIGLA = '" + condicao + "'");
            Tabela.AtualizarUnidades();
        }
    }
}
