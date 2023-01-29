using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Kronus.Server.BusinessFlow;

namespace Kronus.Server.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CoreService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CoreService.svc or CoreService.svc.cs at the Solution Explorer and start debugging.
    public class CoreService : ICoreService
    {

        #region Menu
        
        
        public DataSet GetMenu(string vlDomainName)
        {
            return MenuBusinessFlow.GetMenu(vlDomainName);
        }
        #endregion Menu


        public string DoWork()
        {
            return "Çalışıyorum";
        }
    }
}
