using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortIn.DataContracts
{

    public class SDPStatusFault
    {
        public string statusCode { get; set; }
        public string consumerReferenceID { get; set; }
        public string transactionID { get; set; }
        public DateTime statusTime { get; set; }
        public SDPStatusLine sdpStatusLine { get; set; }
    }
    
}