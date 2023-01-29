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
    public class SmsFlow
    {
        
        public static void SmsGonder(string telNo,string mesaj)
        {
            SendSmsFromTuratel("ctiytour", "21112013", mesaj, telNo);
        }


        private static void SendSmsFromTuratel(string username, string password, string mesaj, string telno)
        {
            string smsXml = "<MainmsgBody>" +
                    "<Command>0</Command>" +
                    "<PlatformID>1</PlatformID>" +
                    "<UserName>" + username + "</UserName>" +
                    "<PassWord>" + password + "</PassWord>" +
                    "<ChannelCode>584</ChannelCode>" +
                    "<Mesgbody>" + mesaj + "</Mesgbody>" +
                    "<Numbers>" + telno + "</Numbers>" +
                    "<Type>1</Type>" +
                    "<Originator></Originator>" +
                    "<SDate></SDate>" +
                    "<EDate></EDate>" +
                    "<Concat>1</Concat>" +
                    "</MainmsgBody>";

            string gonderilecekAdres = @"https://processor.smsorigin.com/xml/process.aspx";

            System.Net.WebRequest wreq = System.Net.WebRequest.Create(gonderilecekAdres);

            wreq.Method = "POST";
            wreq.ContentType = "text/xml";
            System.IO.StreamWriter writer = new System.IO.StreamWriter(wreq.GetRequestStream());
            writer.Write(smsXml);
            writer.Close();

            System.Net.WebResponse wres = wreq.GetResponse();
            System.IO.StreamReader reader = new System.IO.StreamReader(wres.GetResponseStream());
            string cevap = reader.ReadToEnd();

            wreq.GetRequestStream().Close();
            wres.GetResponseStream().Close();
        }

        private static void SendSmsFromPostaGuvercini(string username, string password, string mesaj, string telno) { 
        
        }
    }
}
