using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAXI_PROJECT;

namespace Taxi_Project
{
    public partial class Odeme : Form
    {
        DatabaseContext db;
        
        public Odeme()
        {
            InitializeComponent();
            db = new DatabaseContext();
            lbl_tutar.Text = Convert.ToString(MusteriProfil.Tutar);
            
        }

        private void btn_odeme_1_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Ödeme Başarılı");
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
