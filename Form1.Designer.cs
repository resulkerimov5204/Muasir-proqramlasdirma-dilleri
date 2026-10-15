namespace ImtahanSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslig = new System.Windows.Forms.Label();
            this.lblSdf1 = new System.Windows.Forms.Label();
            this.lblSdf2 = new System.Windows.Forms.Label();
            this.lblFf = new System.Windows.Forms.Label();
            this.lblSeminar = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtSdf1 = new System.Windows.Forms.TextBox();
            this.txtSdf2 = new System.Windows.Forms.TextBox();
            this.txtFf = new System.Windows.Forms.TextBox();
            this.txtSeminar = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblNomre = new System.Windows.Forms.Label();
            this.txtNomre = new System.Windows.Forms.TextBox();
            this.btnNetice = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKateqorya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslig
            // 
            this.lblBaslig.AutoSize = true;
            this.lblBaslig.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblBaslig.Location = new System.Drawing.Point(440, 25);
            this.lblBaslig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslig.Name = "lblBaslig";
            this.lblBaslig.Size = new System.Drawing.Size(334, 39);
            this.lblBaslig.TabIndex = 0;
            this.lblBaslig.Text = "İMTAHAN SİSTEMİ";
            // 
            // lblSdf1
            // 
            this.lblSdf1.AutoSize = true;
            this.lblSdf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSdf1.ForeColor = System.Drawing.Color.White;
            this.lblSdf1.Location = new System.Drawing.Point(27, 135);
            this.lblSdf1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdf1.Name = "lblSdf1";
            this.lblSdf1.Size = new System.Drawing.Size(62, 20);
            this.lblSdf1.TabIndex = 1;
            this.lblSdf1.Text = "SDF1:";
            // 
            // lblSdf2
            // 
            this.lblSdf2.AutoSize = true;
            this.lblSdf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSdf2.ForeColor = System.Drawing.Color.White;
            this.lblSdf2.Location = new System.Drawing.Point(27, 197);
            this.lblSdf2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdf2.Name = "lblSdf2";
            this.lblSdf2.Size = new System.Drawing.Size(62, 20);
            this.lblSdf2.TabIndex = 2;
            this.lblSdf2.Text = "SDF2:";
            // 
            // lblFf
            // 
            this.lblFf.AutoSize = true;
            this.lblFf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFf.ForeColor = System.Drawing.Color.White;
            this.lblFf.Location = new System.Drawing.Point(27, 258);
            this.lblFf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFf.Name = "lblFf";
            this.lblFf.Size = new System.Drawing.Size(37, 20);
            this.lblFf.TabIndex = 3;
            this.lblFf.Text = "FF:";
            // 
            // lblSeminar
            // 
            this.lblSeminar.AutoSize = true;
            this.lblSeminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeminar.ForeColor = System.Drawing.Color.White;
            this.lblSeminar.Location = new System.Drawing.Point(27, 320);
            this.lblSeminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeminar.Name = "lblSeminar";
            this.lblSeminar.Size = new System.Drawing.Size(84, 20);
            this.lblSeminar.TabIndex = 4;
            this.lblSeminar.Text = "Seminar:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinal.ForeColor = System.Drawing.Color.White;
            this.lblFinal.Location = new System.Drawing.Point(27, 382);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(56, 20);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Final:";
            // 
            // txtSdf1
            // 
            this.txtSdf1.Location = new System.Drawing.Point(133, 133);
            this.txtSdf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSdf1.Name = "txtSdf1";
            this.txtSdf1.Size = new System.Drawing.Size(79, 22);
            this.txtSdf1.TabIndex = 0;
            this.txtSdf1.TextChanged += new System.EventHandler(this.txtSdf1_TextChanged);
            // 
            // txtSdf2
            // 
            this.txtSdf2.Location = new System.Drawing.Point(133, 194);
            this.txtSdf2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSdf2.Name = "txtSdf2";
            this.txtSdf2.Size = new System.Drawing.Size(79, 22);
            this.txtSdf2.TabIndex = 1;
            // 
            // txtFf
            // 
            this.txtFf.Location = new System.Drawing.Point(133, 256);
            this.txtFf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFf.Name = "txtFf";
            this.txtFf.Size = new System.Drawing.Size(79, 22);
            this.txtFf.TabIndex = 2;
            // 
            // txtSeminar
            // 
            this.txtSeminar.Location = new System.Drawing.Point(133, 318);
            this.txtSeminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeminar.Name = "txtSeminar";
            this.txtSeminar.Size = new System.Drawing.Size(79, 22);
            this.txtSeminar.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(133, 379);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(79, 22);
            this.txtFinal.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.lblNomre);
            this.groupBox1.Controls.Add(this.txtNomre);
            this.groupBox1.Controls.Add(this.btnNetice);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(240, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tələbə məlumatları";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAd.Location = new System.Drawing.Point(20, 37);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(99, 18);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad və soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(20, 68);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(225, 22);
            this.txtAd.TabIndex = 5;
            // 
            // lblNomre
            // 
            this.lblNomre.AutoSize = true;
            this.lblNomre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomre.Location = new System.Drawing.Point(20, 117);
            this.lblNomre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomre.Name = "lblNomre";
            this.lblNomre.Size = new System.Drawing.Size(124, 18);
            this.lblNomre.TabIndex = 6;
            this.lblNomre.Text = "Tələbə nömrəsi";
            // 
            // txtNomre
            // 
            this.txtNomre.Location = new System.Drawing.Point(20, 148);
            this.txtNomre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomre.Name = "txtNomre";
            this.txtNomre.Size = new System.Drawing.Size(225, 22);
            this.txtNomre.TabIndex = 6;
            // 
            // btnNetice
            // 
            this.btnNetice.BackColor = System.Drawing.Color.Green;
            this.btnNetice.Location = new System.Drawing.Point(20, 222);
            this.btnNetice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNetice.Name = "btnNetice";
            this.btnNetice.Size = new System.Drawing.Size(107, 37);
            this.btnNetice.TabIndex = 7;
            this.btnNetice.Text = "Nəticə";
            this.btnNetice.UseVisualStyleBackColor = false;
            this.btnNetice.Click += new System.EventHandler(this.btnNetice_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Firebrick;
            this.btnTemizle.Location = new System.Drawing.Point(140, 222);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 37);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Təmizlə";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAd,
            this.colNomre,
            this.colGiris,
            this.colSsi,
            this.colNetice,
            this.colKateqorya});
            this.dataGridView1.Location = new System.Drawing.Point(533, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(747, 345);
            this.dataGridView1.TabIndex = 9;
            // 
            // colAd
            // 
            this.colAd.HeaderText = "Ad və soyad";
            this.colAd.MinimumWidth = 6;
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Width = 125;
            // 
            // colNomre
            // 
            this.colNomre.HeaderText = "Tələbə nömrəsi";
            this.colNomre.MinimumWidth = 6;
            this.colNomre.Name = "colNomre";
            this.colNomre.ReadOnly = true;
            this.colNomre.Width = 125;
            // 
            // colGiris
            // 
            this.colGiris.HeaderText = "Giriş balı";
            this.colGiris.MinimumWidth = 6;
            this.colGiris.Name = "colGiris";
            this.colGiris.ReadOnly = true;
            this.colGiris.Width = 125;
            // 
            // colSsi
            // 
            this.colSsi.HeaderText = "SSİ";
            this.colSsi.MinimumWidth = 6;
            this.colSsi.Name = "colSsi";
            this.colSsi.ReadOnly = true;
            this.colSsi.Width = 125;
            // 
            // colNetice
            // 
            this.colNetice.HeaderText = "Nəticə";
            this.colNetice.MinimumWidth = 6;
            this.colNetice.Name = "colNetice";
            this.colNetice.ReadOnly = true;
            this.colNetice.Width = 125;
            // 
            // colKateqorya
            // 
            this.colKateqorya.HeaderText = "Kateqorya";
            this.colKateqorya.MinimumWidth = 6;
            this.colKateqorya.Name = "colKateqorya";
            this.colKateqorya.ReadOnly = true;
            this.colKateqorya.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1307, 492);
            this.Controls.Add(this.lblBaslig);
            this.Controls.Add(this.lblSdf1);
            this.Controls.Add(this.lblSdf2);
            this.Controls.Add(this.lblFf);
            this.Controls.Add(this.lblSeminar);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.txtSdf1);
            this.Controls.Add(this.txtSdf2);
            this.Controls.Add(this.txtFf);
            this.Controls.Add(this.txtSeminar);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslig;
        private System.Windows.Forms.Label lblSdf1;
        private System.Windows.Forms.Label lblSdf2;
        private System.Windows.Forms.Label lblFf;
        private System.Windows.Forms.Label lblSeminar;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtSdf1;
        private System.Windows.Forms.TextBox txtSdf2;
        private System.Windows.Forms.TextBox txtFf;
        private System.Windows.Forms.TextBox txtSeminar;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblNomre;
        private System.Windows.Forms.TextBox txtNomre;
        private System.Windows.Forms.Button btnNetice;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiris;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKateqorya;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
