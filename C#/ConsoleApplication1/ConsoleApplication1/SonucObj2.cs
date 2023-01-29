using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class SonucObj2<T> where T : class { // Generic type sadece class türünde olsun dedik
        public string Mesaj { get; set; }
        public bool Basarili { get; set; }
        public T Data { get; set; }
    }
}
