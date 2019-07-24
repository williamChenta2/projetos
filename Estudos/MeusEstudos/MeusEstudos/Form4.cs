using MeusEstudos.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusEstudos
{
    public partial class Form4 : Form
    {
        testeEntities en = new testeEntities();
        public Form4()
        {
            InitializeComponent();
            btnArquivo.Click += selecionarArquivo;
            fileDialog.FileOk += salvarFotoBanco;

            btnCarregar.Click += carregaFoto;
        }

        private void carregaFoto(object sender, EventArgs e)
        {
            pessoa p = en.pessoa.Find(15);
            picFoto.Image = Arquivos.byteArrayToImage(p.foto2);
        }

        private void salvarFotoBanco(object sender, CancelEventArgs e)
        {
            pessoa p = new pessoa();
            try
            {
                p.nome = "William Chenta";
                p.idade = 33;

                byte[] bytes = Arquivos.imageToByteArray(new Bitmap(fileDialog.FileName));
                p.foto2 = bytes;
                en.pessoa.Add(p);
                en.SaveChanges();
                MessageBox.Show("Salvo com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void selecionarArquivo(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }
    }
}
