using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortInNotification
    {
        [MessageHeader(Name = "sdpServiceHeaders")]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember(Name = "portingRefernceID")]
        public PortingRefernceID PortingRefernceID { get; set; }
        
        [MessageBodyMember(Name = "portingRequestID ")]
        public PortingRequestID PortingRequestID { get; set; }

        [MessageBodyMember(Name = "productServiceID ")]
        public ProductServiceID ProductServiceID { get; set; }

        [MessageBodyMember(Name = "portingResult")]
        public PortingResult PortingResult { get; set; }

        [MessageBodyMember(Name = "donor")]
        public PortingDonor Donor { get; set; }

        [MessageBodyMember(Name = "orderedApprovalTime")]
        public DateTime OrderedApprovalTime { get; set; }

        [MessageBodyMember(Name = "recommendTransferTime")]
        public DateTime RecommendTransferTime { get; set; }

    }

}