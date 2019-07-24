using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste2017
{
    class ArredondaImagem
    {
        public static void arredondar(PictureBox pictureBox)
        {
            /*
             *  https://stackoverflow.com/questions/7731855/rounded-edges-in-picturebox-c-sharp
             */

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }
    }
}
