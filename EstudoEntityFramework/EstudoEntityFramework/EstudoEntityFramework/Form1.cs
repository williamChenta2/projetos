using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new EstudoEntityFrameworkEntities();

            var post = new Posts()
            {
                Body = "primeiro contato com entityFramework. mto bom",
                DataPublicacao = DateTime.Now,
                PostId = 1,
                Title = "Dia 1 - EntityFramework"
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}
