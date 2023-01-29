using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Kronus.Server.Entity;
using Kronus.Server.BusinessFlow;
using Kronus.Server.BusinessFlow.Srv;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SrvService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SrvService.svc or SrvService.svc.cs at the Solution Explorer and start debugging.
    public class SrvService : ISrvService
    {
        public void DoWork() {
        }

        #region Proje

        public List<Entity.Models.ProjeShort> GetProjeShortList(Entity.Models.ReportParams.ProjeShortFilter rptParams) {
            return ProjeBusinessFlow.GetProjeShortList(rptParams);
        }

        public ProjeS GetProjeById(Guid vlProjeId) {
            return ProjeBusinessFlow.GetProjeById(vlProjeId);
        }

        public void AddProje(SrvProje vlProje) {
            ProjeBusinessFlow.AddProje(vlProje);
        }

        public void EditProje(SrvProje vlProje) {
            ProjeBusinessFlow.EditProje(vlProje);
        }

        public void DeleteProje(Guid vlId) {
            ProjeBusinessFlow.DeleteProje(vlId);
        }

        public List<Entity.Models.ComboItem> GetProjeListForCombo() {
            return ProjeBusinessFlow.GetProjeListForCombo();
        }

        #endregion Proje


        #region Personel
        public List<Entity.Models.ComboItem> GetPersonelListForCombo() {
            return Kronus.Server.BusinessFlow.Crm.IKBusinessFlow.GetPersonelListForCombo();
        }

        #endregion Personel

        public List<ComboItem> GetCombo(ComboFlow.ComboType vlComboName, string vlDefaultValue) {
            return ComboFlow.GetCombo(vlComboName, vlDefaultValue);
        }

        #region Guzergah
        public List<GuzergahMainShort> GetGuzergahMainList(ReportParams.GuzergahMainShortFilter rptParams) {
            return GuzergahMainBusinessFlow.GetGuzergahMainList(rptParams);
        }

        public GuzergahMainS GetGuzergahMainById(Guid vlGuzergahMainId) {
            return GuzergahMainBusinessFlow.GetGuzergahMainById(vlGuzergahMainId);
        }

        public void AddGuzergahMain(SrvGuzergahMain vlGuzergahMain) {
            GuzergahMainBusinessFlow.AddGuzergahMain(vlGuzergahMain);
        }

        public void EditGuzergahMain(SrvGuzergahMain vlGuzergahMain) {
            GuzergahMainBusinessFlow.EditGuzergahMain(vlGuzergahMain);
        }

        public void DeleteGuzergahMain(Guid vlId) {
            GuzergahMainBusinessFlow.DeleteGuzergahMain(vlId);
        }

        public List<Entity.Models.GuzergahShort> GetGuzergahList(ReportParams.GuzergahShortFilter rptParams) {
            return GuzergahFlow.GetGuzergahList(rptParams);
        }
        //-->
        public Entity.Models.GuzergahS GetGuzergahById(Guid vlGuzergahId) {
            return GuzergahFlow.GetGuzergahById(vlGuzergahId);
        }

        public void AddGuzergah(SrvGuzergah vlGuzergah) {
            GuzergahFlow.AddGuzergah(vlGuzergah);
        }

        public void EditGuzergah(SrvGuzergah vlGuzergah) {
            GuzergahFlow.EditGuzergah(vlGuzergah);
        }

        public void DeleteGuzergah(Guid vlId) {
            GuzergahFlow.DeleteGuzergah(vlId);
        }

        #endregion Guzergah

        #region Sms
        public void SmsGonder(string telNo, string mesaj) {
            SmsFlow.SmsGonder(telNo, mesaj);
        }
        #endregion Sms

        #region Sofor
        public List<Entity.Models.ComboItem> Sofor_GetCombo() {
            return SoforFlow.GetCombo();
        }
        #endregion Sofor

        #region Hostes
        public List<Entity.Models.ComboItem> Hostes_GetCombo() {
            return HostesFlow.GetCombo();
        }
        #endregion Hostes

        #region Araç
        public List<Entity.Models.ComboItem> Arac_GetCombo() {
            return AracFlow.GetCombo();
        }

        public List<Entity.Models.AracShort> Arac_GetAracList(Entity.Models.ReportParams.AracShortFilter rptParams) {
            return AracFlow.GetAracList(rptParams);
        }

        public Entity.Models.AracS Arac_GetAracById(int vlAracId) {
            return AracFlow.GetAracById(vlAracId);
        }

        public void AddArac(SrvArac vlArac) {
            AracFlow.AddArac(vlArac);
        }

        public void EditArac(SrvArac vlArac) {
            AracFlow.EditArac(vlArac);
        }

        public void DeleteArac(int vlId) {
            AracFlow.DeleteArac(vlId);
        }
        #endregion Araç

        #region Tedarikçi

        public List<TedarikciShort> GetTedarikciList(ReportParams.TedarikciShortFilter rptParams) {
            return TedarikciFlow.GetTedarikciList(rptParams);
        }

        public TedarikciS GetTedarikciById(Guid vlId) {
            return TedarikciFlow.GetTedarikciById(vlId);
        }

        public void AddTedarikci(SrvTedarikci vlObj) {
            TedarikciFlow.AddTedarikci(vlObj);
        }

        public void EditTedarikci(SrvTedarikci vlObj) {
            TedarikciFlow.EditTedarikci(vlObj);
        }

        #endregion Tedarikçi

    }
}
