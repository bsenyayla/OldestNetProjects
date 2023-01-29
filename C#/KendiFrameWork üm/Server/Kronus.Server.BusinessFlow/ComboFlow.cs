using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;


namespace Kronus.Server.BusinessFlow
{
    public class ComboFlow
    {

        public enum ComboType
        {
            None,
            AracMarka,
            AracModel,
            Banka,
            CalismaSekli,
            Cinsiyet,
            FaturaTipi,
            OdemeTipi,
            OtomobilCinsi,
            ProjeTipi,
            Renk,
            Tedarikci
        };


        public static List<Entity.Models.ComboItem> GetCombo(ComboType vlComboType)
        {
            return GetCombo(vlComboType, "");
        }

        public static List<Entity.Models.ComboItem> GetCombo(ComboType vlComboType,string vlDefaultValue) {

            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal = new List<Entity.Models.ComboItem>();

            string vlUstId = "";
            bool IsNormal = false;

            switch (vlComboType) {
                case ComboType.Cinsiyet:
                vlUstId = "CYT-00";
                IsNormal = true;
                break;

                case ComboType.ProjeTipi:
                vlUstId = "PRT-00";
                IsNormal = true;
                break;

                case ComboType.FaturaTipi:
                vlUstId = "FTP-00";
                IsNormal = true;
                break;

                case ComboType.Renk:
                vlUstId = "RNK-00";
                IsNormal = true;
                break;

                case ComboType.OtomobilCinsi:
                vlUstId = "ACS-00";
                IsNormal = true;
                break;

                case ComboType.CalismaSekli:
                vlUstId = "CLS-00";
                IsNormal = true;
                break;

                case ComboType.OdemeTipi:
                vlUstId = "ODM-00";
                IsNormal = true;
                break;


            }

            if (IsNormal == true) {
                retVal.AddRange(context.FrwGeneralValues
                .Where(p => p.IsActive == true && p.UstId == vlUstId)
                .OrderBy(m => m.Ad)
                .Select(m => m)
                .AsEnumerable()
                .Select(m => new Entity.Models.ComboItem {
                    Aciklama = m.Ad,
                    Deger = m.Id.ToString()
                })
                .ToList());
            }
            else {
                if (ComboType.Tedarikci == vlComboType) {
                    retVal = Srv.TedarikciFlow.GetCombo();
                }

                if (ComboType.AracMarka == vlComboType) {
                    retVal = Srv.AracFlow.GetMarkaForCombo();
                }

                if (ComboType.AracModel == vlComboType) {
                    retVal = Srv.AracFlow.GetModelForCombo(Convert.ToInt32(vlDefaultValue));
                }

                if (ComboType.Banka == vlComboType) {
                    retVal =Srv.BankFlow.GetCombo();
                }
            }

            return retVal;
        }
    }
}
