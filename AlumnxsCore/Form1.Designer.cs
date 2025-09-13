namespace AlumnxsCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 36);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.minimize;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1125, 0);
            button3.Name = "button3";
            button3.Size = new Size(60, 36);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.maximize;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Dock = DockStyle.Right;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1185, 0);
            button2.Name = "button2";
            button2.Size = new Size(60, 36);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Close;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1245, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 36);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 5);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Alumnxs";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.accessibilitycpl_2_326;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(webView21);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 682);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Dock = DockStyle.Bottom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(3, 645);
            button4.Name = "button4";
            button4.Size = new Size(645, 34);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Top;
            webView21.Location = new Point(3, 27);
            webView21.Name = "webView21";
            webView21.Size = new Size(645, 612);
            webView21.Source = new Uri("file:///c:/progra~1/ALUMNOS/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(657, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 682);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuerpo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(642, 652);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.c78b3888b1838504e05fcdc0d25d6180;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 317);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.g55x7223b8145639n13qrxs5a289a5270;
            pictureBox3.Location = new Point(175, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 317);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.k92d4093s0867203g79kgch9x473a1392;
            pictureBox4.Location = new Point(328, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(238, 317);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1305, 718);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Alumnxs";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
