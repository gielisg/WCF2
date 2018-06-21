using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class ValidatePortOut
    {
        [MessageHeader(Name = "sdpServiceHeaders")]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember(Name = "referenceId")]
        public PortingRefernceID ReferenceId { get; set; }

        [MessageBodyMember(Name = "portOutDetails")]
        public PortOutDetailsSN PortOutDetails { get; set; }
    }
}