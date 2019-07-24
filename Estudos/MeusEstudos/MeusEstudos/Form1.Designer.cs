namespace MeusEstudos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cabecalho = new System.Windows.Forms.FlowLayoutPanel();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.corpo = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabecalho
            // 
            this.cabecalho.BackColor = System.Drawing.Color.Tomato;
            this.cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabecalho.Location = new System.Drawing.Point(0, 0);
            this.cabecalho.Name = "cabecalho";
            this.cabecalho.Size = new System.Drawing.Size(551, 165);
            this.cabecalho.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Tan;
            this.menu.Controls.Add(this.button1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 165);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(235, 322);
            this.menu.TabIndex = 1;
            // 
            // corpo
            // 
            this.corpo.AutoScroll = true;
            this.corpo.BackColor = System.Drawing.Color.White;
            this.corpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo.Location = new System.Drawing.Point(235, 165);
            this.corpo.Name = "corpo";
            this.corpo.Size = new System.Drawing.Size(316, 322);
            this.corpo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 487);
            this.Controls.Add(this.corpo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.cabecalho);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cabecalho;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.FlowLayoutPanel corpo;
        private System.Windows.Forms.Button button1;
    }
}

