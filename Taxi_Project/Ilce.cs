using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class Ilce
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public int IlId { get; set; }
        public Il Il { get; set; }
        public List<Semt>Semts { get; set; }
    }
}
