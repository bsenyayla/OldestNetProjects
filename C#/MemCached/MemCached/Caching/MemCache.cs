using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemCached.Caching {
    public class MemCache : ICache {
        public MemCache() {
        }

        public string CacheTest(string key) {
            return "Çalışıyorum......";
        }

        public bool Exists(string key) {
            return true;
        }

        public bool ExistsExists(string key) {
            return true;
        }
    }
}
