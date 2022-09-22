using ConexaoDB;
using RegrasDeNegocio;
using UI.Properties;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Conexao con = new Conexao();
                Tabela.AtualizarUnidades();
                frmLogin f = new frmLogin();
                if (Settings.Default.user == "")
                {
                    f.ShowDialog();
                    if (string.IsNullOrEmpty(Responsavel.Usuario))
                    {
                        throw new Exception("teste");
                    }
                    Settings.Default.user = Responsavel.Usuario;
                    Settings.Default.Save();
                }
                else
                {
                    Responsavel r = new Responsavel(Settings.Default.user);
                    r.Logar();
                }


                Tabela.AtualizarUnidades();
                Application.Run(new FrmInventario());
            }
            catch (Exception ex)
            {
                if (ex.Message != "teste")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}