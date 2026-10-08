namespace bki
{
    public partial class Form1 : Form
    {
        int sekilindex = 0;

        Image[] insansekilleri;

        public Form1()
        {
            InitializeComponent();

            insansekilleri = new Image[]
            {
                Image.FromFile("insan1.png"),
                Image.FromFile("insan2.png"),
                Image.FromFile("insan3.png"),
                Image.FromFile("insan4.png"),
                Image.FromFile("insan5.png"),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            double boy;
            double kilo;

            if (!double.TryParse(textBox1.Text, out kilo) || !double.TryParse(textBox2.Text, out boy))
            {
                MessageBox.Show("Çəkini düzgün daxil edin!", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(textBox2.Text, out boy))
            {
                MessageBox.Show("Boyu düzgün daxil edin!", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kilo <= 0 || boy <= 0)
            {
                MessageBox.Show("Boy və çəki sıfırdan böyük olmalıdır!", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kilo > 500)
            {
                MessageBox.Show("Çəki 500 kq-dan böyük ola bilməz!", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (boy > 300)
            {
                MessageBox.Show("Boy 3 metrdən böyük ola bilməz!", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (boy > 3)
            {
                boy = boy / 100;
            }




            
            double bki = kilo / (boy * boy);

            label3.Text = "Bədən Kütlə İndeksi: " + bki.ToString("0.00");

            if (bki < 18.5)
            {
                label3.Text = "Nəticə: Aşağı çəki";
                sekilindex = 0;
            }
            else if (bki >= 18.5 && bki < 25)
            {
                label3.Text = "Nəticə: Normal çəki";
                sekilindex = 1;
            }
            else if (bki >= 25 && bki < 30)
            {
                label3.Text = "Nəticə: Artıq çəki";
                sekilindex = 2;
            }
            else if (bki >= 30 && bki < 35)
            {
                label3.Text = "Nəticə: I dərəcəli piylənmə";
                sekilindex = 3;
            }else
            {
                label3.Text = "Nəticə: III dərəcəli piylənmə";
                sekilindex = 4;
            }


            pictureBox1.Image = insansekilleri[sekilindex];

            sekilindex++;
            if (sekilindex >= insansekilleri.Length)
            {
                sekilindex = 0;

            }
        }
    }
}
