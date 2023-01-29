using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class GuzergahS
    {

        public GuzergahS()
        {

        }

        public Guid Id { get; set; }
        public string ProjeAd { get; set; }
        public Guid   GuzergahMainId { get; set; }
        public string GuzergahMainAd { get; set; }

        public string Ad { get; set; }
        public string Kod { get; set; }
        public int? KisiSayisi { get; set; }
        public string Arac { get; set; }
        public int    AracId { get; set; }
        public string Sofor { get; set; }
        public Guid SoforId { get; set; }
        public string Hostes { get; set; }
        public Guid HostesId { get; set; }
        public bool? IsActive { get; set; }
    }
}
