using System;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortOutDetailsSN
    {
        [MessageBodyMember(Name = "requestId")]
        public PortingRequestID RequestId { get; set; }

        [MessageBodyMember(Name = "serviceID")]
        public ProductServiceID ServiceID { get; set; }

        [MessageBodyMember(Name = "donor")]
        public PortingDonor Donor { get; set; }

        [MessageBodyMember(Name = "recipient")]
        public string Recipient { get; set; }

        [MessageBodyMember(Name = "prevPortingRefernceID")]
        [StringLength(24, ErrorMessage = "String length should be less than 25.")]
        public string PrevPortingRefernceID { get; set; }

        [MessageBodyMember(Name = "portingTransferDateTime")]
        public DateTime PortingTransferDateTime { get; set; }

        [MessageBodyMember(Name = "portingApprovalDateTime")]
        public DateTime PortingApprovalDateTime { get; set; }

        [MessageBodyMember(Name = "paymentCategory")]
        [StringLength(10, ErrorMessage = "String length should be less than 11.")]
        public string PaymentCategory { get; set; }

        [MessageBodyMember(Name = "individual")]
        public IndividualPorting Individual { get; set; }

        [MessageBodyMember(Name = "organization")]
        public OrganizationPorting Organization { get; set; }

    }
}