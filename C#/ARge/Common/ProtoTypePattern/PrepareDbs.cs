using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class PrepareDbs
    {
        public  PrepareDbs() {

            DatabasePrototypePattern dbMsSql = new DatabasePrototypePattern();


            //bu şekilde yeni obje oluşturarak 
            //new maliyetini kurtarmış oluyoruz.
            DatabasePrototypePattern MongoDb = (DatabasePrototypePattern)dbMsSql.Clone();

        }


    }
}
