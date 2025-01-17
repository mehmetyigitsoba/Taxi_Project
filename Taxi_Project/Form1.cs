using TAXI_PROJECT;

namespace Taxi_Project
{
    public partial class Form1 : Form
    {
        public static int MusteriId = 0;
        public static int MusteriIlId = 0;
        public static int MusteriIlceId = 0;
        public static int MusteriSemtId = 0;
        public static int MusteriMahalleId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            DatabaseContext db = new DatabaseContext();
            var model = db.Musteris.Where(i => i.TC == txt_TC.Text && i.Sifre == txt_password.Text).FirstOrDefault();
            if (string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_TC.Text))
            {
                MessageBox.Show("Alanlarý Doldurunuz");
                return;
            }
            else if (model == null)
            {
                MessageBox.Show("Hasta Kaydý Bulunamadý.");
                txt_password.Text = "";
                return;
            }
            MusteriId = model.Id;
            MusteriIlId = model.IlId;
            MusteriIlceId = model.IlceId;
            MusteriSemtId = model.SemtId;
            MusteriMahalleId = model.MahalleId;
            MusteriProfil form = new MusteriProfil();
            form.Show();
            this.Hide();


        }

    }
}
