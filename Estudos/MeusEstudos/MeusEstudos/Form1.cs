using MeusEstudos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusEstudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pessoa william = new Pessoa();
            Pessoa joao = new Gerente();

            Veiculo vei = new Carro();
            vei.Modelo = "Ferrari";
            vei.printModelo();

            joao.ID = 999;
            joao.printId();

            william.ID = 133;
            william.printId();

            geraButtons(433);
        }

        private void geraButtons(int v)
        {
            for(int i = 0; i < v; i++)
            {
                Button b = new Button();
                b.Text = "Button " + (i+1);
                b.Click += (object sender, EventArgs e) => {
                    clicou(b.Text);
                };

                corpo.Controls.Add(b);
            }
        }

        private void clicou(string text)
        {
            MessageBox.Show(text);
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("funca!!");
        }
    }
}
