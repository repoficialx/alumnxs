using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlumnxsCore
{
    public partial class nuevx : Form
    {
        public nuevx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] archivo =
                {
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>",
                "<persona>",
                $"<nombre>{textBox1.Text}</nombre>",
                $"<nacimiento>{maskedTextBox1.Text}</nacimiento>",
                $"<tel>{maskedTextBox2.Text}</tel>",
                $"<email>{textBox3.Text}</email>",
                $"<genero>{comboBox1.Text}</genero>",
                $"<objetivos>{textBox4.Text}</objetivos>",
                $"<medidas>{textBox5.Text}</medidas>",
                textBox7.Text,
                "</persona>"
            };
            File.WriteAllLines(
                $"C:\\Progra~1\\Alumnos\\{textBox1.Text}.txt", archivo);
        }
    }
}
