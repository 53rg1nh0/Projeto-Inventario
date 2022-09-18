using RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class ucsHome : UserControl
    {
        public ucsHome()
        {
            InitializeComponent();
        }

        private void ucsHome_Load(object sender, EventArgs e)
        {
            Responsavel logado = new Responsavel(Responsavel.Usuario);
            lblHomeLogado.Text = 
                  "Unidade:   " + Responsavel.Local +
                "\nResponsável:   " + logado.Nome +
                "\nCargo:   " + logado.Cargo + " de " + logado.Area+
                "\nTelefone:   " + logado.TelefoneCorporativo;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Responsavel.Deslogar();
            Settings.Default.user = "";
            Settings.Default.Save();
            Application.Restart();
        }
    }
}
