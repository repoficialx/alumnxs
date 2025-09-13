using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ALUMN_S
{
    public partial class NUEV_ : Form
    {
        public NUEV_()
        {
            InitializeComponent();
        }

        private void NUEV__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateXML($"{º.Text}\nMedidas: {textBox2.Text}\nCorreo: {textBox1.Text}\nObjetivos: {textBox3.Text}\nGénero: {comboBox1.Text}\nfecha de nacimiento: {maskedTextBox1.Text}\nnumero de telefono: {maskedTextBox2}\nobservaciones medicas: {textBox5.Text}", º.Text + ".txt", "C:\\Progra~1\\Alumnos\\");
            
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
