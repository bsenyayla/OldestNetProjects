using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Kronus.Client.Common.Libs
{
    public class UiTools
    {
        public class ComboData {
            public string Deger { get; set; }
            public string Aciklama { get; set; }
        }

        public static void LoadLookUpV1(DevExpress.XtraEditors.LookUpEdit lkp, object data) {
            lkp.Properties.DataSource = data;
            lkp.Properties.ValueMember = "Deger";
            lkp.Properties.DisplayMember = "Aciklama";

            if (lkp.Properties.Columns.Count == 0) {
                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Deger",
                    Visible = false
                });

                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Aciklama",
                    Visible = true,
                    Caption = "Açıklama"
                });
            }
        }

        public static void LoadLookUp(DevExpress.XtraEditors.LookUpEdit lkp, List<ComboData> data,string displayText) {
            lkp.Properties.DataSource = data;
            lkp.Properties.ValueMember = "Deger";
            lkp.Properties.DisplayMember = "Aciklama";

            
            if (lkp.Properties.Columns.Count == 0) {
                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Deger",
                    Visible = false
                });

                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Aciklama",
                    Visible = true,
                    Caption = "Açıklama"
                });
            }

            if (lkp.EditValue == null || lkp.EditValue.ToString()=="") {
                lkp.ItemIndex = 0;
            }

            if (displayText != "") {
                lkp.Properties.NullText = displayText;
            }
        }

        public static void LoadLookUp(DevExpress.XtraEditors.LookUpEdit lkp, List<ComboData> data, string displayText,object selectedValue) {
            lkp.Properties.DataSource = data;
            lkp.Properties.ValueMember = "Deger";
            lkp.Properties.DisplayMember = "Aciklama";
            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo
            {
                FieldName = "Deger",
                Visible = false
            });

            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo
            {
                FieldName = "Aciklama",
                Visible = true,
                Caption = "Açıklama"
            });

            if (lkp.EditValue == null || lkp.EditValue.ToString() == "") {
                lkp.EditValue = selectedValue;
            }

            if (displayText != "") {
                lkp.Properties.NullText = displayText;
            }
        }

        public static void LoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit lkp, object data, object selectedVal) {
            lkp.Properties.DataSource = data;
            lkp.Properties.ValueMember = "Deger";
            lkp.Properties.DisplayMember = "Aciklama";
            
            if (lkp.Properties.Columns.Count == 0) {
                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Deger",
                    Visible = false
                });

                lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                    FieldName = "Aciklama",
                    Visible = true,
                    Caption = "Açıklama"
                });
            }

            lkp.EditValue = selectedVal;
            //lkp.Properties.Columns["Deger"].Visible = false;
            //lookUpEdit1.EditValue = lookUpEdit1.Properties.GetDataSourceValue(lookUpEdit1.Properties.ValueMember, 0);
        }
        
        public static void LoadLookUpFromString(DevExpress.XtraEditors.LookUpEdit lkp, string data, string displayText) {
            List<ComboData> dataCombo = new List<ComboData>();

            foreach (string strA in data.Split('|')) {
                dataCombo.Add(new ComboData { Aciklama = strA.Split(';')[0], Deger = strA.Split(';')[1] });
            }


            lkp.Properties.DataSource = dataCombo;
            lkp.Properties.ValueMember = "Deger";
            lkp.Properties.DisplayMember = "Aciklama";
            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                FieldName = "Deger",
                Visible = false
            });

            lkp.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo {
                FieldName = "Aciklama",
                Visible = true,
                Caption = "Açıklama"
            });
            lkp.ItemIndex = 0;
            lkp.Properties.NullText = displayText;

        }

        public static Guid? GetLookUpEditValue(DevExpress.XtraEditors.LookUpEdit lkp) {
            if (lkp.EditValue!=null) {
                if (lkp.EditValue.ToString() == "") {
                    return null;
                }
                else {
                    return new Guid(lkp.EditValue.ToString());
                }
            }
            else {
                return null;
            }
        }

        public static void SetLookUpEditValue(DevExpress.XtraEditors.LookUpEdit lkp,object vl) {
            if (vl != null) {
                lkp.EditValue = vl.ToString();
            }
            else {
                lkp.EditValue = null;
            }
        }

        public static DateTime? GetDateEditValue(DevExpress.XtraEditors.DateEdit de) {
            if (de.EditValue != null) {
                return Convert.ToDateTime(de.EditValue);
            }
            else {
                return null;
            }
        }

        public static string GetString(object input) {
            if (input == null) {
                return "";
            }
            try {
                return (input.ToString().ToCleanString().Trim());
            }
            catch {
                return "";
            }
        }

        public static bool GetBoolean(object input) {
            try { return (Convert.ToBoolean(input)); }
            catch { return false; }
        }

        public static bool? GetBoolean(object input, bool forNullable) {
            bool? x=null;

            if (input == "") {
                x = null;
            }
            else {
                try { 
                    x = Convert.ToBoolean(input); 
                }
                catch { 
                }
            }

            return x;
        }

        public static Int16 GetInt16(object input) {
            try { return Int16.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int16? GetInt16(object input, bool forNullable) {
            Int16? x;

            try { x = Int16.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        public static Int32 GetInt32(object input) {
            try { return Int32.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int32? GetInt32(object input, bool forNullable) {
            int? x;

            try { x = Int32.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        public static Int64 GetInt64(object input) {
            try { return Int64.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int64? GetInt64(object input, bool forNullable) {
            long? x;

            try { x = Int64.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        public static Double GetDouble(object input) {
            try { return Convert.ToDouble(input.ToString()); }
            catch { return 0; }
        }

        public static DateTime? GetDateTime(object input) {
            try { return (DateTime.Parse(input.ToString())); }
            catch { return null; }
        }

        public static DateTime GetDateTime(object input, bool forNullable) {
            try { return (DateTime.Parse(input.ToString())); }
            catch { return new DateTime(0, 0, 0, 0, 0, 0); }
        }

        public static Decimal GetDecimal(object input) {
            try { return Decimal.Parse(input.ToString().Replace('.', ',')); }
            catch { return 0; }
        }

        public static Decimal? GetDecimal(object input, bool forNullable) {
            try { return Decimal.Parse(input.ToString().Replace('.', ',')); }
            catch { return null; }
        }

        public static Guid? GetGuid(object input, bool forNullable) {
            if (input != null) {
                if (input.ToString() == "") {
                    return null;
                }
                else {
                    return new Guid(input.ToString());
                }
            }
            else {
                return null;
            }
        }

        public static bool IsEmail(string inputEmail) {
            if (string.IsNullOrEmpty(inputEmail))
                return false;
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            return re.IsMatch(inputEmail);
        }

        public static bool TcDogrula(string tcKimlikNo) {
            var returnvalue = false;

            try {
                Convert.ToInt64(tcKimlikNo);
            }
            catch {
                return false;
            }

            if (tcKimlikNo.Length == 11) {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C2 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C3 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C4 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C5 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C6 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C7 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C8 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                C9 = ATCNO % 10;
                ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }

        public static string GetArg(string query, string key) {
            var x = Regex.Match(query, key + "=([^&#]*)");
            return x.Groups[1].Value;
        }
    }
}
