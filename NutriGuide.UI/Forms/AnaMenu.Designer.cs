namespace NutriGuide.UI.Forms
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            lstTuketilenler = new ListBox();
            lblAdSoyad = new Label();
            lblKullaniciAd = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            dtpTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userDefault;
            pictureBox1.Location = new Point(28, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 165);
            label4.Name = "label4";
            label4.Size = new Size(91, 18);
            label4.TabIndex = 4;
            label4.Text = "Tüketilenler:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calories;
            pictureBox2.Location = new Point(28, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lstTuketilenler
            // 
            lstTuketilenler.BackColor = SystemColors.Menu;
            lstTuketilenler.FormattingEnabled = true;
            lstTuketilenler.ItemHeight = 15;
            lstTuketilenler.Location = new Point(255, 165);
            lstTuketilenler.Name = "lstTuketilenler";
            lstTuketilenler.Size = new Size(220, 109);
            lstTuketilenler.TabIndex = 6;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(255, 78);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(58, 20);
            lblAdSoyad.TabIndex = 8;
            lblAdSoyad.Text = "*******";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAd.Location = new Point(264, 42);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(58, 20);
            lblKullaniciAd.TabIndex = 7;
            lblKullaniciAd.Text = "*******";
            // 
            // label3
            // 
            label3.Location = new Point(105, 12);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 10;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(167, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 41);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 12);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 11;
            label5.Text = "Alınan Kalori :";
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(140, 186);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(100, 23);
            dtpTarih.TabIndex = 12;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(566, 334);
            Controls.Add(dtpTarih);
            Controls.Add(panel1);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblKullaniciAd);
            Controls.Add(lstTuketilenler);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(737, 420);
            Name = "AnaMenu";
            Text = "AnaMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private ListBox lstTuketilenler;
        private Label lblAdSoyad;
        private Label lblKullaniciAd;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private DateTimePicker dtpTarih;
    }
}