using System;
using System.Windows.Forms;
using System.Linq;

namespace ProjetoTeste2017
{
    public partial class Perfil : Form
    {
        oc2017Entities db = new oc2017Entities();

        public Perfil()
        {
            InitializeComponent();            
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.repLogado.nome;
            carregaPais();            
        }

        private void carregaPais()
        {
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = db.pais.ToList();
        }

        private void carregaEstado()
        {
            if (!String.IsNullOrEmpty(comboBox1.SelectedValue.ToString()))
            {
                int id = (int)comboBox1.SelectedValue;
                comboBox2.DisplayMember = "nome";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = db.estado.Where(est => est.id_pais == id).ToList();
            }
        }

        private void carregaCidade()
        {
            if (!String.IsNullOrEmpty(comboBox2.SelectedValue.ToString()))
            {
                int id = (int)comboBox2.SelectedValue;
                comboBox3.DisplayMember = "nome";
                comboBox3.ValueMember = "id";
                comboBox3.DataSource = db.cidade.Where(c => c.id_estado == id).ToList();
            }
        }

        private void Perfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new Form1().Show();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            carregaEstado();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            carregaCidade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("teste");
        }
    }
}
