using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Kronus.Server.Entity;
using System.Data.Entity;
using System.Data.EntityModel;
using Kronus.Server.Entity.Models;

namespace Kronus.Server.BusinessFlow.Crm
{
    public class IKBusinessFlow
    {
        public static List<Entity.Models.Personel> GetPersonelList()
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.Personel> rcList = new List<Entity.Models.Personel>();

                rcList = (from p in context.CrmPersonel
                          where p.IsDeleted == false &&
                                p.IsActive == true
                          select new Entity.Models.Personel
                          {
                              Ad = p.Ad,
                              Soyad = p.Soyad,
                              Id = p.Id,
                              DomainName = p.DomainName,
                              DogumTarihi = p.DogumTarihi.Value,
                              TcKimlikNo = p.TcKimlikNo,
                              MedeniHali = p.MedeniHali,
                              Adres = p.Adres,
                              Email = p.Email,
                              EmailIs = p.EmailIs,
                              TelefonNo = p.TelefonNo,
                              GsmNo = p.GsmNo,
                              TelefonNoIs = p.TelefonNoIs,
                              Cinsiyet = p.Cinsiyet,
                              ProfilFoto = p.ProfilFoto,
                              GirisTarihi = p.GirisTarihi,
                              CikisTarihi = p.CikisTarihi
                              //IkinciYonetici = "",
                              //BirinciYonetici = ""
                              //Departman = p.CrmDepartman.Ad,
                              //Bolum = p.CrmBolum.Ad,
                              //Gorev = p.CrmGorev.Ad,
                              //Firma = p.CrmFirma.Ad,
                              //FirmaLokasyon = p.CrmFirmaLokasyon.Ad
                          }

                    ).ToList();


            return rcList;
        }

        public static List<Entity.Models.PersonelShort> GetPersonelShortList(ReportParams.PersonelShortFilter rptParams)
        {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.PersonelShort> rcList = new List<Entity.Models.PersonelShort>();
            rcList = (from p in context.CrmPersonel
                      where p.IsDeleted == false &&
                            (p.Ad.Contains(rptParams.Ad) || rptParams.Ad=="") &&
                            (p.Soyad.Contains(rptParams.Soyad) || rptParams.Soyad=="") &&
                            (p.DepartmanId == rptParams.Departman || rptParams.Departman==null) &&
                            (p.DomainName.Contains(rptParams.DomainName) || rptParams.DomainName=="") &&
                            (p.TcKimlikNo.Contains(rptParams.TcKimlikNo) || rptParams.TcKimlikNo=="") &&
                            (rptParams.IsActive==null || p.IsActive==rptParams.IsActive)
                      orderby p.Ad
                      select new Entity.Models.PersonelShort
                      {
                          Ad = p.Ad,
                          Soyad = p.Soyad,
                          Id = p.Id,
                          //DomainName = p.DomainName,
                          //DogumTarihi = p.DogumTarihi.Value,
                          TcKimlikNo = p.TcKimlikNo,
                          Departman = p.CrmDepartman.Ad,
                          Bolum = p.CrmBolum.Ad,
                          Gorev = p.CrmGorev.Ad,
                          Firma = p.CrmFirma.Ad,
                          FirmaLokasyon = p.CrmFirmaLokasyon.Ad,
                          Durum=p.IsActive
                      }

                ).ToList();

            return rcList;
        }

        public static List<Entity.Models.ComboItem> GetPersonelListForCombo() {
            dbCrmEntities context = new dbCrmEntities();
            List<Entity.Models.ComboItem> retVal =
                            context.CrmPersonel
                            .Where(p => p.IsDeleted == false && p.IsActive == true)
                            .Select(m => m)
                            .AsEnumerable()
                            .Select(m => new Entity.Models.ComboItem
                            {
                                Aciklama = m.Ad + " " + m.Soyad,
                                Deger = m.Id.ToString()
                            })
                            .ToList();
            return retVal;
        }

        public static Personel GetPersonelById(Guid vlId)
        {
            dbCrmEntities context = new dbCrmEntities();
            return (from p in context.CrmPersonel
                    where   p.Id == vlId 
                        && p.IsDeleted == false 
                    select new Personel {
                        Id = p.Id,
                        Ad=p.Ad,
                        Adres=p.Adres,
                        BirinciYonetici=p.BirinciYonetici,
                        BolumId=p.BolumId,
                        CikisTarihi=p.CikisTarihi,
                        Cinsiyet=p.Cinsiyet,
                        DepartmanId=p.DepartmanId,
                        DogumTarihi=p.DogumTarihi,
                        DomainName=p.DomainName,
                        Email=p.Email,
                        EmailIs=p.EmailIs,
                        FirmaId=p.FirmaId,
                        FirmaLokasyonId=p.FirmaLokasyonId,
                        GirisTarihi=p.GirisTarihi,
                        GorevId=p.GorevId,
                        GsmNo=p.GsmNo,
                        IkinciYonetici=p.IkinciYonetici,
                        MedeniHali=p.MedeniHali,
                        ProfilFoto=p.ProfilFoto,
                        Soyad=p.Soyad,
                        TcKimlikNo=p.TcKimlikNo,
                        TelefonNo = p.TelefonNo,
                        TelefonNoIs = p.TelefonNoIs,
                        IsActive=p.IsActive,
                        CalismaSekli=p.CalismaSekli,
                        OdemeTipi=p.OdemeTipi
                    }
                ).SingleOrDefault();
        }

        public static void AddPersonel(CrmPersonel vlPersonel){
            dbCrmEntities context = new dbCrmEntities();

            try {
                vlPersonel.Id = Guid.NewGuid();
                vlPersonel.IsActive = true;
                vlPersonel.IsDeleted = false;
                vlPersonel.CreateDate = DateTime.Now;

                context.AddToCrmPersonel(vlPersonel);
                context.SaveChanges();
            }

            catch(Exception ex){
                string hata = "Data:" + ex.Data.ToString() + "İnnerException" + ex.InnerException.InnerException.ToString();
            }
        }

        public static void EditPersonel(CrmPersonel vlObj) {
            using (dbCrmEntities context = new dbCrmEntities()) {
                CrmPersonel curVal = context.CrmPersonel.Single(c => c.Id == vlObj.Id);
                vlObj.IsDeleted = curVal.IsDeleted;

                context.CrmPersonel.ApplyCurrentValues(vlObj);
                context.SaveChanges();
            }
        }

        public static DataSet GetMenu(string vlDomainName)
        {
            string SQLquery = " exec Sp_FwUtil @TranType=1 ,@DomainName='" + vlDomainName + "' ";
            DataSet ds = new DataSet("MenuDataSet");
            SqlDataAdapter myAdapter = new SqlDataAdapter(SQLquery, Util.NewKronusCrmConnection());
            myAdapter.Fill(ds, "MenuTable");
            return ds;
        }
    }
}