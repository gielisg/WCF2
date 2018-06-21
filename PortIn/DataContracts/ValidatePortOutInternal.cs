using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class ValidatePortOutInternal
    {
        [MessageHeader(Name = "sdpServiceHeaders")]
        public SDPServiceHeaders sdpServiceHeaders { get; set; }

        [MessageBodyMember(Name = "referenceId")]
        [StringLength(24, ErrorMessage = "String length should be less than 25.")]
        public string ReferenceId { get; set; }

        [MessageBodyMember(Name = "serviceID")]
        [StringLength(20, ErrorMessage = "String length should be less than 21.")]
        public string ServiceID { get; set; }

        [MessageBodyMember(Name = "portingDetails")]
        public PortingDetailsSN PortingDetails { get; set; }
    }
  
}