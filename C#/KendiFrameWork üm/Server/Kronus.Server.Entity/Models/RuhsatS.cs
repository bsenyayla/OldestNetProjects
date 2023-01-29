using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class RuhsatS
    {
        public RuhsatS()
        {

        }

        public int      Id { get; set; }
        public int      AracId { get; set; }
        public string   AracSahibiAd { get; set; }
        public string   AracSahibiSoyad { get; set; }
        public string   Plaka { get; set; }
        public int? Marka { get; set; }
        public string Model { get; set; }
        public string Cinsi { get; set; }
        public string Tipi { get; set; }
        public string Renk { get; set; }
        public string MotorNo { get; set; }
        public string SasiNo { get; set; }
        public int? NetAgirlik { get; set; }
        public int? IstiapHaddi { get; set; }
        public int? MotorGucu { get; set; }
        public int? SilindirHacmi { get; set; }
        public DateTime? MuayeneTarihi { get; set; }
        public string Img_1 { get; set; }
        public string Img_2 { get; set; }
        public string Img_3 { get; set; }
        public string Img_4 { get; set; }
    }
}