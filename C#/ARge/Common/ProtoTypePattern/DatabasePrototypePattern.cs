using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DatabasePrototypePattern
    {
        private string _dbConnectionStr = "";

        public string SetConnectionStr {
            set;
            get;
        }

        public Object Clone() {
            return this.Clone();
        }

    }
}
