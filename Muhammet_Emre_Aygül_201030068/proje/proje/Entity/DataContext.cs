using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class DataContext:DbContext
    {
        


        public DataContext():base("Context")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}