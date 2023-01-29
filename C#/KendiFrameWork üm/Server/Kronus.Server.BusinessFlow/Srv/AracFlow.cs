using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;

namespace Kronus.Server.BusinessFlow.Srv
{
    public class AracFlow
    {
        public static List<Entity.Models.ComboItem> GetCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.SrvArac
                     .Where(p => p.IsActive == true
                         && p.IsDeleted == false
                     )
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem
                     {
                         Aciklama = m.Plaka,
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }

        public static List<Entity.Models.ComboItem> GetMarkaForCombo() {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.GnlMarka
                     .Where(p => p.IsActive == true && p.GnlModel.Count > 0
                     )
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem {
                         Aciklama = m.Ad,
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }

        public static List<Entity.Models.ComboItem> GetModelForCombo(int vlMarkaId) {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.GnlModel
                     .Where(p => p.IsActive == true
                         && p.MarkaId==vlMarkaId
                     )
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem {
                         Aciklama = m.Ad,
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }

        public static List<Entity.Models.AracShort> GetAracList(Entity.Models.ReportParams.AracShortFilter rptParams)
        {
            dbCrmEntities context = new dbCrmEntities();

            List<Entity.Models.AracShort> rcList = new List<Entity.Models.AracShort>();

            rcList = (from p in context.SrvArac
                      where p.IsDeleted == false
                            && (p.IsActive == rptParams.IsActive || rptParams.IsActive == null)
                            && (rptParams.Kod.Length == 0 || p.LogoKodu.Contains(rptParams.Kod))
                            && (rptParams.Plaka.Length == 0 || p.Plaka.Contains(rptParams.Plaka))
                            && (
                                    (p.TedarikciId == null && rptParams.Tedarikci == Guid.Empty) 
                                    ||
                                            (p.TedarikciId == rptParams.Tedarikci ||
                                            rptParams.Tedarikci == null )
                               )
                      select new Entity.Models.AracShort
                      {
                          Id = p.Id,
                          IsActive = p.IsActive,
                          Plaka = p.Plaka,
                          YolcuKapasitesi = p.YolcuKapasitesi.Value,
                          Marka     =p.GnlMarka.Ad,
                          Model     =p.GnlModel.Ad,
                          Tedarikci = (p.SrvTedarikci == null ? "ÖzMal" : p.SrvTedarikci.CariAd) 
                      }
                ).ToList();

            return rcList;
        }

        public static Entity.Models.AracS GetAracById(int vlAracId)
        {
            dbCrmEntities context = new dbCrmEntities();
            return (from p in context.SrvArac
                    where p.IsDeleted == false &&
                          p.Id == vlAracId
                    select new Entity.Models.AracS
                    {
                        Id = p.Id,
                        IsActive = p.IsActive,
                        GpsCihazId = p.GpsCihazId,
                        LogoKodu = p.LogoKodu,
                        Marka = p.Marka,
                        ModelYili = p.ModelYili,
                        Plaka = p.Plaka,
                        Renk = p.Renk,
                        TedarikciId = p.TedarikciId,
                        YolcuKapasitesi = p.YolcuKapasitesi,

                        AracSahibiAd=p.AracSahibiAd,
                        AracSahibiSoyad=p.AracSahibiSoyad,
                        Cinsi=p.Cinsi,
                        Tipi=p.Tipi,
                        MotorNo=p.MotorNo,
                        SasiNo=p.SasiNo,
                        NetAgirlik=p.NetAgirlik,
                        IstiapHaddi=p.IstiapHaddi,
                        MotorGucu=p.MotorGucu,
                        SilindirHacmi=p.SilindirHacmi,
                        MuayeneTarihi=p.MuayeneTarihi
                    }
                ).SingleOrDefault();
        }

        public static void AddArac(SrvArac vlArac)
        {
            dbCrmEntities context = new dbCrmEntities();
            vlArac.CreateDate = DateTime.Now;
            vlArac.CreateUser = "App";
            vlArac.IsDeleted = false;
            context.AddToSrvArac(vlArac);
            context.SaveChanges();
        }

        public static void EditArac(SrvArac vlArac)
        {
            using (dbCrmEntities context = new dbCrmEntities())
            {
                SrvArac curVal = context.SrvArac.Single(c => c.Id == vlArac.Id);
                vlArac.IsDeleted = curVal.IsDeleted;

                context.SrvArac.ApplyCurrentValues(vlArac);
                context.SaveChanges();
            }
        }

        public static void DeleteArac(int vlId) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                SrvArac curVal = context.SrvArac.Single(c => c.Id == vlId);

                curVal.IsDeleted = true;
                context.SrvArac.ApplyCurrentValues(curVal);
                context.SaveChanges();
            }
        }
    }
}
