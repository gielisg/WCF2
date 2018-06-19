using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract(WrapperName = "sdpServiceResponseHeaders")]
    public class SDPServiceResponseHeaders
    {
        [MessageBodyMember(Name = "consumerReferenceId")]
        [System.Xml.Serialization.XmlElement(IsNullable = false)]
        public string ConsumerReferenceId { get; set; }

        [MessageBodyMember(Name = "transactionResponseDateTime")]
        [System.Xml.Serialization.XmlElement(IsNullable = false)]
        public DateTime TransactionResponseDateTime { get; set; }

        [MessageBodyMember(Name = "transactionId")]
        [System.Xml.Serialization.XmlElement(IsNullable = false)]
        public string TransactionId { get; set; }
    }
}