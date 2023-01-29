using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Kronus.Server.Entity;
using Kronus.Server.Entity.Models;
using Kronus.Server.BusinessFlow;
using Kronus.Server.BusinessFlow.Crm;

namespace Kronus.Server.Service
{

    public class CrmService : ICrmService
    {
        public List<Entity.Models.ComboItem> GetCombo(ComboFlow.ComboType vlComboName, string vlDefaultValue) {
            return ComboFlow.GetCombo(vlComboName, vlDefaultValue);
        }


        public List<ComboItem> GetDepartmanListForCombo() {
            return DepartmanBusinessFlow.GetDepartmanListForCombo();
        }

        public List<ComboItem> GetBolumListForCombo(Guid vlDepartmanId) {
            return BolumBusinessFlow.GetBolumListForCombo(vlDepartmanId);
        }

        public List<ComboItem> GetGorevListForCombo() {
            return GorevBusinessFlow.GetGorevListForCombo();
        }

        public List<ComboItem> GetFirmaListForCombo() {
            return FirmaBusinessFlow.GetFirmaListForCombo();
        }

        public List<ComboItem> GetFirmaLokasyonListForCombo(Guid vlFirmaId) {
            return FirmaBusinessFlow.GetFirmaLokasyonListForCombo(vlFirmaId);
        }

        #region Personel

        public Personel GetPersonelById(Guid vlId) {
            return IKBusinessFlow.GetPersonelById(vlId);
        }

        public List<ComboItem> GetPersonelListForCombo() {
            return IKBusinessFlow.GetPersonelListForCombo();
        }

        public List<Personel> GetPersonelList() {
            return IKBusinessFlow.GetPersonelList();
        }

        public List<PersonelShort> GetPersonelShortList(ReportParams.PersonelShortFilter rptParam) {
            return IKBusinessFlow.GetPersonelShortList(rptParam);
        }

        public void AddPersonel(CrmPersonel vlPersonel) {
            IKBusinessFlow.AddPersonel(vlPersonel);
        }

        public void EditPersonel(CrmPersonel vlObj) {
            IKBusinessFlow.EditPersonel(vlObj);
        }
        #endregion Personel

        #region Ehliyet
        public EhliyetS GetEhliyetByPersonelId(Guid vlPersonelId) {
            return EhliyetFlow.GetEhliyetByPersonelId(vlPersonelId);
        }

        public void AddEhliyet(CrmEhliyet vlObj) {
            EhliyetFlow.AddEhliyet(vlObj);
        }

        public void EditEhliyet(CrmEhliyet vlObj) {
            EhliyetFlow.EditEhliyet(vlObj);
        }
        #endregion Ehliyet
    }
}
