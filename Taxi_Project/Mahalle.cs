using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class Mahalle
    {
        public int Id { get; set; }
        public string Isim { get; set; }

        public int SemtId { get; set; }
        public Semt Semt { get; set; }
       
    }
}
