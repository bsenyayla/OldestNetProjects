using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial  class GuzergahMainShort
    {
        public GuzergahMainShort()
        {

        }

        public Guid Id { get; set; }
        public Guid ProjeId { get; set; }
        public string ProjeAd { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int? Km { get; set; }
        public int AltGuzergahSayisi { get; set; }
        public decimal? MusteriFiyat { get; set; }
        public decimal? TedarikFiyat { get; set; }
        public bool? IsActive { get; set; }
    }
}
