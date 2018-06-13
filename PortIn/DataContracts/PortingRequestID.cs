using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingRequestID
    {
        [MessageBodyMember]
        public string Id { get; set; }
    }
}