using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace UI
{
    public class errHandle: _Exception
    {
        public string HelpLink {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public Exception InnerException {
            get {
                throw new NotImplementedException();
            }
        }

        public string Message {
            get {
                throw new NotImplementedException();
            }
        }

        public string Source {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public string StackTrace {
            get {
                throw new NotImplementedException();
            }
        }

        public MethodBase TargetSite {
            get {
                throw new NotImplementedException();
            }
        }



        public Exception GetBaseException() {
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            throw new NotImplementedException();
        }
    }
}
