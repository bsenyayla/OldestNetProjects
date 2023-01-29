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

namespace Kronus.Server.BusinessFlow.Srv
{
    public class GuzergahFlow
    {
        public static List<Entity.Models.GuzergahShort> GetGuzergahList(Entity.Models.ReportParams.GuzergahShortFilter rptParams)
        {
            dbCrmEntities context = new dbCrmEntities();

            List<Entity.Models.GuzergahShort> rcList = new List<Entity.Models.GuzergahShort>();
            try
            {
                rcList = (from p in context.SrvGuzergah
                          where p.IsDeleted == false
                                && (p.IsActive == rptParams.IsActive || rptParams.IsActive == null)
                                && (p.GuzergahMainId == rptParams.GuzergahMainId || rptParams.GuzergahMainId == null)
                          select new Entity.Models.GuzergahShort
                          {
                                Ad=p.Ad,
                                Arac=p.SrvArac.Plaka,
                                GuzergahMainId = p.GuzergahMainId,
                                //Hostes = p.HostesEx.Ad + "-" + p.HostesEx.Soyad,
                                Id = p.Id,
                                IsActive = p.IsActive,
                                KisiSayisi = p.KisiSayisi,
                                Kod = p.Kod,
                                //Sofor = p.SoforEx.Ad + "-" + p.SoforEx.Soyad + " (" + p.SoforEx.GsmNo + ")"
                          }
                    ).ToList();
            }

            catch (Exception ex)
            {
                string ss = ex.Data.ToString();
            }
            return rcList;
        }

        public static Entity.Models.GuzergahS GetGuzergahById(Guid vlGuzergahId)
        {
            dbCrmEntities context = new dbCrmEntities();
            
            return (from p in context.SrvGuzergah
                    where p.IsDeleted == false &&
                          p.Id == vlGuzergahId
                     select new Entity.Models.GuzergahS
                          {
                                Ad=p.Ad,
                                Arac=p.SrvArac.Plaka,
                                AracId=p.SrvArac.Id,
                                GuzergahMainId = p.GuzergahMainId,
                                
                                Id = p.Id,
                                IsActive = p.IsActive,
                                KisiSayisi = p.KisiSayisi,
                                Kod = p.Kod,
                                //Sofor = p.SoforEx.Ad + "-" + p.SoforEx.Soyad + " (" + p.SoforEx.GsmNo + ")",
                                //SoforId=p.SoforEx.Id,
                                //Hostes = p.HostesEx.Ad + "-" + p.HostesEx.Soyad,
                                //HostesId=p.HostesEx.Id,
                                GuzergahMainAd=p.SrvGuzergahMain.Ad,
                                ProjeAd=p.SrvGuzergahMain.SrvProje.Ad
                          }
                ).SingleOrDefault();
        }

        public static void AddGuzergah(SrvGuzergah vlGuzergah)
        {
            dbCrmEntities context = new dbCrmEntities();

            try
            {
                vlGuzergah.Id = Guid.NewGuid();
                vlGuzergah.IsDeleted = false;

                context.AddToSrvGuzergah(vlGuzergah);
                context.SaveChanges();
            }

            catch (Exception ex)
            {
                string hata = "Data:" + ex.Data.ToString() + "İnnerException" + ex.InnerException.InnerException.ToString();
            }
        }

        public static void EditGuzergah(SrvGuzergah vlGuzergah)
        {
            using (dbCrmEntities context = new dbCrmEntities())
            {
                SrvGuzergah curVal = context.SrvGuzergah.Single(c => c.Id == vlGuzergah.Id);
                vlGuzergah.IsDeleted = curVal.IsDeleted;

                context.SrvGuzergah.ApplyCurrentValues(vlGuzergah);
                context.SaveChanges();
            }
        }

        public static void DeleteGuzergah(Guid vlId)
        {
            using (dbCrmEntities context = new dbCrmEntities())
            {
                SrvGuzergah curVal = context.SrvGuzergah.Single(c => c.Id == vlId);

                curVal.IsDeleted = true;
                context.SrvGuzergah.ApplyCurrentValues(curVal);
                context.SaveChanges();
            }
        }
    }
}
