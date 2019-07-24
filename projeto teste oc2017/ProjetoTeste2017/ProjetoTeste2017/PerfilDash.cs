using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjetoTeste2017
{
    public partial class PerfilDash : ProjetoTeste2017.Dashboard
    {
        public PerfilDash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("teste: " + Directory.GetCurrentDirectory());
        }
    }
}
