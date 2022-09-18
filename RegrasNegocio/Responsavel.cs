using System;
using System.Collections.Generic;
using ConexaoDB;
using System.Text.RegularExpressions;
using System.Data;
using System.Net.Mail;
using System.Threading;
using System.Windows;
using System.Drawing;
using System.Linq;

namespace RegrasDeNegocio
{
    public class Responsavel : Cliente
    {
        public static string Usuario;
        public static string Local;
        public static int TotalEquipamentos;
        public static int TotalBakupNotebook;
        public static int TotalBackupDesktop;

        public string TelefoneCorporativo { get; set; }
        public string TelefonePessoal { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public Conexao Con { get; private set; }

        //construtor
        public Responsavel(string telefoneCorporativo, string telefonePessoal, string email, string userId, string senha)
        {
            TelefoneCorporativo = telefoneCorporativo;
            TelefonePessoal = telefonePessoal;
            Email = email;
            UserId = userId;
            Senha = senha;
            Tipo = "std";
            Con = new Conexao();
        }

        public Responsavel(string userID)

        {
            Con = new Conexao();
            DataTable t = new DataTable();

            t = Con.SqlCapturar("SELECT C.MATRICULA AS MATRICULA, C.SIGLA AS SIGLA, C.NOME AS NOME, C.AREA AS AREA, C.CARGO AS CARGO, " +
                "R.SENHA AS SENHA,R.TELEFONECORPORATIVO AS TELCORP, R.TELEFONEPESSOAL AS TELPESSOAL,R.EMAIL AS EMAIL, R.TIPO AS TIPO " +
                "FROM CLIENTE C INNER JOIN RESPONSAVEL R ON C.USERID = R.USERID_CLIENTE WHERE C.USERID ='" + userID + "'");

            if (t.Rows.Count != 0 && !ReferenceEquals(t, null))
            {
                Matricula = Convert.ToInt32(t.Rows[0]["MATRICULA"]);
                Nome = t.Rows[0]["NOME"].ToString();
                UserId = userID;
                Area = t.Rows[0]["AREA"].ToString();
                Cargo = t.Rows[0]["CARGO"].ToString();
                Unidade = new Unidade(t.Rows[0]["SIGLA"].ToString());

                Senha = t.Rows[0]["SENHA"].ToString();
                TelefoneCorporativo = t.Rows[0]["TELCORP"].ToString();
                TelefonePessoal = t.Rows[0]["TELPESSOAL"].ToString();
                Email = t.Rows[0]["EMAIL"].ToString();
                Tipo = t.Rows[0]["TIPO"].ToString();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Usuário ou senha imcorretos!");
            }
        }

        public static string Autenticar(string email)
        {
            string senha = SenhaTemporaria();
            new Thread(Menssagem).Start();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("serginhoagostinho@gmail.com", "ojhjaiztpweaxqjt");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress("serginhoagostinho@gmail.com", "INVENTÁRIO TI (Código para auteração de senha)");
            mensagem.To.Add(new MailAddress("serginhoagostinho@gmail.com"));

            mensagem.Subject = "Alterar senha Sistema Inventário TI";
            mensagem.Body = "Para verifiar sua identidade, use o código: \n" + senha;

            mensagem.IsBodyHtml = true;

            client.Send(mensagem);
            return senha;
        }

        private static void Menssagem()
        {
            MessageBox.Show("Enviado e-mail com código para alteração de senha!");
        }

        private static string SenhaTemporaria()
        {
            string chars = @"abcdefghjkmnpqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVYWXZ023456789!@#$%¨&*";
            string pass = "";
            Random random = new Random();
            for (int f = 0; f < 8; f++)
            {
                pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }
            return pass;
        }

        public void IncerirNoBanco()
        {
            try
            {
                Con.SqlInserir("INSERT INTO RESPONSAVEL (USERID_CLIENTE, TELEFONECORPORATIVO, TELEFONEPESSOAL,EMAIL,TIPO,SENHA) " +
                    "VALUES ('" + UserId + "', '" + TelefoneCorporativo + "', '" + TelefonePessoal + "', '" + Email + "', '" + Tipo + "', '" + Senha + "')");
                Tabela.AtualizarResponsaveis();
            }
            catch
            {
                throw new ExcessaoRegraNegocio("Cadastro não foi bem sucedido, pois responsável já está cadastrado!");
            }
        }
        //propriedade movimentação
        public void Logar()
        {
            Tabela.AtualizarEquipamentos();

            Usuario = UserId;
            Local = Unidade.Nome;
            TotalEquipamentos = Tabela.Equipamentos.AsEnumerable().Count(c => c.Field<string>("NOMENCLATURA").Substring(0, 3) == "IGT");

            TotalBakupNotebook = Tabela.Equipamentos.AsEnumerable().Count(c => c.Field<string>("NOMENCLATURA").Substring(0, 3) == "IGT"
            && c.Field<string>("STATUS") == "backup" && c.Field<string>("EQUIPAMENTO") == "Notebook");

            TotalBackupDesktop = Tabela.Equipamentos.AsEnumerable().Count(c => c.Field<string>("NOMENCLATURA").Substring(0, 3) == "IGT"
            && c.Field<string>("STATUS") == "backup" && c.Field<string>("EQUIPAMENTO") == "Desktop");
        }

        public static void Deslogar()
        {
            Usuario = "";
            Local = "";
            TotalEquipamentos = 0;
            TotalBakupNotebook = 0;
            TotalBackupDesktop = 0;
        }
    }
}
