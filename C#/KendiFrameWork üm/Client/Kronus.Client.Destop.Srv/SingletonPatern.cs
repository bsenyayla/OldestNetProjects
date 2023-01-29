using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Client.Proxies;
using Kronus.Client.Proxies.SrvService;


namespace Kronus.Client.Destop.Srv
{
    public class SingletonPatern
    {
        private static SrvServiceClient ws;
        private static int Callcount = 0;

        private SingletonPatern()
        {

        }

        //property
        public static SrvServiceClient ActiveSrvWcfConncetionP
        {
            get
            {
                if (ws == null)
                {
                    ws = new SrvServiceClient();
                    Callcount += 1;
                }

                return ws;
            }
        }

        //metod
        public static SrvServiceClient ActiveSrvWcfConncetion()
        {
            if (ws == null)
            {
                ws = new SrvServiceClient();
                Callcount += 1;
            }

            return ws;
        }

        public static int OpenConnectionCount()
        {
            return Callcount;
        }


    }
}
//SrvServiceClient ws = new SrvServiceClient();
