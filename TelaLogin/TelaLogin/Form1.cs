using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.Properties;

/**
 * https://stackoverflow.com/questions/43881939/copy-to-output-directory-in-visual-studio-2017
 * 
 * pesquisar por "output directory c# visual studio 2017"
 * https://stackoverflow.com/questions/10827024/copying-visual-studio-project-files-to-output-directory-during-build
 */

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
            pessoas.Add(new Pessoa(1, "william chenta", "will", "123"));
            pessoas.Add(new Pessoa(2, "joão", "jao", "456"));
            imgPessoa.Image = (Image) Resources.ResourceManager.GetObject("pessoa");
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String senha = txtSenha.Text;

            if(vLogin(login, senha)) {
                MessageBox.Show("Logado com sucesso!!");
            } else
            {
                MessageBox.Show("Login inválido!!");
            }
        }

        private Boolean vLogin(String login, String senha)
        {
            Boolean logou = false;

            pessoas.ForEach(p =>
            {
                if (p.login == login && p.senha == senha)
                {
                    logou = true;
                }
            });

            return logou;
        }
    }
}
