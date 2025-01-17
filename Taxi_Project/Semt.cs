using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class Semt
    {
        public int Id { get; set; }
        public string Isim { get; set; }

        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
        public List<Mahalle> Mahalles { get; set; }
    }
}
