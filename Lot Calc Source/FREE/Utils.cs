using System;
using System.Collections.Generic;
using System.Text;

namespace FREE
{
    class Utils
    {
        public static string GetLayoutPath()
        {
            string strLayoutPath = Environment.CurrentDirectory.ToString();
                //System.Environment.GetFolderPath(Environment.CurrentDirectory).ToString();
            strLayoutPath = strLayoutPath.Replace("\\", "/");

            return strLayoutPath;
        }

    }
}
