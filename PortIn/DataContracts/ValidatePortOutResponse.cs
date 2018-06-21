using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{

    [MessageContract]
    public class ValidatePortOutResponse : SDPResponse
    {
        [MessageHeader(Name = "sdpServiceResponseHeaders")]
        public SDPServiceResponseHeaders sdpServiceResponseHeaders { get; set; }
    }
}