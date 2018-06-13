using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class ExtendedResponse
    {
        [MessageBodyMember]
        public string RequestId { get; set; }
        [MessageBodyMember]
        public string ReferenceId { get; set; }

        [MessageBodyMember]
        public DateTime RequestDateTime { get; set; }

        [MessageBodyMember]
        public DateTime ResponseDateTime { get; set; }
        [MessageBodyMember]
        public string Results { get; set; }
    }
}