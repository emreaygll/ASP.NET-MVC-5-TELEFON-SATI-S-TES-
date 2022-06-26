using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class Urun
    {
        public int id { get; set; }
        public String İsim { get; set; }
        public String Acıklama { get; set; }
        public String image { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsApproved { get; set; }
        public int Kategoriid { get; set; }
        public Kategori Kategori { get; set; }


    }
}