using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class TedarikciS
    {
        public TedarikciS()
        {

        }

        public Guid Id { get; set; }
        public string CariKod { get; set; }
        public string CariAd { get; set; }
        public string YetkiliKisi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Banka { get; set; }
        public string Sube { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
        public string Telefon { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public bool? IsActive { get; set; }
    }
}