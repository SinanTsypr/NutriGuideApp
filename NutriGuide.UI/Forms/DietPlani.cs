using Microsoft.EntityFrameworkCore;
using NutriGuide.DataAccessLayer.Concrets;
using NutriGuide.Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGuide.UI.Forms
{
    public partial class DietPlani : Form
    {
        NutriGuideContext _db = new NutriGuideContext();
        Kullanici _kisi;
        public DietPlani(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;
            listele();
            Dongu();
            dtpBaslama.MinDate = DateTime.Now;
        }



        private void dtpBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.MinDate = dtpBaslama.Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Diyetler d1 = new Diyetler();
            d1.DiyetAdi = txtDiyetIsmi.Text;
            d1.DiyetBaslama = dtpBaslama.Value;
            d1.DiyetBitis = dtpBitis.Value;
            _kisi.Diyetler.Add(d1);
            _db.Update(_kisi);
            _db.SaveChanges();


            listele();
            Dongu();
        }
        public void Dongu()
        {
            cmbDiyetler.DataSource = null;
            cmbDiyetler.DataSource = _db.Diyetler.Where(x => x.Kullanicilar.Any(k => k.KullaniciId == _kisi.KullaniciId)).ToList();
        }
        void listele()
        {


            lstDiyetler.Items.Clear();
            lstDiyetler.Update();
            lstDiyetler.Refresh();
            var kisiKullaniciId = _kisi.KullaniciId;
            foreach (var item in _db.Diyetler.Where(x => x.Kullanicilar.Any(k => k.KullaniciId == kisiKullaniciId)))
            {
                lstDiyetler.Items.Add(item);
            }

        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            DiyetSil();
            listele();
        }





        void DiyetSil()
        {
            Diyetler diyet = lstDiyetler.SelectedItem as Diyetler;
            _db.Remove(diyet);
            _db.SaveChanges();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DiyetGuncelle();
        }
        void DiyetGuncelle()
        {
            if (lstDiyetler.SelectedIndex > -1)
            {
                Diyetler Diyet = lstDiyetler.SelectedItem as Diyetler;
                _db.Diyetler.FirstOrDefault(x => x.DiyetAdi == Diyet.DiyetAdi).DiyetAdi = txtDiyetIsmi.Text;
                _db.SaveChanges();
                listele();

            }


        }
    }
}
