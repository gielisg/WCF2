using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingResult
    {
        [MessageBodyMember]
        public PortInNotificationResultCode ResponseCode { get; set; }
    }
}