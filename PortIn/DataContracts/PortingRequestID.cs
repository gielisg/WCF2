using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingRequestID
    {
        [MessageBodyMember]
        [StringLength(12, ErrorMessage = "String length should be less than 13.")]
        public string Id { get; set; }
    }
}