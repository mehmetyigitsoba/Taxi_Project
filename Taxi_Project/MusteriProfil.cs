using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAXI_PROJECT;

namespace Taxi_Project
{
    public partial class MusteriProfil : Form
    {
        DatabaseContext db;
        Musteri musteri = new Musteri();
        Randevu randevu = new Randevu();
        public static int Tutar = 0;
        
        
        public MusteriProfil()
        {
            InitializeComponent();
            
            
            db = new DatabaseContext();
            IlceDoldur(Form1.MusteriIlId);
        }

        private void MusteriProfil_Shown(object sender, EventArgs e)
        {
            musteri = db.Musteris.Find(Form1.MusteriId);
          
            if (musteri == null)
            {
                DialogResult result = MessageBox.Show("Giriş Yapınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
            lbl_id.Text = Convert.ToString(musteri.Id);
            lbl_name.Text = musteri.Isim;
            lbl_il.Text = musteri.İl;
            lbl_ilce.Text = musteri.ilce;
            lbl_semt.Text = musteri.semt;
            lbl_mah.Text = musteri.mahalle;
            lbl_tc.Text = musteri.TC;
           


        }


        private void IlceDoldur(int Ilid)
        {
            var ilceler = db.Ilces.Where(i => i.IlId == Ilid).ToList();

            cmb_ilce_1.DataSource = ilceler;
            cmb_ilce_1.DisplayMember = "Isim";
            cmb_ilce_1.ValueMember = "Id";
        }

        private void cmb_ilce_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Ilce)cmb_ilce_1.SelectedItem).Id;

            SemtDoldur(id);
        }
        private void SemtDoldur(int Ilceid)
        {
            var semtler = db.Semts.Where(i => i.IlceId == Ilceid).ToList();

            cmb_semt_1.DataSource = semtler;
            cmb_semt_1.DisplayMember = "Isim";
            cmb_semt_1.ValueMember = "Id";
        }
        private void MahalleDoldur(int Semtid)
        {
            var mahalleler = db.Mahalles.Where(i => i.SemtId == Semtid).ToList();

            cmb_mahalle_1.DataSource = mahalleler;
            cmb_mahalle_1.DisplayMember = "Isim";
            cmb_mahalle_1.ValueMember = "Id";
        }

        private void cmb_semt_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Semt)cmb_semt_1.SelectedItem).Id;

            MahalleDoldur(id);
        }

        
        private void OdemeYap()
        {
            randevu.hesapTutari = 0;
            int ilceIndex = musteri.IlceId- ((Ilce)cmb_ilce_1.SelectedItem).Id;
            int semtIndex = musteri.SemtId- ((Semt)cmb_semt_1.SelectedItem).Id;
            int mahalleIndex = musteri.MahalleId- ((Mahalle)cmb_mahalle_1.SelectedItem).Id;
            if( ilceIndex!= 0)
            {
                if (ilceIndex >= 0)
                {
                    randevu.hesapTutari = ilceIndex * 300;
                }
                else
                {
                    randevu.hesapTutari = ilceIndex * -300;
                }
            }
            else
            {
                 if (semtIndex != 0)
                {
                    if (semtIndex >= 0)
                    {
                        randevu.hesapTutari = semtIndex * 100;
                    }
                    else
                    {
                        randevu.hesapTutari = semtIndex * -100;
                    }
                }
                else 
                {
                    if (mahalleIndex >= 0)
                    {
                        randevu.hesapTutari = mahalleIndex * 50;
                    }
                    else
                    {
                        randevu.hesapTutari = mahalleIndex * -50;
                    }

                }
            }
            
            randevu = new Randevu()
            {
                MusteriId = musteri.Id,
                hesapTutari = randevu.hesapTutari

            };
            Tutar = randevu.hesapTutari;
            db.Randevus.Add(randevu);
            db.SaveChanges();


        }
        private void btn_odeme_Click(object sender, EventArgs e)
        {
            OdemeYap();
            
            
           



            MessageBox.Show("Ödeme Sayfasına Gidiyorsunuz");
            this.Hide();
            Odeme odeme = new Odeme();
            odeme.Show();


        }
    }
}
