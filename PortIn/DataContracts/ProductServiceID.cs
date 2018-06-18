using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class ProductServiceID
    {
        [MessageBodyMember]
        [StringLength(255, ErrorMessage = "String length should be less than 256.")]
        [Description("The users means to identify a Product. For example a mobile telephone number, an e-mail address, an IP address. Not all Products have users")]
        public string serviceID { get; set; }
    }
}