using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemCached.Caching {
    public interface ICache {
        bool Exists(string key);


        string CacheTest(string key);
    }
}
