using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kronus.Client.Common.Libs {
    public static class Helpers {

        public static string ToSeoUrl(this string url) {
            string cleanUrl = (url ?? "").ToLower();
            cleanUrl = Regex.Replace(cleanUrl, @"\&+", "and");
            cleanUrl = cleanUrl.Replace("'", "");
            cleanUrl = Regex.Replace(cleanUrl, @"[^a-z0-9ğüşöçıİĞÜŞÖÇ]", "-");
            cleanUrl = Regex.Replace(cleanUrl, @"-+", "-");
            cleanUrl = cleanUrl.Trim('-');
            cleanUrl = cleanUrl.Replace("[", "");
            cleanUrl = cleanUrl.Replace("]", "");
            cleanUrl = cleanUrl.Replace("(", "");
            cleanUrl = cleanUrl.Replace(")", "");
            cleanUrl = cleanUrl.Replace("ğ", "g");
            cleanUrl = cleanUrl.Replace("ü", "u");
            cleanUrl = cleanUrl.Replace("ö", "o");
            cleanUrl = cleanUrl.Replace("ş", "s");
            cleanUrl = cleanUrl.Replace("ç", "c");
            cleanUrl = cleanUrl.Replace("ı", "i");

            
            return cleanUrl;
        }



        public static string ToCleanString(this string value) {
            if (string.IsNullOrEmpty(value))
                return "";

            value = value.Replace("&Uuml;", "Ü");
            value = value.Replace("&Ccedil;", "Ç");
            value = value.Replace("&Ouml;", "Ö");
            value = value.Replace("&uuml;", "ü");
            value = value.Replace("&ccedil;", "ç");
            value = value.Replace("&ouml;", "ö");

            value = value.Replace("Ãœ", "Ü");
            value = value.Replace("Å", "Ş");
            value = value.Replace("Ä", "Ğ");
            value = value.Replace("Ã‡", "Ç");
            value = value.Replace("Ä°", "İ");
            value = value.Replace("Ã–", "Ö");
            value = value.Replace("Ã¼", "ü");
            value = value.Replace("ÅŸ", "ş");
            value = value.Replace("ÄŸ", "ğ");
            value = value.Replace("Ã§", "ç");
            value = value.Replace("Ä±", "ı");
            value = value.Replace("Ã¶", "ö");
            value = value.Replace("Ã¢", "â");
            return value;
        }

  

       
    }
}
