namespace NutriGuide.UI.Forms
{
    partial class Besinler
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
            cmbDiyetler = new ComboBox();
            lblToplamKalori = new Label();
            btnEkle = new Button();
            btnCikar = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblProtein = new Label();
            lblYag = new Label();
            lblKarbonhidrat = new Label();
            dgvYemekler = new DataGridView();
            dgvDiyetYemekleri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiyetYemekleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Diyetler:";
            // 
            // cmbDiyetler
            // 
            cmbDiyetler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiyetler.FormattingEnabled = true;
            cmbDiyetler.Location = new Point(90, 33);
            cmbDiyetler.Name = "cmbDiyetler";
            cmbDiyetler.Size = new Size(197, 28);
            cmbDiyetler.TabIndex = 1;
            cmbDiyetler.SelectedIndexChanged += cmbDiyetler_SelectedIndexChanged;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(155, 97);
            lblToplamKalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(51, 20);
            lblToplamKalori.TabIndex = 4;
            lblToplamKalori.Text = "label4";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(423, 142);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 35);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Yemek Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(572, 142);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(108, 35);
            btnCikar.TabIndex = 6;
            btnCikar.Text = "Yemek Çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Toplam Kalori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 8;
            label3.Text = "Alacağı Miktar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 142);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Karbonhidrat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 142);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 10;
            label6.Text = "Yağ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(329, 142);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 11;
            label7.Text = "Protein";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(329, 177);
            lblProtein.Margin = new Padding(4, 0, 4, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(39, 20);
            lblProtein.TabIndex = 14;
            lblProtein.Text = "*****";
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Location = new Point(263, 177);
            lblYag.Margin = new Padding(4, 0, 4, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(39, 20);
            lblYag.TabIndex = 13;
            lblYag.Text = "*****";
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Location = new Point(155, 177);
            lblKarbonhidrat.Margin = new Padding(4, 0, 4, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(39, 20);
            lblKarbonhidrat.TabIndex = 12;
            lblKarbonhidrat.Text = "*****";
            // 
            // dgvYemekler
            // 
            dgvYemekler.AllowUserToAddRows = false;
            dgvYemekler.AllowUserToDeleteRows = false;
            dgvYemekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYemekler.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Dock = DockStyle.Bottom;
            dgvYemekler.Location = new Point(0, 203);
            dgvYemekler.MultiSelect = false;
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.ReadOnly = true;
            dgvYemekler.RowHeadersVisible = false;
            dgvYemekler.RowTemplate.Height = 25;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(721, 178);
            dgvYemekler.TabIndex = 15;
            // 
            // dgvDiyetYemekleri
            // 
            dgvDiyetYemekleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiyetYemekleri.Location = new Point(329, 12);
            dgvDiyetYemekleri.MultiSelect = false;
            dgvDiyetYemekleri.Name = "dgvDiyetYemekleri";
            dgvDiyetYemekleri.RowTemplate.Height = 25;
            dgvDiyetYemekleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiyetYemekleri.Size = new Size(380, 118);
            dgvDiyetYemekleri.TabIndex = 16;
            // 
            // Besinler
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 191, 224);
            ClientSize = new Size(721, 381);
            Controls.Add(dgvDiyetYemekleri);
            Controls.Add(dgvYemekler);
            Controls.Add(lblProtein);
            Controls.Add(lblYag);
            Controls.Add(lblKarbonhidrat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCikar);
            Controls.Add(btnEkle);
            Controls.Add(lblToplamKalori);
            Controls.Add(cmbDiyetler);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Besinler";
            Text = "Besinler";
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiyetYemekleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDiyetler;
        private Label lblToplamKalori;
        private Button btnEkle;
        private Button btnCikar;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblProtein;
        private Label lblYag;
        private Label lblKarbonhidrat;
        private DataGridView dgvYemekler;
        private DataGridView dgvDiyetYemekleri;
    }
}