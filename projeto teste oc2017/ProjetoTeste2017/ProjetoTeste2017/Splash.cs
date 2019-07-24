using System;
using System.Windows.Forms;

namespace ProjetoTeste2017
{
    public partial class Splash : Form
    {
        private Timer time = new Timer();
        private int valBarr = 0;

        public Splash()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            label1.Text = "Carregando componentes...";
            InitializeMyTimer();
        }

        // Call this method from the constructor of the form.
        private void InitializeMyTimer()
        {
            // Set the interval for the timer.
            time.Interval = 500;
            // Connect the Tick event of the timer to its event handler.
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            valBarr += 3;
            // Increment the value of the ProgressBar a value of one each time.
            progressBar1.Increment(valBarr);            

            switch (valBarr)
            {
                case 3:
                    label1.Text = "Carregando dados...";
                    break;
                case 6:
                    label1.Text = "Carregando imagens...";
                    break;
                case 9:
                    label1.Text = "Iniciando Dashboard...";
                    break;
                default:
                    break;
            }

            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (progressBar1.Value == progressBar1.Maximum)
            {
                // Stop the timer.
                time.Stop();
                new Dashboard().Show();
                this.Dispose(true);
            }
                
        }
    }
}
