using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class PersonelShort
    {
        public PersonelShort()
        {

        }

        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public string DomainName { get; set; }
        //public DateTime DogumTarihi { get; set; }
        public string TcKimlikNo { get; set; }
        public string Departman { get; set; }
        public string Bolum { get; set; }
        public string Gorev { get; set; }
        public string Firma { get; set; }
        public string FirmaLokasyon { get; set; }
        public bool Durum { get; set; }
    }
}