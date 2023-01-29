using System;
using System.Collections.Generic;

namespace Kronus.Server.Entity.Models
{
    public partial class ProjeS
    {
        public ProjeS() {

        }

        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public string Tipi { get; set; }
        public Guid? ProjeLideri { get; set; }
        public string FirmaYetkilisi { get; set; }
        public string FirmaYetkiliEmail { get; set; }
        public string FirmaYetkiliTel { get; set; }
        public string FirmaYetkiliFax { get; set; }
        public string WebSitesi { get; set; }
        public string Sirket { get; set; }
        public string Grup { get; set; }
        public string Sektor { get; set; }
        public string Bolge { get; set; }
        public Guid? SozlesmeyiYapan { get; set; }
        public DateTime? SozlesmeBaslangicTarihi { get; set; }
        public DateTime? SozlesmeBitisTarihi { get; set; }
        public string FaturaHizmetKodu { get; set; }
        public decimal? IskontoOrani { get; set; }
        public int? FaturaGunu { get; set; }
        public int? FaturaTipi { get; set; }
        public Guid? MusteriTemsilcisi { get; set; }
        public decimal? HostesHakEdisTutari { get; set; }
        public decimal? SoforHakEdisTutari { get; set; }
        public int? AracBedelsizSeferSayisi { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}