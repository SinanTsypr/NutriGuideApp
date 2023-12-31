﻿namespace NutriGuide.UI.Forms
{
    partial class DietPlani
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
            dtpBaslama = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            lstDiyetler = new ListBox();
            cmbDiyetler = new ComboBox();
            label3 = new Label();
            txtDiyetIsmi = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 49);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 0;
            label1.Text = "Başlama Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 112);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 1;
            label2.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslama
            // 
            dtpBaslama.CustomFormat = "ddd dd MMM yyyy";
            dtpBaslama.Format = DateTimePickerFormat.Short;
            dtpBaslama.Location = new Point(531, 43);
            dtpBaslama.Name = "dtpBaslama";
            dtpBaslama.Size = new Size(147, 26);
            dtpBaslama.TabIndex = 2;
            dtpBaslama.ValueChanged += dtpBaslama_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.CustomFormat = "ddd dd MMM yyyy";
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(531, 106);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(147, 26);
            dtpBitis.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(53, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 46);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(53, 241);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(106, 46);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(53, 311);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(106, 46);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lstDiyetler
            // 
            lstDiyetler.FormattingEnabled = true;
            lstDiyetler.ItemHeight = 18;
            lstDiyetler.Location = new Point(222, 165);
            lstDiyetler.Name = "lstDiyetler";
            lstDiyetler.Size = new Size(456, 202);
            lstDiyetler.TabIndex = 7;
            // 
            // cmbDiyetler
            // 
            cmbDiyetler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiyetler.FormattingEnabled = true;
            cmbDiyetler.Location = new Point(115, 104);
            cmbDiyetler.Name = "cmbDiyetler";
            cmbDiyetler.Size = new Size(210, 26);
            cmbDiyetler.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 109);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 9;
            label3.Text = "Diyetler:";
            // 
            // txtDiyetIsmi
            // 
            txtDiyetIsmi.Location = new Point(115, 49);
            txtDiyetIsmi.Name = "txtDiyetIsmi";
            txtDiyetIsmi.Size = new Size(210, 26);
            txtDiyetIsmi.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 52);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 11;
            label4.Text = "Diyet Ismi";
            // 
            // DietPlani
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 253, 207);
            ClientSize = new Size(720, 381);
            Controls.Add(label4);
            Controls.Add(txtDiyetIsmi);
            Controls.Add(label3);
            Controls.Add(cmbDiyetler);
            Controls.Add(lstDiyetler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslama);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DietPlani";
            Text = "DietPlani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpBaslama;
        private DateTimePicker dtpBitis;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private ListBox lstDiyetler;
        private ComboBox cmbDiyetler;
        private Label label3;
        private TextBox txtDiyetIsmi;
        private Label label4;
    }
}