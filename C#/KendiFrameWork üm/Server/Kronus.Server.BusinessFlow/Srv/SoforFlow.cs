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
    public class SoforFlow
    {

        public static List<Entity.Models.ProjeShort> GetProjeShortList(Entity.Models.ReportParams.ProjeShortFilter rptParams)
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ProjeShort> rcList = new List<Entity.Models.ProjeShort>();
            try
            {
                rcList = (from p in context.SrvProje
                          where p.IsDeleted.Value == false &&
                                (p.IsActive == rptParams.IsActive || rptParams.IsActive == null) &&
                                (p.Ad.Contains(rptParams.Ad) || rptParams.Ad == "") &&
                                (p.Kod.Contains(rptParams.Kod) || rptParams.Kod == "")
                                && (rptParams.Tipi == p.Tipi || rptParams.Tipi == "")
                          select new Entity.Models.ProjeShort
                          {
                              Id = p.Id,
                              Ad = p.Ad,
                              Kodu = p.Kod,
                              //Tipi = p.ProjeTipiEx.Ad,
                              GuzergahSayisi = 0,
                              AracSayisi = 0,
                              //ProjeSorumlusu = p.MusteriTemsilcisiEx.Ad + " " + p.MusteriTemsilcisiEx.Soyad + " (" + p.MusteriTemsilcisiEx.GsmNo + ")",
                              YolcuSayisi = 0,

                          }
                    ).ToList();
            }

            catch (Exception ex)
            {
                string ss = ex.Data.ToString();
            }
            return rcList;
        }

        public static List<Entity.Models.ComboItem> GetCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.CrmPersonel
                     .Where(p => p.IsActive == true
                         && p.IsDeleted == false
                         && p.GorevId == new Guid(EnumType.SOFOR)
                     )
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem
                     {
                         Aciklama = m.Ad + m.Soyad + " (" + m.GsmNo + ")",
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }
    }
}
