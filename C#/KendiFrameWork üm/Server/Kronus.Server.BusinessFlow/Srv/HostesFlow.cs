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
    public class HostesFlow
    {
        public static List<Entity.Models.ComboItem> GetCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            retVal.AddRange(context.CrmPersonel
                     .Where(p => p.IsActive == true 
                         && p.IsDeleted==false
                         && p.GorevId == new Guid(EnumType.HOSTES)
                     )
                     .Select(m => m)
                     .AsEnumerable()
                     .Select(m => new Entity.Models.ComboItem
                     {
                         Aciklama = m.Ad,
                         Deger = m.Id.ToString()
                     })
                    .ToList());

            return retVal;
        }
    }
}
