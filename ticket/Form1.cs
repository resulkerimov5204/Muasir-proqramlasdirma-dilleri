using System.Windows.Forms;

namespace ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sehife baglansinmi?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            comboBox1.Text = b;
            comboBox2.Text = a;
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            listBox1.Items.Add(count.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " " + tarix.Text + " " +
                saat.Text + " " + yer.Text + " " + namesurname.Text + " " + fin.Text + " " + email.Text + " " + telefon.Text);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            saat.Clear();           
            namesurname.Clear();
            fin.Clear();
            email.Clear();
            telefon.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            listBox1.Items.Clear();
        }
    }
}
