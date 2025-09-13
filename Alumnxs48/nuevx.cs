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

namespace Alumnxs48
{
    public partial class nuevx : Form
    {
        public nuevx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateXML($"" +
                $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\r\n" +
                $"<Persona>\r\n" +
                $"  <Nombre>{º.Text}</Nombre>\r\n" +
                $"  <Notas3>{textBox2.Text}</Notas3>\r\n" +
                $"  <Email>{textBox1.Text}</Email\r\n" +
                $"  <Notas1>{textBox3.Text}</Notas1>\r\n" +
                $"  <Género>{comboBox1.Text}</Género>\r\n" +
                $"  <Nacimiento>{maskedTextBox1.Text}</Nacimiento>\r\n" +
                $"  <Numtel>{maskedTextBox2.Text}</Numtel>\r\n" +
                $"  <Notas2>{textBox5.Text}</Notas2>\r\n" +
                $"</Persona>", º.Text + ".txt", "%LocalAppData%\\Alumnxs\\Dir");

        }
        public static void CreateXML(string contentxml, string xmlnamefile, string path)
        {
            //string path = @"c:\temp\MyTest.txt";

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path + xmlnamefile))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(contentxml);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
