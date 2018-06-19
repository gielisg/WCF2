using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingDonor
    {
        [MessageBodyMember]
        [StringLength(5, ErrorMessage = "String length should be less than 6.")]
        public string Id { get; set; }
    }
}