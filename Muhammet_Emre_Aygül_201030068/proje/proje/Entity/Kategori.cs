using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class Kategori
    {
        public int id { get; set; }
        public String İsim { get; set; }
        public String Acıklama { get; set; }
        public List<Urun> Uruns { get; set; }
    }
}