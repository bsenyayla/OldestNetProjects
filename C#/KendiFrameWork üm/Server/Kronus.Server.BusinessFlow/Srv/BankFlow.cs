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
    public class BankFlow
    {
        public static List<ComboItem> GetCombo() {
            dbCrmEntities context = new dbCrmEntities();
            List<ComboItem> retVal = new List<ComboItem>();

            retVal.AddRange(context.GnlBanka
                     .Where(p => p.IsActive == true
                     )
                     .Select(m => m)
                     .OrderBy(m => m.Ad)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem {
                         Aciklama = m.Ad,
                         Deger = m.Id
                     })
                    .ToList());

            return retVal;
        }
    }
}
