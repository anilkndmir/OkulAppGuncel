﻿using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OkulAppSube2BIL
{
    public partial class frmOgretmenKayit : Form
    {
        public String Tc { get; set; }
        public frmOgretmenKayit()
        {
            InitializeComponent();
            btnOgrSil.Enabled = false;
            btnOgrGuncelle.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtmn = new OgretmenBL();
                bool sonuc = ogrtmn.OgretmenKaydet(new Ogretmen
                {
                    OgretmenAdi = txtAd.Text.Trim(),
                    OgretmenSoyadi = txtSoyad.Text.Trim(),
                    OgretmenTc = txtTc.Text.Trim()
                }
                );
                if (sonuc)
                {
                    MessageBox.Show("Yeni kayıt eklendi!");
                }

            }
            catch (SqlException exception)
            {
                switch (exception.Number)
                {
                    case 2627:
                        MessageBox.Show($"{txtTc} Kimlik Numaralı öğretmen zaten kayıtlı.");
                        break;
                    default:
                        MessageBox.Show("Veri Tabanı Hatası!");
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void btnOgrBul_Click(object sender, EventArgs e)
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtTc.Text = string.Empty;

            try
            {
                frmOgretmenBul ogrBul = new frmOgretmenBul(this);
                ogrBul.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("UYARI! Hata: " + ex.Message);
            }
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSil(txtTc.Text.Trim()) ? "Silme Başarılı" : "Başarısız!");
            }
            catch (Exception ex) 
            {
                throw new Exception("Hata: " + ex.Message); 
            }

        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new Ogretmen { OgretmenAdi = txtAd.Text.Trim(), OgretmenSoyadi = txtSoyad.Text.Trim(), OgretmenTc = txtTc.Text.Trim() }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");

            }
            catch (Exception ex) 
            { 
                throw new Exception("Hata: " + ex.Message); 
            }

        }
    }
}

