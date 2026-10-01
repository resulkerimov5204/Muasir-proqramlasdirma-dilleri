namespace caffee_system
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>
        {
            { "Şokoladlı tort", 5.00m },
            { "Coca-Cola", 2.00m },
            { "Buzlu çay", 3.00m },
            { "Burger", 4.50m },
            { "Sendviç", 3.50m },
            { "Pizza", 6.00m },
            { "Muffin", 2.50m },
            { "Hot-dog", 3.00m },
            { "Peçenye", 1.50m }
        };
        private decimal totalAmount = 0.00m;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e) => SebeteElaveEt("Şokoladlı tort");
        private void pictureBox3_Click(object sender, EventArgs e) => SebeteElaveEt("Coca-Cola");
        private void pictureBox4_Click(object sender, EventArgs e) => SebeteElaveEt("Buzlu çay");
        private void pictureBox5_Click(object sender, EventArgs e) => SebeteElaveEt("Burger");
        private void pictureBox6_Click(object sender, EventArgs e) => SebeteElaveEt("Sendviç");
        private void pictureBox7_Click(object sender, EventArgs e) => SebeteElaveEt("Pizza");
        private void pictureBox8_Click(object sender, EventArgs e) => SebeteElaveEt("Muffin");
        private void pictureBox9_Click(object sender, EventArgs e) => SebeteElaveEt("Hot-dog");
        private void pictureBox10_Click(object sender, EventArgs e) => SebeteElaveEt("Peçenye");
        private void SebeteElaveEt(string itemName)
        {
            listBox1.Items.Add(itemName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Zəhmət olmasa, silmək istədiyiniz məhsulu seçin.", "bildiriris", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            string selectedItem = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            MessageBox.Show($"{selectedItem} səbətdən silindi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult netice = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (netice == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                totalAmount = 0.00m;
                MessageBox.Show("Səbət sıfırlandı.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbət boşdur. Ödəniş etmək üçün məhsul əlavə edin.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal yekunMebleg = 0.00m;

            foreach (string item in listBox1.Items)
            {
                if (menuItems.ContainsKey(item))
                {
                    yekunMebleg += menuItems[item];
                }
            }
            textBox1.Text = yekunMebleg.ToString("0.00") + " AZN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Zəhmət olmasa, ödəniş etmədən əvvəl məhsulları səbətə əlavə edin.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(textBox1.Text.Replace(" AZN", ""), out decimal odenisMeblegi))
            {
                MessageBox.Show("Zəhmət olmasa, düzgün ödəniş məbləği daxil edin.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal hesablananMebleg = 0.00m;

            if (decimal.TryParse(textBox2.Text, out decimal daxilEdilenMebleg))
            {
                hesablananMebleg = daxilEdilenMebleg - odenisMeblegi;
                if (hesablananMebleg < 0)
                {
                    MessageBox.Show("Zəhmət olmasa, ödəniş məbləğini düzgün daxil edin. Məbləğ çatışmır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textBox3.Text = hesablananMebleg.ToString("0.00") + " AZN";
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa, düzgün ödəniş məbləği daxil edin.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimal qaliqMebleg = daxilEdilenMebleg - odenisMeblegi;
                textBox3.Text = qaliqMebleg.ToString("0.00") + " AZN";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
