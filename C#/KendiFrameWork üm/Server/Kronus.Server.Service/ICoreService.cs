using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace Kronus.Server.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICoreService" in both code and config file together.
    [ServiceContract]
    public interface ICoreService
    {
        [OperationContract]
        string DoWork();

        #region Menu

        [OperationContract]
        DataSet GetMenu(string vlDomainName);
        #endregion Menu
    }
}
