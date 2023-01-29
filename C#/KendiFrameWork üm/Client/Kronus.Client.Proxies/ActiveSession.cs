using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Client.Proxies.SrvService;
using Kronus.Client.Proxies.CoreService;
using Kronus.Client.Proxies.CrmService;

namespace Kronus.Client.Proxies
{
    public class ActiveSession
    {
        private static SrvServiceClient     wsSrv;
        private static CoreServiceClient    wsCore;
        private static CrmServiceClient     wsCrm;
        private static int Callcount = 0;

        private ActiveSession()
        {

        }

        ////property
        //public static SrvServiceClient Srv
        //{
        //    get
        //    {
        //        if (wsSrv == null)
        //        {
        //            wsSrv = new SrvServiceClient();
        //            Callcount += 1;
        //        }

        //        return wsSrv;
        //    }
        //}

        //metod
        public static SrvServiceClient Srv()
        {
            if (wsSrv == null)
            {
                wsSrv = new SrvServiceClient();
                Callcount += 1;
            }

            return wsSrv;
        }

        public static CoreServiceClient Core()
        {
            if (wsCore == null)
            {
                wsCore = new CoreServiceClient();
                Callcount += 1;
            }

            return wsCore;
        }

        public static CrmServiceClient Crm()
        {
            if (wsCrm == null)
            {
                wsCrm = new CrmServiceClient();
                Callcount += 1;
            }

            return wsCrm;
        }

        public static void Close()
        {

            if (wsCore != null)
            {
                try
                {
                    wsCore.Close();
                }
                catch (Exception ex)
                {
                }
            }

            if (wsCrm != null)
            {
                try
                {
                    wsCrm.Close();
                }
                catch (Exception ex)
                { 
                }
            }

            if (wsSrv != null)
            {
                try
                {
                    wsSrv.Close();
                }
                catch (Exception ex)
                {
                }
            }

        }

        public static int OpenConnectionCount
        {
            get{
                return Callcount;    
            }
        }

    }
}
