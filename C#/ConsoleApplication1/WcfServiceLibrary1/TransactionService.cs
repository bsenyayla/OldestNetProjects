using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceLibrary1 {
    public class TransactionService : ITransactionService {
        public CollectResponse Collect(CollectRequest request) {
            return new CollectResponse {
                Total = request.Param1 + request.Param2
            };
        }
    }
}
