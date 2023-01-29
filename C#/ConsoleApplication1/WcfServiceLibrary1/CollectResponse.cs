using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceLibrary1 {
    [DataContract]
    public class CollectResponse {
        [DataMember]
        public int Total { get; set; }
    }
}
