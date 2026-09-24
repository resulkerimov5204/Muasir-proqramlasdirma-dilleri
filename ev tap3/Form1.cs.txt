using System;
using System.Linq;
using System.Windows.Forms;
namespace check_usarname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Pleasse firstly click button.");
                return;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (username.Length < 8)
            {
                MessageBox.Show("Username must minimum 8 characters.");
                return;
            }
            if (username.Contains('*') || username.Contains('!') || username.Contains('@') || username.Contains('#') || username.Contains('$') || username.Contains('%') || username.Contains('^') || username.Contains('&') || username.Contains('(') || username.Contains(')') || username.Contains(' '))
            {
                MessageBox.Show("Username cannot contain special characters.");
                return;
            }
            if (!username.Any(char.IsDigit))
            {
                MessageBox.Show("Username cannot contain numbers.");
                return;
            }
            if (!username.Any(char.IsUpper))
            {
                MessageBox.Show("Username cannot contain uppercase letters.");
                return;
            }
            if (char.IsLower(username[0]))
            {
                MessageBox.Show("Username must start with an uppercase letter.");
                return;
            }
            
            else 
            {
                MessageBox.Show("Usarname added.");
                textBox1.Clear();
                return;                
            }  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
