using ProjetoTeste2017.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoTeste2017
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            buscaFotoRep();
        }

        private void buscaFotoRep()
        {
            representante repr = Form1.repLogado;

            if (repr != null)
            {
                pictureBox2.Image = (Image)Resources.ResourceManager.GetObject(repr.foto);
                ArredondaImagem.arredondar(pictureBox2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new PerfilDash().Show();
            this.Dispose(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
            contextMenuStrip1.Left = this.Width - 100;
            contextMenuStrip1.Top = pictureBox2.Top + 80;
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PerfilDash().Show();
            this.Dispose(true);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
