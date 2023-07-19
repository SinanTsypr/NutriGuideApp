using Microsoft.EntityFrameworkCore;
using NutriGuide.DataAccessLayer.Concrets;
using NutriGuide.Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGuide.UI.Forms
{
    public partial class Besinler : Form
    {
        Kullanici _kisi;



        NutriGuideContext _db = new NutriGuideContext();
        public Besinler(Kullanici kisi)
        {
            InitializeComponent();
            _kisi = kisi;
            Dongu();
            DiyetYemekleriniListele();
            DiyetlereYemekEkle();
            KaloriGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Diyetler d1 = _db.Diyetler.Find(((Diyetler)cmbDiyetler.SelectedItem).Id);

            var sorgu = _db.Foods.Where(x => x.Diyetler.Any(s => s.Id == ((Diyetler)cmbDiyetler.SelectedItem).Id));

            if (sorgu.Contains((Food)dgvYemekler.SelectedRows[0].DataBoundItem) == false)
            {
                d1.Foods.Add((Food)dgvYemekler.SelectedRows[0].DataBoundItem);
                _db.Update(d1);
                _db.SaveChanges();
                DiyetlereYemekEkle();
            }
            else
            {
                MessageBox.Show("Seçili Diyette Daha önceden eklenmiştir");
                return;
            }
            KaloriGuncelle();
        }

        private void KaloriGuncelle()
        {
            double toplamKalori = 0;
            double karbonhidrat = 0;
            double protein = 0;
            double yag = 0;
            foreach (DataGridViewRow row in dgvDiyetYemekleri.Rows)
            {
                if (row.DataBoundItem is Food food)
                {
                    toplamKalori += food.Kalorisi;
                    karbonhidrat += food.KarbonhidratMiktari;
                    protein += food.ProteinMiktari;
                    yag += food.YagMiktari;
                }
            }
            lblToplamKalori.Text = toplamKalori.ToString();
            lblKarbonhidrat.Text = string.Format("{0:0.##}", karbonhidrat);
            lblProtein.Text = string.Format("{0:0.##}", protein);
            lblYag.Text = string.Format("{0:0.##}", yag);
        }


        private void btnCikar_Click(object sender, EventArgs e)
        {
            Diyetler d1 = _db.Diyetler.Find(((Diyetler)cmbDiyetler.SelectedItem).Id);

            var sorgu = _db.Foods.Where(x => x.Diyetler.Any(s => s.Id == ((Diyetler)cmbDiyetler.SelectedItem).Id));
            if (dgvDiyetYemekleri.SelectedRows.Count != 0)
            {
                if (sorgu.Contains((Food)dgvDiyetYemekleri.SelectedRows[0].DataBoundItem) == true)
                {
                    var selectedFood = (Food)dgvDiyetYemekleri.SelectedRows[0].DataBoundItem;
                    var existingDiet = _db.Diyetler.Include(d => d.Foods).FirstOrDefault(d => d.Id == ((Diyetler)cmbDiyetler.SelectedItem).Id);

                    if (existingDiet != null)
                    {
                        if (existingDiet.Foods.Contains(selectedFood))
                        {
                            existingDiet.Foods.Remove(selectedFood);
                            _db.SaveChanges();
                            MessageBox.Show("Seçili Yemek Silinmiştir");
                            DiyetlereYemekEkle();
                        }
                        else
                        {
                            MessageBox.Show("Seçili Yemek Bulunamamıştır");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Listeden Yemek Seçiniz");
            }
            

            KaloriGuncelle();
        }

        public void Dongu()
        {
            cmbDiyetler.DataSource = null;
            cmbDiyetler.DataSource = _db.Diyetler.Where(x => x.Kullanicilar.Any(k => k.KullaniciId == _kisi.KullaniciId)).ToList();
        }
        public void DiyetlereYemekEkle()
        {
            if (cmbDiyetler.SelectedIndex > -1)
            {
                dgvDiyetYemekleri.DataSource = null;
                dgvDiyetYemekleri.DataSource = _db.Foods.Where(x => x.Diyetler.Any(k => k.Kullanicilar.Any(s => s.KullaniciId == _kisi.KullaniciId)) && x.Diyetler.Any(k => k.DiyetAdi == ((Diyetler)cmbDiyetler.SelectedItem).DiyetAdi)).ToList();
            }

        }
        public void DiyetYemekleriniListele()
        {
            dgvYemekler.DataSource = null;
            dgvYemekler.DataSource = _db.Foods.ToList();
        }

        private void cmbDiyetler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiyetlereYemekEkle();
            KaloriGuncelle();
        }
    }
}
