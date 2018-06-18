using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingDonor
    {
        [MessageBodyMember]
        public string Id { get; set; }
    }
}