using System;
using System.Collections.Generic;


namespace Kronus.Server.Entity.Models
{
    public class ReportParams
    {

        public class PersonelShortFilter
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string DomainName { get; set; }
            public string TcKimlikNo { get; set; }
            public Guid? Departman { get; set; }
            public bool? IsActive { get; set; }
        }

        public class ProjeShortFilter
        {
            public string Ad { get; set; }
            public string Kod { get; set; }
            public string Tipi { get; set; }
            public bool? IsActive { get; set; }
        }

        public class GuzergahMainShortFilter
        {
            public Guid? ProjeId { get; set; }
            public bool? IsActive { get; set; }
            public string ProjeTipi { get; set; }
        }

        public class GuzergahShortFilter
        {
            public Guid? GuzergahMainId { get; set; }
            public bool? IsActive { get; set; }
        }

        public class AracShortFilter
        {
            public string Plaka { get; set; }
            public string Kod { get; set; }
            public Guid? Tedarikci { get; set; }
            public bool? IsActive { get; set; }
        }

        public class TedarikciShortFilter
        {
            public string CariAd { get; set; }
            public string YetkiliKisi { get; set; }
            public bool? IsActive { get; set; }
        }
    }
}
