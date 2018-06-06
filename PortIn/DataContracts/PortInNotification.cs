using System;
using System.Runtime.Serialization;

namespace PortIn.DataContracts
{
    [DataContract]
    public class PortInNotificationRequest
    {
        [DataMember(IsRequired = true)]
        public string ReferenceID {get; set;}

        [DataMember(IsRequired = true)]
        public string RequestId {get; set; }

        [DataMember(IsRequired = true)]
        public string ServiceId { get; set; }

        [DataMember]
        public PortingResult PortingResult { get; set; }

        [DataMember]
        public PortingDonor Donor { get; set; }

        [DataMember]
        public DateTime OrderedApprovalTime {get; set;}

        [DataMember]
        public DateTime RecommendTransferTime {get; set;}
    }

}