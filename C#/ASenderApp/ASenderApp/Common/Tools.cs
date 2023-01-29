using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASenderApp.Common {
    public class Tools {
        public static string GenerateString(int length) {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++) {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }



    }
}
