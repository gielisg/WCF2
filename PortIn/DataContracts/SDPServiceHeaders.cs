using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract(WrapperName = "sdpServiceHeaders")]
    public class SDPServiceHeaders
    {
        [MessageBodyMember]
        public string applicationIdentity { get; set; }
        [MessageBodyMember]
        public string systemIdentity { get; set; }
        [MessageBodyMember]
        public string consumerReferenceId { get; set; }
        [MessageBodyMember]
        public DateTime consumerReferenceDateTime { get; set; }
        [MessageBodyMember]
        public string csrIdentity { get; set; }
        [MessageBodyMember]
        public string userIdentity { get; set; }
        [MessageBodyMember]
        public string languageCode { get; set; }
        [MessageBodyMember]
        public string countryCode { get; set; }
    }
}