using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemCached.Caching {
    public static class CacheFactory {
        private static readonly ICache _mem = new MemCache();


        public static string ActiveString {
            get {
                return " ";
            }
        }

        public static ICache ActiveCache {
            get {
                return _mem;
            }
        }



        public static void Test() {
            
            string x1=  _mem.CacheTest("s");

        }

    }


}
