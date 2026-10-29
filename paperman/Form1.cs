namespace paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sv.FileName = "Document" + count + ".txt";
            sv.ShowDialog();
            File.Create(sv.FileName).Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            op.ShowDialog();
            if (op.FileName != "")
            {

                File.AppendAllText(op.FileName, richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("No file selected.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            op.ShowDialog();
            if (op.FileName != "")
            {

                richTextBox1.Text = File.ReadAllText(op.FileName);
            }
            else
            {
                MessageBox.Show("No file selected.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            op.ShowDialog();
            if (op.FileName == "")
            {

                MessageBox.Show("No file selected.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this file?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    File.Delete(op.FileName);
                    MessageBox.Show("File deleted successfully.");
                }
            }
        }
    }
}
