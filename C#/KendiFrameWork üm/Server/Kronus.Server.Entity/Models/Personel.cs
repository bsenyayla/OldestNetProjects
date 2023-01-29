using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class Personel
    {
        public Personel()
        {
        }

        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DomainName { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string TcKimlikNo { get; set; }
        public string MedeniHali { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string EmailIs { get; set; }
        public string TelefonNo { get; set; }
        public string GsmNo { get; set; }
        public string TelefonNoIs { get; set; }
        public string Cinsiyet { get; set; }
        public string ProfilFoto { get; set; }   
	    public Nullable<DateTime> GirisTarihi { get; set; }
        public Nullable<DateTime> CikisTarihi { get; set; }
        public Guid? BirinciYonetici { get; set; }
        public Guid? IkinciYonetici { get; set; }
        public Guid? DepartmanId { get; set; }
        public Guid? BolumId { get; set; }
        public Guid? GorevId { get; set; }
        public Guid? FirmaId { get; set; }
        public Guid? FirmaLokasyonId { get; set; }
        public bool? IsActive { get; set; }
        public string CalismaSekli { get; set; }
        public string OdemeTipi { get; set; }
    }
}