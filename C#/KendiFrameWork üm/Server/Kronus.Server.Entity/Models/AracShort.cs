using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class AracShort
    {
        public AracShort()
        {

        }

        public int Id { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int? YolcuKapasitesi { get; set; }
        public string Tedarikci { get; set; }
        public bool? IsActive { get; set; }

    }
}