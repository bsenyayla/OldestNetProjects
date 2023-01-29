using System;
using System.Collections.Generic;


namespace Kronus.Server.Entity.Models
{
    public partial class EhliyetS
    {
        public EhliyetS()
        {

        }

        public Guid Id { get; set; }
        public Guid PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VerilisIl { get; set; }
        public string VerilisIlce { get; set; }
        public string BelgeNo { get; set; }
        public DateTime? VerilisTarihi { get; set; }
        public string Sinif { get; set; }
        public string Img_1 { get; set; }
        public string Img_2 { get; set; }

    }
}
