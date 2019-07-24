using ProjetoTeste2017.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoTeste2017
{
    public partial class Form1 : Form
    {
        oc2017Entities db = new oc2017Entities();
        public static representante repLogado = null;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                representante repr = db.representante.Where(rep => rep.email.Equals(textBox1.Text)).FirstOrDefault();

                if (repr != null)
                {
                    pictureBox1.Image = (Image)Resources.ResourceManager.GetObject(repr.foto);
                }
                else
                {
                    MessageBox.Show("Representante não encontrado!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            representante repr = db.representante.Where(rep => 
                rep.email.Equals(textBox1.Text) && rep.senha.Equals(textBox2.Text))
                .FirstOrDefault();

            if (repr != null)
            {
                repLogado = repr;
                this.Dispose(false);
                new Splash().Show();
            }
            else
            {
                MessageBox.Show("Login incorreto!");
            }
        }
    }
}
