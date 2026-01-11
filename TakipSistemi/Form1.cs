using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakipSistemi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odevler yeniOdev = new Odevler();
            yeniOdev.DersAdi = cmbDersAdi.SelectedItem.ToString();
            yeniOdev.OdevBaslik = txtOdevBaslik.Text;
            yeniOdev.OdevKonusu = rtbOdevKonusu.Text;
            yeniOdev.TeslimTarihi = dtpTeslimTarihi.Value;

            TakipSistemiEntities1 vt = new TakipSistemiEntities1();
            vt.Odevler.Add(yeniOdev);
            int sonuc = vt.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Ödev kaydedildi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ödev kaydedilemedi!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TakipSistemiEntities1 vt = new TakipSistemiEntities1();

                
                var odevler = vt.Odevler.Select(o => new
                {
                    o.Odevid,
                    o.DersAdi,
                    o.OdevBaslik,
                    o.OdevKonusu,
                    o.TeslimTarihi
                }).ToList();

                dgvOdevler.DataSource = odevler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOdevler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek için bir ödev seçin!");
                    return;
                }

                int secilenID = Convert.ToInt32(dgvOdevler.SelectedRows[0].Cells["Odevid"].Value);

                TakipSistemiEntities1 vt = new TakipSistemiEntities1();
                Odevler silinecekOdev = vt.Odevler.FirstOrDefault(o => o.Odevid == secilenID);

                if (silinecekOdev != null)
                {
                    vt.Odevler.Remove(silinecekOdev);
                    int sonuc = vt.SaveChanges();

                    if (sonuc > 0)
                        MessageBox.Show("Ödev silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ödev silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                    button3.PerformClick();
                }
                else
                {
                    MessageBox.Show("Ödev bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.ToString());
            }
        }
    }
}
