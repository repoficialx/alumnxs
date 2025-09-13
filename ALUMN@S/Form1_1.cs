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

namespace ALUMN_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximo tamaño alcanzado.", "alumn@s", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                this.BackColor = SystemColors.ControlText;
                appTitle.ForeColor = SystemColors.Control;
            }
            else if (this.BackColor == SystemColors.ControlText)
            {
                this.BackColor = SystemColors.Control;
                appTitle.ForeColor = SystemColors.ControlText;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NUEV_().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SOBRE().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("c:\\progra~1\\ALUMNOS\\"))
            {
                Directory.CreateDirectory("c:\\progra~1\\ALUMNOS\\");
                webBrowser1.Refresh();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
