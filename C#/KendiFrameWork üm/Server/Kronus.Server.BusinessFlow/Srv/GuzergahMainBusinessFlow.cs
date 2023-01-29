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

namespace Kronus.Server.BusinessFlow.Srv
{
    public class GuzergahMainBusinessFlow
    {

        public static List<GuzergahMainShort> GetGuzergahMainList(ReportParams.GuzergahMainShortFilter rptParams)
        {
            dbCrmEntities context = new dbCrmEntities();

            List<Entity.Models.GuzergahMainShort> rcList = new List<Entity.Models.GuzergahMainShort>();
            try
            {
                rcList = (from p in context.SrvGuzergahMain
                          where p.IsDeleted.Value == false
                                && (p.IsActive == rptParams.IsActive || rptParams.IsActive == null)
                                && (p.ProjeId == rptParams.ProjeId || rptParams.ProjeId == null)
                                && (p.SrvProje.Tipi == rptParams.ProjeTipi || rptParams.ProjeTipi == "")
                          select new Entity.Models.GuzergahMainShort
                          {
                              ProjeAd = p.SrvProje.Ad,
                              Id = p.Id,
                              Ad = p.Ad,
                              IsActive = p.IsActive,
                              Km = p.Km,
                              Kod = p.Kod,
                              MusteriFiyat = p.MusteriFiyat,
                              ProjeId = p.ProjeId,
                              TedarikFiyat = p.TedarikFiyat
                             //,                             AltGuzergahSayisi=p.SrvGuzergah.Count()
                          }
                    ).ToList();
            }

            catch (Exception ex)
            {
                string ss = ex.Data.ToString();
            }
            return rcList;
        }

        public static GuzergahMainS GetGuzergahMainById(Guid vlGuzergahMainId)
        {
            dbCrmEntities context = new dbCrmEntities();

            return (from p in context.SrvGuzergahMain
                    where p.IsDeleted == false &&
                          p.Id == vlGuzergahMainId
                    select new GuzergahMainS { 
                        Ad=p.Ad,
                        Id=p.Id,
                        IsActive=p.IsActive,
                        IsDeleted=p.IsDeleted,
                        Km=p.Km,
                        Kod=p.Kod,
                        MusteriFiyat=p.MusteriFiyat,
                        ProjeId=p.ProjeId,
                        TedarikFiyat=p.TedarikFiyat
                    }
                ).SingleOrDefault();
        }

        public static void AddGuzergahMain(SrvGuzergahMain vlGuzergahMain)
        {
            dbCrmEntities context = new dbCrmEntities();

            try
            {
                vlGuzergahMain.Id = Guid.NewGuid();
                vlGuzergahMain.IsDeleted = false;

                context.AddToSrvGuzergahMain(vlGuzergahMain);
                context.SaveChanges();
            }

            catch (Exception ex)
            {
                string hata = "Data:" + ex.Data.ToString() + "İnnerException" + ex.InnerException.InnerException.ToString();
            }
        }

        public static void EditGuzergahMain(SrvGuzergahMain vlGuzergahMain)
        {
            using (dbCrmEntities context = new dbCrmEntities())
            {
                SrvGuzergahMain curVal = context.SrvGuzergahMain.Single(c => c.Id == vlGuzergahMain.Id);
                vlGuzergahMain.IsDeleted = curVal.IsDeleted;

                context.SrvGuzergahMain.ApplyCurrentValues(vlGuzergahMain);
                context.SaveChanges();
            }
        }

        public static void DeleteGuzergahMain(Guid vlId)
        {
            using (dbCrmEntities context = new dbCrmEntities())
            {
                SrvGuzergahMain curVal = context.SrvGuzergahMain.Single(c => c.Id == vlId);

                curVal.IsDeleted = true;
                context.SrvGuzergahMain.ApplyCurrentValues(curVal);
                context.SaveChanges();
            }
        }
    }
}
