using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string TC { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public string İl { get; set; }
        public string ilce { get; set; }
        public string semt { get; set; }
        public string mahalle { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int SemtId { get; set; }
        public int MahalleId { get; set; }
        public Mahalle Mahalle { get; set; }
        public List<Randevu> Randevus { get; set; }
    }
}
