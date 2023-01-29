using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVC.Models
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public int DepartmanId { get; set; }
    }
}