using System.Reflection.Emit;
using System.Windows.Forms;

namespace xirdala
{
    public partial class Form1 : Form
    {

        private readonly Int128[] nominals = { 500, 200, 100, 50, 20, 10, 5, 1 };

        private PictureBox[] pictures;
        private System.Windows.Forms.Label[] countLabels;



        public Form1()
        {
            InitializeComponent();


            pictures = new PictureBox[]
                {
                pictureBox8,
                pictureBox7,
                pictureBox6,
                pictureBox5,
                pictureBox4,
                pictureBox3,
                pictureBox2,
                pictureBox1
                };


            countLabels = new System.Windows.Forms.Label[]
                {
                label9,
                label8,
                label7,
                label6,
                label5,
                label4,
                label3,
                label2
                };

            HideAllBanknotes();
        }


        private void HideAllBanknotes()
        {
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i].Visible = false;
                countLabels[i].Visible = false;
                countLabels[i].Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Please enter a valid amount.");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            if (!Int128.TryParse(textBox1.Text, out Int128 amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer amount.");
                return;
            }
            

            if (amount <= 0)
            {
                MessageBox.Show("The amount is zero. No banknotes to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HideAllBanknotes();

            for (int i = 0; i < nominals.Length; i++)
            {
                Int128 count = amount / nominals[i];
                if (count > 0)
                {
                    pictures[i].Visible = true;
                    countLabels[i].Visible = true;
                    countLabels[i].Text = count.ToString();
                    amount -= count * nominals[i];
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Please enter a valid amount.");
            }

        }
    }
}

