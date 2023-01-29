using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class TedarikciShort
    {
        public TedarikciShort()
        {

        }

        public Guid Id { get; set; }
        public string CariKod { get; set; }
        public string CariAd { get; set; }
        public string Gsm { get; set; }
        public bool? IsActive { get; set; }
    }
}