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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            criaLayouts();
        }

        private void criaLayouts()
        {
            for(int i=1; i<6; i++)
            {
                FlowLayoutPanel flw = new FlowLayoutPanel();
                flw.Height = 100;
                flw.Width = container.Width;
                flw.BackColor = (i%2 == 0) ? Color.Bisque : Color.Brown;
                container.Controls.Add(flw);
            }
        }
    }
}
