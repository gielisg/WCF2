using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    
    public class SDPStatusLine
    {
    
        public DateTime stepStatusTime { get; set; }
    
        public string processStep { get; set; }
    
        public SDPSeverity severity { get; set; }
    
        public string statusCode { get; set; }
    
        public string statusDescription { get; set; }
    
        public string providerFault { get; set; }
    
        public string traceData { get; set; }

    }
}