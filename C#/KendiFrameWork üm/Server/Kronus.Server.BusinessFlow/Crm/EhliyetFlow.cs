using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;
using Kronus.Server.Entity.Models;


namespace Kronus.Server.BusinessFlow.Crm
{
    public class EhliyetFlow
    {
        public static EhliyetS GetEhliyetByPersonelId(Guid vlPersonelId) {
            dbCrmEntities context = new dbCrmEntities();

            return (from p in context.CrmEhliyet
                    where p.PersonelId==vlPersonelId
                    select new EhliyetS {
                        Ad=p.Ad,
                        BelgeNo=p.BelgeNo,
                        Id=p.Id,
                        Img_1=p.Img_1,
                        Img_2 = p.Img_2,
                        PersonelId=p.PersonelId,
                        Sinif=p.Sinif,
                        Soyad=p.Soyad,
                        VerilisIl=p.VerilisIl,
                        VerilisIlce=p.VerilisIlce,
                        VerilisTarihi=p.VerilisTarihi
                    }
                ).SingleOrDefault();
        }
        
        public static void AddEhliyet(CrmEhliyet vlObj) {
            dbCrmEntities context = new dbCrmEntities();
            context.AddToCrmEhliyet(vlObj);
            context.SaveChanges();
        }

        public static void EditEhliyet(CrmEhliyet vlObj) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                CrmEhliyet curVal = context.CrmEhliyet.Single(c => c.Id == vlObj.Id);
                context.CrmEhliyet.ApplyCurrentValues(vlObj);
                context.SaveChanges();
            }
        }
    }
}
