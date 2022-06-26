using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; } 
        public String admin { get; set; }
        public String sifre { get; set; }
    }
}