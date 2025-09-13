using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnxs48.mls
{
    public partial class langselector : Form
    {
        public bool UserSelectedLanguage { get; private set; }
        public langselector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mls.langload.SL(langload.lang.en_US);
            UserSelectedLanguage = true;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mls.langload.SL(langload.lang.es_ES);
            UserSelectedLanguage = true;
            Close();
        }
    }
}
