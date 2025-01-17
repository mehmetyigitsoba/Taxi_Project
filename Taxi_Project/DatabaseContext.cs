using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_PROJECT
{
    internal class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=23MYS\\MSSQLSERVER01;Database=TAXIPROJECTDB;Trusted_Connection=true; TrustServerCertificate=True");
        }
     
        public DbSet<Il>Ils { get; set; }
        public DbSet<Ilce>Ilces { get; set; }
        public DbSet<Semt> Semts { get; set; }
        public DbSet<Mahalle> Mahalles { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Musteri>Musteris { get; set; }
    }
}
