using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.BusinessFlow.Srv
{
    public class TedarikciFlow
    {
        public static List<ComboItem> GetCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.SrvTedarikci
                     .Where(p => p.IsActive == true
                         && p.IsDeleted == false
                     )
                     .OrderBy(m=> m.CariAd)
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem
                     {
                         Aciklama = m.CariAd + " (" + m.Gsm + ")",
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }

        public static List<TedarikciShort> GetTedarikciList(ReportParams.TedarikciShortFilter rptParams) {
            dbCrmEntities context = new dbCrmEntities();

            return  (from p in context.SrvTedarikci
                      where p.IsDeleted == false
                            && (p.IsActive == rptParams.IsActive || rptParams.IsActive == null)
                            && (p.CariAd.Contains(rptParams.CariAd) || rptParams.CariAd.Length==0)
                            && (p.YetkiliKisi.Contains(rptParams.CariAd) || rptParams.YetkiliKisi.Length == 0)

                      select new Entity.Models.TedarikciShort {
                          Id = p.Id,
                          IsActive = p.IsActive,
                          CariAd=p.CariAd,
                          CariKod=p.CariKod,
                          Gsm=p.Gsm
                      }
                ).ToList();
        }

        public static TedarikciS GetTedarikciById(Guid vlId) {
            dbCrmEntities context = new dbCrmEntities();
            return (from p in context.SrvTedarikci
                    where p.IsDeleted == false &&
                          p.Id == vlId
                    select new TedarikciS {
                        Id = p.Id,
                        IsActive = p.IsActive,
                        CariKod=p.CariKod,
                        CariAd=p.CariAd,
                        YetkiliKisi=p.YetkiliKisi,
                        VergiDairesi=p.VergiDairesi,
                        VergiNo=p.VergiNo,
                        Banka=p.Banka,
                        Sube=p.Sube,
                        HesapNo=p.HesapNo,
                        IBAN=p.IBAN,
                        Telefon=p.Telefon,
                        Gsm=p.Gsm,
                        Fax=p.Fax,
                        Adres=p.Adres,
                        Aciklama = p.Aciklama,
                    }
                ).SingleOrDefault();
        }

        public static void AddTedarikci(SrvTedarikci vlObj) {
            dbCrmEntities context = new dbCrmEntities();
            vlObj.CreateDate = DateTime.Now;
            vlObj.CreateUser = "App";
            vlObj.IsDeleted = false;
            context.AddToSrvTedarikci(vlObj);
            context.SaveChanges();
        }

        public static void EditTedarikci(SrvTedarikci vlObj) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                SrvTedarikci curVal = context.SrvTedarikci.Single(c => c.Id == vlObj.Id);
                vlObj.IsDeleted = curVal.IsDeleted;

                context.SrvTedarikci.ApplyCurrentValues(vlObj);
                context.SaveChanges();
            }
        }
    }
}
