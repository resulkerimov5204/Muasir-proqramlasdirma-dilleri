using Microsoft.VisualBasic;

namespace gullu
{
    public partial class Form1 : Form
    {

        private decimal toplamgelir = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("say ve qiymet bos ola bolmez");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int say) || say <= 0)
            {
                MessageBox.Show("say musbet eded olmalidir");
                textBox1.Focus();
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal qiymet) || qiymet <= 0)
            {
                MessageBox.Show("qiymet musbet eded olmalidir");
                textBox2.Focus();
                return;
            }

            decimal gelir = say * qiymet;

            dataGridView1.Rows.Add(comboBox1.Text, say.ToString("F2"), qiymet.ToString("F2"), gelir.ToString("F2"));

            toplamgelir += gelir;
            label2.Text = toplamgelir.ToString("F2");

            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();

            comboBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("cixis edilsinmi", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
