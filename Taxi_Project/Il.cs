using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class Il
    {
        public int Id { get; set; }
        public string Isim { get; set; }
       

        public List<Ilce> Ilces { get; set; }
        
    }
}
