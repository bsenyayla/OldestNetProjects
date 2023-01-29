using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Server.Entity;
using Kronus.Server.Entity.Models;
using System.Data.Entity;
using System.Data.EntityModel;

namespace Kronus.Server.BusinessFlow.Crm
{
    public class BolumBusinessFlow
    {
        public static List<ComboItem> GetBolumListForCombo(Guid vlDepartmanId) {
            dbCrmEntities context = new dbCrmEntities();
            List<ComboItem> retVal =
                            (from p in context.CrmBolum.AsEnumerable()
                             where p.IsDeleted == false
                                 && p.IsActive == true
                                 && p.DepartmanId == vlDepartmanId
                             orderby p.Ad ascending
                             
                             select new ComboItem { 
                                 Aciklama = p.Ad, 
                                 Deger =p.Id.ToString()
                             
                             }
                            ).ToList();
            return retVal;
        }
    }
}