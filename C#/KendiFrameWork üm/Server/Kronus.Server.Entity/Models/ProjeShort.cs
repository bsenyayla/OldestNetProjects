using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models {
    public partial class ProjeShort {

        public ProjeShort()
        {

        }

        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Kodu { get; set; }
        public string Tipi { get; set; }
        public int GuzergahSayisi { get; set; }
        public int AracSayisi { get; set; }
        public int YolcuSayisi { get; set; }
        public string ProjeSorumlusu { get; set; }
    }
}


