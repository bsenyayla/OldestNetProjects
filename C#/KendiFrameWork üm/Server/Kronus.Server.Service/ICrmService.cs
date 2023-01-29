using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Kronus.Server.BusinessFlow;
using Kronus.Server.BusinessFlow.Crm;
using Kronus.Server.Entity;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.Service
{
    [ServiceContract]
    public interface ICrmService
    {
        [OperationContract]
        List<Entity.Models.ComboItem> GetCombo(ComboFlow.ComboType vlComboName, string vlDefaultValue);
        
        [OperationContract]
        List<ComboItem> GetDepartmanListForCombo();

        [OperationContract]
        List<ComboItem> GetBolumListForCombo(Guid vlDepartmanId);

        [OperationContract]
        List<ComboItem> GetGorevListForCombo();

        [OperationContract]
        List<ComboItem> GetFirmaListForCombo();

        [OperationContract]
        List<ComboItem> GetFirmaLokasyonListForCombo(Guid vlFirmaId);

        #region Personel
        [OperationContract]
        Personel GetPersonelById(Guid vlId);

        [OperationContract]
        List<ComboItem> GetPersonelListForCombo();

        [OperationContract]
        List<Personel> GetPersonelList();

        [OperationContract]
        List<PersonelShort> GetPersonelShortList(ReportParams.PersonelShortFilter rptParam);

        [OperationContract]
        void AddPersonel(CrmPersonel vlPersonel);

        [OperationContract]
        void EditPersonel(CrmPersonel vlObj);
        #endregion Personel

        #region Ehliyet
        [OperationContract]
        EhliyetS GetEhliyetByPersonelId(Guid vlPersonelId);

        [OperationContract]
        void AddEhliyet(CrmEhliyet vlObj);

        [OperationContract]
        void EditEhliyet(CrmEhliyet vlObj);

        #endregion Ehliyet
    }
}
