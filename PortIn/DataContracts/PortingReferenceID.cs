using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingRefernceID
    {
        [MessageBodyMember]
        [StringLength(24, ErrorMessage = "String length should be less than 25.")]
        public string Id { get; set; }
    }
}