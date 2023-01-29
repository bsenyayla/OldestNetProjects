using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Kronus.Client.Destop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            string vlTheme = "";
            try
            {
                vlTheme = Common.Libs.Tools.GetSetting("Theme");
            }
            catch
            {

            }
            //SplashScreenManager.ShowForm(null, typeof(SplashScreen1), true, true, false, 1000);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(vlTheme);
            Application.Run(new MainForm());
            //Application.Run(new Kronus.Client.Common.Management.LotCalcForm());
        }
    }
}
