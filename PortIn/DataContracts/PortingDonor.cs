using System.Runtime.Serialization;

namespace PortIn.DataContracts
{
    [DataContract]
    public class PortingDonor
    {
        [DataMember]
        public string Id { get; set; }
    }
 
}