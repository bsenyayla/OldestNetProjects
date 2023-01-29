using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WinServiceApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main() {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);

            TransactionServiceInstaller();

            string fff=Console.ReadLine();
        }

        public static void TransactionServiceInstaller()
        {
            Uri uri = new Uri("http://localhost:15675/CollectService");

            ServiceHost serviceHost = new ServiceHost(typeof(WcfServiceLibrary1.TransactionService), uri);
            serviceHost.AddServiceEndpoint(
                typeof(WcfServiceLibrary1.ITransactionService),
                new WSHttpBinding { Security = new WSHttpSecurity { Mode = SecurityMode.None } },
                uri);

            ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
            serviceMetadataBehavior.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);

            serviceHost.Open();
        }
    }
}
