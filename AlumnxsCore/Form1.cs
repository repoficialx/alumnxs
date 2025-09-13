namespace AlumnxsCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new nuevx().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newdirifnotdir("C:\\Progra~1\\Alumnos\\");
        }
        bool checkdir(string path)
        {
            return Directory.Exists(path);
        }
        int newdirifnotdir(string path)
        {
            if (!checkdir(path))
            {
                Directory.CreateDirectory(path);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
