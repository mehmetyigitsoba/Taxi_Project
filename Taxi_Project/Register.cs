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
    public partial class Register : Form
    {
        DatabaseContext db;
        public Register()
        {
            InitializeComponent();
            db = new DatabaseContext();
            SehirDoldur();
        }
        private void SehirDoldur()
        {
            var iller = db.Ils.ToList();

            cmb_sehir.DataSource = iller;
            cmb_sehir.DisplayMember = "Isim";
            cmb_sehir.ValueMember = "Id";
        }
        private void IlceDoldur(int Ilid)
        {
            var ilceler = db.Ilces.Where(i => i.IlId == Ilid).ToList();

            cmb_ilce.DataSource = ilceler;
            cmb_ilce.DisplayMember = "Isim";
            cmb_ilce.ValueMember = "Id";
        }
        private void SemtDoldur(int Ilceid)
        {
            var semtler = db.Semts.Where(i => i.IlceId == Ilceid).ToList();

            cmb_semt.DataSource = semtler;
            cmb_semt.DisplayMember = "Isim";
            cmb_semt.ValueMember = "Id";
        }
        private void MahalleDoldur(int Semtid)
        {
            var mahalleler = db.Mahalles.Where(i => i.SemtId == Semtid).ToList();

            cmb_mahalle.DataSource = mahalleler;
            cmb_mahalle.DisplayMember = "Isim";
            cmb_mahalle.ValueMember = "Id";
        }

       

        private void cmb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Il)cmb_sehir.SelectedItem).Id;

            IlceDoldur(id);
        }

        private void cmb_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Ilce)cmb_ilce.SelectedItem).Id;

            SemtDoldur(id);
        }

        private void cmb_semt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Semt)cmb_semt.SelectedItem).Id;

            MahalleDoldur(id);
        }

        private void btn_kayit_Click_1(object sender, EventArgs e)
        {
            Musteri musteri = db.Musteris.FirstOrDefault(i => i.TC == txt_TC.Text);


            if (musteri != null)
            {
                MessageBox.Show("Kayıtlı TC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                musteri = new Musteri()
                {
                    Isim = txt_username.Text,
                    TC = txt_TC.Text,
                    Telefon = txt_phone.Text,
                    Sifre = txt_password.Text,
                    İl= cmb_sehir.Text,
                    ilce= cmb_ilce.Text,
                    semt= cmb_semt.Text,
                    mahalle= cmb_mahalle.Text,
                    IlId = Convert.ToInt32(cmb_sehir.SelectedValue),
                    IlceId = Convert.ToInt32(cmb_ilce.SelectedValue),
                    SemtId = Convert.ToInt32(cmb_semt.SelectedValue),
                    MahalleId = Convert.ToInt32(cmb_mahalle.SelectedValue)

                };

                db.Musteris.Add(musteri);
                db.SaveChanges();

                MessageBox.Show("Kayıt Başarılı");
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
        }
    }
}
