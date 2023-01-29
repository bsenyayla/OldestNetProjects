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


namespace Kronus.Server.BusinessFlow.Crm
{
    public class GorevBusinessFlow
    {
        public static List<Entity.Models.ComboItem> GetGorevListForCombo()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal =
                            context.CrmGorev
                            .Where(p => p.IsDeleted == false && p.IsActive == true)
                            .OrderBy(p=> p.Ad)
                            .AsEnumerable()
                            .Select(m => new Entity.Models.ComboItem { Aciklama = m.Ad, Deger = m.Id.ToString() })
                            .ToList();

            return retVal;
        }
    }
}
