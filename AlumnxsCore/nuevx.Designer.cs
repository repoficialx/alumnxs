namespace AlumnxsCore
{
    partial class nuevx
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label8 = new Label();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Nacimiento:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "E-Mail:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Objetivos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 8;
            label5.Text = "Medidas:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(137, 293);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 101);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 293);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 12;
            label7.Text = "Obs. Médicas";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(112, 45);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(91, 82);
            maskedTextBox2.Mask = "+34 000 000 000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(150, 31);
            maskedTextBox2.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 85);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 15;
            label8.Text = "Teléfono:";
            // 
            // button1
            // 
            button1.Location = new Point(74, 418);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 17;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 18;
            label6.Text = "Género:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Femenino", "Masculino", "No binario", "Agénero", "Otro" });
            comboBox1.Location = new Point(91, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 33);
            comboBox1.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(102, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // nuevx
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 467);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(label8);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "nuevx";
            Text = "Añadir a una nueva persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox7;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label8;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox5;
    }
}