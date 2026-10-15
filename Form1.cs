using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImtahanSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            toolTip1.SetToolTip(txtSdf1, "SDF1 imtahanı: 0-10 bal");
            toolTip1.SetToolTip(txtSdf2, "SDF2 imtahanı: 0-10 bal");
            toolTip1.SetToolTip(txtFf, "FF imtahanı: 0-10 bal");
            toolTip1.SetToolTip(txtSeminar, "Seminar imtahanı: 0-20 bal");
            toolTip1.SetToolTip(txtFinal, "Final (SSİ) imtahanı: 0-50 bal");

            
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
        }

        private void btnNetice_Click(object sender, EventArgs e)
        {
            
            bool bosVar = false;
            TextBox[] xanalar = { txtSdf1, txtSdf2, txtFf, txtSeminar, txtFinal, txtAd, txtNomre };
            foreach (TextBox xana in xanalar)
            {
                if (xana.Text.Trim() == "")
                {
                    errorProvider1.SetError(xana, "Bu xana boş ola bilməz");
                    bosVar = true;
                }
                else
                {
                    errorProvider1.SetError(xana, "");
                }
            }
            if (bosVar)
            {
                return;
            }

           
            string nomre = txtNomre.Text.Trim();
            if (nomre.Length != 9 || !long.TryParse(nomre, out long nomreReqem))
            {
                MessageBox.Show("Tələbə nömrəsi yanlışdır");
                return;
            }

            
            int sdf1;
            int sdf2=0;
            int ff=0;
            int seminar=0;
            int final=0;
            bool duzgun = int.TryParse(txtSdf1.Text, out sdf1)
                       && int.TryParse(txtSdf2.Text, out sdf2)
                       && int.TryParse(txtFf.Text, out ff)
                       && int.TryParse(txtSeminar.Text, out seminar)
                       && int.TryParse(txtFinal.Text, out final);
            if (!duzgun)
            {
                MessageBox.Show("Qiymətləndirmə yanlış aparılmışdır");
                return;
            }

            if (sdf1 < 0 || sdf1 > 10 || sdf2 < 0 || sdf2 > 10 || ff < 0 || ff > 10
                || seminar < 0 || seminar > 20 || final < 0 || final > 50)
            {
                MessageBox.Show("Qiymətləndirmə yanlış aparılmışdır");
                return;
            }

           
            int girisBali = sdf1 + sdf2 + ff + seminar;
            int netice = girisBali + final;

            
            string kateqorya;
            if (netice < 51 || final < 17)
                kateqorya = "F";   
            else if (netice >= 91)
                kateqorya = "A";
            else if (netice >= 81)
                kateqorya = "B";
            else if (netice >= 71)
                kateqorya = "C";
            else if (netice >= 61)
                kateqorya = "D";
            else
                kateqorya = "E";

           
            dataGridView1.Rows.Add(txtAd.Text.Trim(), nomre, girisBali, final, netice, kateqorya);

           
            notifyIcon1.BalloonTipTitle = "Proqram bildirişi";
            notifyIcon1.BalloonTipText = "Tələbənin məlumatları sistemə əlavə edildi";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(8000);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSdf1.Clear();
            txtSdf2.Clear();
            txtFf.Clear();
            txtSeminar.Clear();
            txtFinal.Clear();
            txtAd.Clear();
            txtNomre.Clear();
            errorProvider1.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;   
            base.OnFormClosing(e);
        }

        private void txtSdf1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
