using System.Runtime.Serialization;

namespace PortIn.DataContracts
{
    [DataContract]
    public class ProductServiceID
    {
        [DataMember]
        public string Id { get; set; }
    }
}