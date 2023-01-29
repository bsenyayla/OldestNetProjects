using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace ASenderApp {
    public class DataType {

        private List<Prm> _data = new List<Prm>();

        public DataType() {

        }

        public void Clear() {
            _data.Clear();                            
        }

        public Prm Add {
            set {
                _data.Add(value);
            }
        }

        public void AddDataList(List<Prm> value) {
            foreach (Prm dr in value) {
                _data.Add(dr);
            }
        }

        public List<Prm> Data { 
            get{
                return _data;
            }
            set {
                _data = value;
            }
        }


    }

    public struct Prm {
        public string PrmName { get; set; }
        public string PrmValue { get; set; }
        public string PrmType { get; set; }
    }
}


