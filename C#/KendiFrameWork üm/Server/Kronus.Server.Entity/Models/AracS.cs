using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class AracS
    {
        public AracS()
        {

        }

        public int Id { get; set; }
        public string Plaka { get; set; }
        public string LogoKodu { get; set; }
        public int?  YolcuKapasitesi { get; set; }
        public int?  Marka { get; set; }
        public int?  ModelYili { get; set; }
        public string Renk { get; set; }
        public Guid?  TedarikciId { get; set; }
        public int?   GpsCihazId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public string AracSahibiAd { get; set; }
        public string AracSahibiSoyad { get; set; }
        public string Cinsi { get; set; }
        public int? Tipi { get; set; }
        public string MotorNo { get; set; }
        public string SasiNo { get; set; }
        public int? NetAgirlik { get; set; }
        public int? IstiapHaddi { get; set; }
        public int? MotorGucu { get; set; }
        public int? SilindirHacmi { get; set; }
        public DateTime? MuayeneTarihi { get; set; }
    }
}