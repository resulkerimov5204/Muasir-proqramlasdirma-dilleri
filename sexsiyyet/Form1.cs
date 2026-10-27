namespace sexsiyyet
{
    public partial class Form1 : Form
    {
        int progress = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text) ||
        string.IsNullOrWhiteSpace(textBox5.Text) ||
        string.IsNullOrWhiteSpace(textBox7.Text) ||
        string.IsNullOrWhiteSpace(textBox8.Text) ||
        string.IsNullOrWhiteSpace(textBox6.Text) ||
        string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox9.Text) ||
        string.IsNullOrWhiteSpace(textBox10.Text) ||
        string.IsNullOrWhiteSpace(textBox11.Text) ||
        string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("Bütün xanaları doldurun!");
                return;
            }
            else
            {

                label1.Text = textBox3.Text;
                label2.Text = textBox4.Text;
                label3.Text = textBox5.Text;
                label4.Text = textBox7.Text;
                label5.Text = textBox8.Text;
                label6.Text = textBox6.Text;
                label7.Text = textBox1.Text;
                label8.Text = textBox2.Text;
                label9.Text = textBox9.Text;
                label10.Text = textBox10.Text;
                label11.Text = textBox11.Text;
                label12.Text = textBox12.Text;




                progress = 0;
                progressBar1.Value = 0;


                timer1.Start();



            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 5;

            if (progress > 100)
            {
                timer1.Stop();
                progress = 100;
            }

            progressBar1.Value = progress;

            if (progress >= 100)
            {
                progress = 100;
                timer1.Stop();

                MessageBox.Show("Process completed!");
            }
            progressBar1.Value = progress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }
    }
}
