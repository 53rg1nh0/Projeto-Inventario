using ConexaoDB;
using RelacaoPespUni;
using System.Data;

namespace UI
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Tabela.AtualizarUnidades();
                uscAjuste.uscCrudUnidades.dgvAlterarUnidade.DataSource = Tabela.Unidades; 
                frmLogin f = new frmLogin();
                f.ShowDialog(); 
            }
            catch (ExcessaoBanco ex)
            {
                MessageBox.Show(ex.Message, "Erro de conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Paineis(bool cl, bool eq)
        {
            pnlCliente.Visible = cl;
            pnlEquipamento.Visible = eq;
        }

        private void Paginas(Control c)
        {
            foreach (Control container in pnlBack.Controls)
            {
                if (container != c)
                {
                    container.Visible = false;
                    container.Dock = DockStyle.None;
                }

            }
            c.Visible = true;
            c.Dock = DockStyle.Fill;
        }


 
        private void btnAjustes_Click(object sender, EventArgs e)
        {

            Paineis(false, false);
            Paginas(uscAjuste);
            AnimacaoBotoes(pnlNavegacao, btnAjustes);
            btnAjustes.Image = Properties.Resources.imgAjusteEscuro;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Paineis(false, false);
            Paginas(uscSobre);
            AnimacaoBotoes(pnlNavegacao, btnSobre);
            btnSobre.Image = Properties.Resources.imgSobreEscuro;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Paineis(true, false);
        }
        private void btnNovato_Click(object sender, EventArgs e)
        {
            Paginas(uscHome);
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            Paineis(false, true);
        }


        public static void AnimacaoBotoes(Control container, Button botao)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Name.Substring(0, 3) == "btn")
                {
                    var btn = (Button)c;
                    btn.BackColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
                    btn.ForeColor = SystemColors.Control;

                    switch (btn.Name)
                    {
                        case "btnAjustes":
                            btn.Image = Properties.Resources.imgAjusteClaro;
                            break;
                        case "btnSobre":
                            btn.Image = Properties.Resources.imgSobreClaro;
                            break;
                    }

                    if (btn == botao)
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.ForeColor = SystemColors.ControlText;
                    }
                }

                if (c.Controls.Count >= 0)
                {
                    AnimacaoBotoes(c, botao);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlNavegacaoBack.Width == 180)
            {
                pnlNavegacaoBack.Width = 60;
                pnlLogo.Width = 60;
                pnlLogoSolar.Visible= false;    
                pnlTopLogo.BorderStyle = BorderStyle.None;
            }
            else
            {
                pnlNavegacaoBack.Width = 180;
                pnlLogo.Width = 180;
                pnlLogoSolar.Visible = true;
                pnlTopLogo.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}