using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class GuzergahShort
    {

        public GuzergahShort()
        {

        }

        public Guid Id { get; set; }
        public Guid GuzergahMainId { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int? KisiSayisi { get; set; }
        public string Arac { get; set; }
        public string Sofor { get; set; }
        public string Hostes { get; set; }
        public bool? IsActive { get; set; }
    }
}
