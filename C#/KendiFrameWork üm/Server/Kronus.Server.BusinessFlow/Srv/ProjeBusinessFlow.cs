using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.BusinessFlow.Srv {
    public class ProjeBusinessFlow {

        public static List<ProjeShort> GetProjeShortList(ReportParams.ProjeShortFilter rptParams) {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ProjeShort> rcList = new List<Entity.Models.ProjeShort>();
            try {
                rcList = (from p in context.SrvProje
                          where p.IsDeleted.Value == false &&
                                (p.IsActive==rptParams.IsActive || rptParams.IsActive==null) &&
                                (p.Ad.Contains(rptParams.Ad)    || rptParams.Ad == "") &&
                                (p.Kod.Contains(rptParams.Kod)  || rptParams.Kod == "") 
                                && (rptParams.Tipi==p.Tipi      || rptParams.Tipi=="")
                          select new ProjeShort
                          {
                              Id    = p.Id,
                              Ad    = p.Ad,
                              Kodu  = p.Kod,
                              //Tipi  = p.ProjeTipiEx.Ad,
                              GuzergahSayisi = 0,
                              AracSayisi = 0,
                              //ProjeSorumlusu = p.MusteriTemsilcisiEx.Ad + " " + p.MusteriTemsilcisiEx.Soyad + " ("+ p.MusteriTemsilcisiEx.GsmNo + ")",
                              YolcuSayisi = 0,
                          }
                    ).ToList();
            }

            catch (Exception ex) {
                string ss = ex.Data.ToString();
            }
            return rcList;
        }

        public static ProjeS GetProjeById(Guid vlProjeId) {
            dbCrmEntities context = new dbCrmEntities();
            
            return (from p in context.SrvProje
                          where p.IsDeleted == false &&
                                p.Id == vlProjeId
                          select new ProjeS {
                              Ad=p.Ad,
                              AracBedelsizSeferSayisi=p.AracBedelsizSeferSayisi,
                              Bolge=p.Bolge,
                              FaturaGunu=p.FaturaGunu,
                              FaturaHizmetKodu=p.FaturaHizmetKodu,
                              FaturaTipi=p.FaturaTipi,
                              FirmaYetkiliEmail=p.FirmaYetkiliEmail,
                              FirmaYetkiliFax=p.FirmaYetkiliFax,
                              FirmaYetkilisi=p.FirmaYetkilisi,
                              FirmaYetkiliTel=p.FirmaYetkiliTel,
                              Grup=p.Grup,
                              HostesHakEdisTutari=p.HostesHakEdisTutari,
                              Id=p.Id,
                              IsActive=p.IsActive,
                              IsDeleted=p.IsDeleted,
                              IskontoOrani=p.IskontoOrani,
                              Kod=p.Kod,
                              MusteriTemsilcisi=p.MusteriTemsilcisi,
                              ProjeLideri=p.ProjeLideri,
                              Sektor=p.Sektor,
                              Sirket=p.Sirket,
                              SoforHakEdisTutari=p.SoforHakEdisTutari,
                              SozlesmeBaslangicTarihi=p.SozlesmeBaslangicTarihi,
                              SozlesmeBitisTarihi=p.SozlesmeBitisTarihi,
                              SozlesmeyiYapan=p.SozlesmeyiYapan,
                              Tipi=p.Tipi,
                              WebSitesi=p.WebSitesi
                          }
                    ).SingleOrDefault();
        }

        public static void AddProje(SrvProje vlProje) {
            dbCrmEntities context = new dbCrmEntities();

            try {
                vlProje.Id = Guid.NewGuid();
                vlProje.IsDeleted = false;
                vlProje.CreateDate = DateTime.Now;

                context.AddToSrvProje(vlProje);
                context.SaveChanges();
            }

            catch (Exception ex) {
                string hata = "Data:" + ex.Data.ToString() + "İnnerException" + ex.InnerException.InnerException.ToString();
            }
        }

        public static void EditProje(SrvProje vlProje) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                SrvProje curVal = context.SrvProje.Single(c => c.Id == vlProje.Id);
                vlProje.CreateDate = curVal.CreateDate;
                vlProje.CreateUser = curVal.CreateUser;
                vlProje.IsDeleted  = curVal.IsDeleted;
                //vlProje.IsActive   = curVal.IsActive;
    
                context.SrvProje.ApplyCurrentValues(vlProje);
                context.SaveChanges();
            }
        }

        public static void DeleteProje(Guid vlId) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                SrvProje curVal = context.SrvProje.Single(c => c.Id == vlId);

                curVal.IsDeleted = true;
                context.SrvProje.ApplyCurrentValues(curVal);
                context.SaveChanges();
            }
        }

        public static List<Entity.Models.ComboItem> GetProjeListForCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal =
                            context.SrvProje
                            .Where(p => p.IsDeleted == false && p.IsActive == true)
                            .Select(m => m)
                            .AsEnumerable()
                            .Select(m => new Entity.Models.ComboItem
                            {
                                Aciklama = m.Ad,
                                Deger = m.Id.ToString()
                            })
                            .ToList();
            return retVal;
        }
    }
}
