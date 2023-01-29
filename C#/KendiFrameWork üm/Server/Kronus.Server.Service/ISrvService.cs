using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Kronus.Server.BusinessFlow;
using Kronus.Server.BusinessFlow.Srv;
using Kronus.Server.Entity;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.Service {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISrvService" in both code and config file together.
    [ServiceContract]
    public interface ISrvService {
        [OperationContract]
        void DoWork();

        #region Proje
        [OperationContract]
        List<ProjeShort> GetProjeShortList(ReportParams.ProjeShortFilter rptParams);

        [OperationContract]
        ProjeS GetProjeById(Guid vlProjeId);

        [OperationContract]
        void AddProje(SrvProje vlProje);

        [OperationContract]
        void EditProje(SrvProje vlProje);

        [OperationContract]
        void DeleteProje(Guid vlId);

        [OperationContract]
        List<ComboItem> GetProjeListForCombo();

        #endregion Proje

        #region Personel
        [OperationContract]
        List<Entity.Models.ComboItem> GetPersonelListForCombo();
        #endregion Personel

        #region Guzergah
        [OperationContract]
        List<GuzergahMainShort> GetGuzergahMainList(ReportParams.GuzergahMainShortFilter rptParams);
        
        [OperationContract]
        GuzergahMainS GetGuzergahMainById(Guid vlGuzergahMainId);

        [OperationContract]
        void AddGuzergahMain(SrvGuzergahMain vlGuzergahMain);
        
        [OperationContract]
        void EditGuzergahMain(SrvGuzergahMain vlGuzergahMain);
        
        [OperationContract]
        void DeleteGuzergahMain(Guid vlId);

        [OperationContract]
        List<Entity.Models.GuzergahShort> GetGuzergahList(Entity.Models.ReportParams.GuzergahShortFilter rptParams); 

        [OperationContract]
        Entity.Models.GuzergahS GetGuzergahById(Guid vlGuzergahId);
        
        [OperationContract]
        void AddGuzergah(SrvGuzergah vlGuzergah);
        
        [OperationContract]
        void EditGuzergah(SrvGuzergah vlGuzergah);

        [OperationContract]
        void DeleteGuzergah(Guid vlId);

        #endregion Guzergah

        #region Sms

        [OperationContract]
        void SmsGonder(string telNo, string mesaj);
        
        #endregion Sms

        #region Sofor
        
        [OperationContract]
        List<Entity.Models.ComboItem> Sofor_GetCombo();

        #endregion Sofor

        #region Hostes
        
        [OperationContract]
        List<Entity.Models.ComboItem> Hostes_GetCombo();

        #endregion Hostes

        #region Arac
        [OperationContract]
        List<Entity.Models.ComboItem> Arac_GetCombo();
        
        [OperationContract]
        List<Entity.Models.AracShort> Arac_GetAracList(Entity.Models.ReportParams.AracShortFilter rptParams);
        
        [OperationContract]
        Entity.Models.AracS Arac_GetAracById(int vlAracId);

        [OperationContract]
        void AddArac(SrvArac vlArac);

        [OperationContract]
        void EditArac(SrvArac vlArac);

        [OperationContract]
        void DeleteArac(int vlId);
        
        #endregion 

        #region Tedarikçi
        [OperationContract]
        List<TedarikciShort> GetTedarikciList(ReportParams.TedarikciShortFilter rptParams);
        
        [OperationContract]
        TedarikciS GetTedarikciById(Guid vlId);

        [OperationContract]
        void AddTedarikci(SrvTedarikci vlObj);

        [OperationContract]
        void EditTedarikci(SrvTedarikci vlObj);
        
        #endregion Tedarikçi    

        [OperationContract]
        List<ComboItem> GetCombo(ComboFlow.ComboType vlComboName, string vlDefaultValue);
        
    }
}
