using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    
    [MessageContract]
    public class ConnectService
    {
        [MessageHeader(Name = "sdpServiceHeaders")]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember]
        public PortingRequestID RequestId { get; set; }

        [MessageBodyMember]
        public ServiceInfo ServiceDetailElement { get; set; }

    }

    [MessageContract]
    public class ServiceInfo
    {
        /// <summary>
        /// Unique ID for the portability request
        /// </summary>
        [MessageBodyMember]
        public PortingReferenceID ReferenceId { get; set; }
        /// <summary>
        /// Service number (for example: mobile number)
        /// </summary>
        [MessageBodyMember]
        public ProductServiceID ServiceID { get; set; }
    }
}