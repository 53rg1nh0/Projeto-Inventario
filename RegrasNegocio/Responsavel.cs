using System;
using System.Collections.Generic;
using ConexaoDB;
using System.Text.RegularExpressions;
using System.Data;
using System.Net.Mail;
using System.Threading;
using System.Windows;

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
                Unidade = new Unidade(t.Rows[0]["SIGLA"].ToString());

                Senha = t.Rows[0]["SENHA"].ToString();
                TelefoneCorporativo = t.Rows[0]["TELCORP"].ToString();
                TelefonePessoal= t.Rows[0]["TELPESSOAL"].ToString();
                Email = t.Rows[0]["EMAIL"].ToString(); 
                Tipo = t.Rows[0]["TIPO"].ToString();
            }
            else
            {
                throw new ExcessaoRegraNegocio("Usu�rio ou senha imcorretos!");
            }
        }

        public static void Autenticar(string email)
        {
            new Thread(Menssagem).Start();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("serginhoagostinho@gmail.com", "fiwomfoxiakcjecn");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress("sesousa@solarbr.com.br", "INVENT�RIO TI");
            mensagem.To.Add(new MailAddress(email));

            mensagem.Subject = "Alterar senha Sistema Invent�rio TI";
            mensagem.Body = SenhaTemporaria();

            mensagem.IsBodyHtml = true;

            client.Send(mensagem);
            
        }

        private static void Menssagem()
        {
            MessageBox.Show("Enviado e-mail com senha tempor�ria para altera��o!");
        }

        private static string SenhaTemporaria()
        {
            string chars = @"abcdefghjkmnpqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVYWXZ023456789!@#$%�&*";
            string pass = "";
            Random random = new Random();
            for (int f = 0; f < 8; f++)
            {
                pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }
            return pass;
        }
        //propriedade movimenta��o
    }
}
