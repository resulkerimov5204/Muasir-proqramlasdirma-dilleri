namespace ticket
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            yer = new NumericUpDown();
            saat = new MaskedTextBox();
            tarix = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            groupBox2 = new GroupBox();
            telefon = new MaskedTextBox();
            fin = new MaskedTextBox();
            email = new TextBox();
            namesurname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yer).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 85);
            label1.TabIndex = 2;
            label1.Text = "BEU Travel";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(556, -38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(266, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 65, 0);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 100);
            panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 64);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Location = new Point(667, 71);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 2;
            button3.Text = "Çıx";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(12, 71);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 1;
            button2.Text = "Siyahıdan sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(yer);
            groupBox1.Controls.Add(saat);
            groupBox1.Controls.Add(tarix);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marşrut";
            // 
            // yer
            // 
            yer.Location = new Point(88, 196);
            yer.Name = "yer";
            yer.Size = new Size(120, 23);
            yer.TabIndex = 10;
            // 
            // saat
            // 
            saat.Location = new Point(88, 151);
            saat.Mask = "00:00";
            saat.Name = "saat";
            saat.Size = new Size(121, 23);
            saat.TabIndex = 9;
            saat.ValidatingType = typeof(DateTime);
            // 
            // tarix
            // 
            tarix.Location = new Point(88, 111);
            tarix.Mask = "00/00/0000";
            tarix.Name = "tarix";
            tarix.Size = new Size(121, 23);
            tarix.TabIndex = 8;
            tarix.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "BEU", "Xırdalan", "Masazır", "Sumqayıq", "Binəqədi", "Biləcəri", "Lökbatan", "20 Yanvar", "Digər..." });
            comboBox2.Location = new Point(88, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BEU", "Xırdalan", "Masazır", "Sumqayıq", "Binəqədi", "Biləcəri", "Lökbatan", "20 Yanvar", "Digər..." });
            comboBox1.Location = new Point(88, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 198);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 5;
            label6.Text = "Yer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 159);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 114);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Tarix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Haradan:";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 64, 0);
            button4.Location = new Point(235, 30);
            button4.Name = "button4";
            button4.Size = new Size(29, 62);
            button4.TabIndex = 0;
            button4.Text = "<\r\n\r\n>";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(telefon);
            groupBox2.Controls.Add(fin);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(namesurname);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(452, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 240);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin məlumatları";
            // 
            // telefon
            // 
            telefon.Location = new Point(130, 114);
            telefon.Mask = "(999) 000-0000";
            telefon.Name = "telefon";
            telefon.Size = new Size(151, 23);
            telefon.TabIndex = 11;
            // 
            // fin
            // 
            fin.Location = new Point(130, 72);
            fin.Name = "fin";
            fin.Size = new Size(151, 23);
            fin.TabIndex = 10;
            // 
            // email
            // 
            email.Location = new Point(130, 156);
            email.Name = "email";
            email.Size = new Size(151, 23);
            email.TabIndex = 9;
            // 
            // namesurname
            // 
            namesurname.Location = new Point(130, 27);
            namesurname.Name = "namesurname";
            namesurname.Size = new Size(151, 23);
            namesurname.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 162);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 7;
            label10.Text = "Gmail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 119);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 6;
            label9.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 77);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 5;
            label8.Text = "FIN kod:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 30);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 4;
            label7.Text = "Ad və Soyad:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(84, 211);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 0;
            button1.Text = "Bilet al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox1;
        private Button button4;
        private GroupBox groupBox2;
        private Button button1;
        private MaskedTextBox saat;
        private MaskedTextBox tarix;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown yer;
        private MaskedTextBox telefon;
        private MaskedTextBox fin;
        private TextBox email;
        private TextBox namesurname;
        private ListBox listBox1;
    }
}
