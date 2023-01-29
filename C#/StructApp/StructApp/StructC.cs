using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructApp {
    public struct StructC {
        public char ad = new char[20];
        public char soyad = new char[10];
        public long no;
        private  short sinif;


        public short SetSinif {
            get {
                return sinif;                
            }
            set {
                sinif = value;
            }
        }


        public string GetName() {
            return "sdf";
        }
    }
}
