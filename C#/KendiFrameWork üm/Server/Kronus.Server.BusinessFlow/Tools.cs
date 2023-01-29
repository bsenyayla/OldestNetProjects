using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace Kronus.Server.BusinessFlow
{
    public class Tools
    {
        private static SmtpClient SykSmtpClient()
        {
            //SmtpClient MailServer = new SmtpClient("posta.syk.com.tr", 25);
            //MailServer.Credentials = new NetworkCredential("mailer@syk.com.tr", "48wtxa3c");
            SmtpClient MailServer = new SmtpClient("192.168.0.25", 25);
            MailServer.Credentials = new NetworkCredential("mailer@syk.com.tr", "48wtxa3c");
            return MailServer;
        }

        public static void SendMail(string to, string subject, string body)
        {
            List<string> tos = new List<string> { to };
            SendMail(tos, new List<string>(), new List<string>(), subject, body);
        }

        public static void SendMail(List<string> tos, string subject, string body)
        {
            SendMail(tos, new List<string>(), new List<string>(), subject, body);
        }

        public static void SendMail(List<string> tos, List<string> ccs, string subject, string body)
        {
            SendMail(tos, ccs, new List<string>(), subject, body);
        }

        public static void SendMail(List<string> tos, List<string> ccs, List<string> bccs, string subject, string body)
        {
            SmtpClient MailServer = SykSmtpClient();

            MailMessage Mail = new MailMessage();
            Mail.SubjectEncoding = System.Text.Encoding.GetEncoding(1254);
            //Mail.BodyEncoding = System.Text.Encoding.GetEncoding(1254);
            Mail.IsBodyHtml = true;
            Mail.From = new MailAddress("web@syk.com.tr", "Fusion");
            Mail.CC.Add("bsenyayla@syk.com.tr");


            foreach (var to in tos)
            {
                Mail.To.Add(new MailAddress(to));
            }

            foreach (var cc in ccs)
            {
                Mail.CC.Add(new MailAddress(cc));
            }

            foreach (var bc in bccs)
            {
                Mail.Bcc.Add(new MailAddress(bc));
            }

            Mail.Subject = subject;
            Mail.Body = body;
            MailServer.Send(Mail);
        }

        public static string FullExceptionText(Exception ex)
        {
            string srtError = "";

            srtError += @"Data:\n" + ex.Data.ToString() + "\n";
            srtError += @"HelpLink:\n" + ex.HelpLink + "\n";
            srtError += @"HResult:\n" + ex.HResult.ToString() + "\n";
            srtError += @"InnerException:\n" + (ex.InnerException != null ? ex.InnerException.ToString() : "") + "\n";
            srtError += @"Message:\n" + ex.Message.ToString() + "\n";
            srtError += @"Source:\n" + ex.Source.ToString() + "\n";
            srtError += @"StackTrace:\n" + ex.StackTrace.ToString() + "\n";
            srtError += @"TargetSite:\n" + ex.TargetSite.ToString() + "\n";

            return srtError;
        }

        public static DateTime ConvertDatetimeFromString(string StrDateTime)
        {
            string[] strAry = StrDateTime.Split('/');
            DateTime retVal = new DateTime(GetInt16(strAry[2]), GetInt16(strAry[0]), GetInt16(strAry[1]));
            return retVal;
        }

        public static Int16 GetInt16(object input)
        {
            try { return Int16.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int16? GetInt16(object input, bool forNullable)
        {
            Int16? x;

            try { x = Int16.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        public static Int32 GetInt32(object input)
        {
            try { return Int32.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int32? GetInt32(object input, bool forNullable)
        {
            int? x;

            try { x = Int32.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        public static Int64 GetInt64(object input)
        {
            try { return Int64.Parse(input.ToString()); }
            catch { return 0; }
        }

        public static Int64? GetInt64(object input, bool forNullable)
        {
            long? x;

            try { x = Int64.Parse(input.ToString()); }
            catch { x = null; }

            return forNullable ? (x == 0 ? null : x) : (x ?? 0);
        }

        #region Batches

        public static string ConvertDateToSqlFormat(DateTime date, int formatNumber)
        {
            string year = date.Year.ToString();
            string month = date.Month.ToString().PadLeft(2, '0');
            string day = date.Day.ToString().PadLeft(2, '0');
            string hour = date.Hour.ToString().PadLeft(2, '0');
            string minute = date.Minute.ToString().PadLeft(2, '0');

            if (formatNumber == 102)
            {
                return string.Format("{0}-{1}-{2} {3}:{4}", year, month, day, hour, minute);
            }
            else if (formatNumber == 104)
            {
                return string.Format("{0}.{1}.{2} {3}:{4}", day, month, year, hour, minute);
            }
            else
            {
                return date.ToShortDateString() + " " + date.ToLongTimeString();
            }
        }

        public static bool IsDataRowFieldEmpty(object dataField)
        {
            if (dataField == System.DBNull.Value)
                return true;

            if (dataField == null)
                return true;

            if (dataField is string && string.IsNullOrEmpty(dataField.ToString()))
                return true;

            return false;
        }

        public static T NullCheck<T>(object deger)
        {
            var temp = default(T);
            if (deger == System.DBNull.Value) return temp;
            else

                return (T)deger;

        }

        public static bool IsDate(object value)
        {
            try
            {
                DateTime x = Convert.ToDateTime(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetFile(string supportFileFolder, string fileName)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fullpath = path + @"\BatchClasses\SupportFiles\" + supportFileFolder;
            string fileFullLocation = System.IO.Path.Combine(fullpath, fileName);
            return System.IO.File.ReadAllText(fileFullLocation, Encoding.GetEncoding(1254));
        }


        #endregion Batches
    }
}



