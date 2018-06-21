using System;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class PortingDetailsSN
    {
        [MessageBodyMember(Name = "request")]
        public PortingRequestID Request { get; set; }

        [MessageBodyMember(Name = "donor")]
        public PortingDonor Donor { get; set; }

        [MessageBodyMember(Name = "recipient")]
        [StringLength(3, ErrorMessage = "String length should be less than 4.")]
        public string Recipient { get; set; }

        [MessageBodyMember(Name = "prevPortingRefernceID")]
        [StringLength(24, ErrorMessage = "String length should be less than 25.")]
        public string PrevPortingRefernceID { get; set; }

        [MessageBodyMember(Name = "byLOA")]
        [StringLength(1, ErrorMessage = "String length should be less than 2.")]
        public string ByLOA { get; set; }

        [MessageBodyMember(Name = "UndertakingAck")]
        [StringLength(1, ErrorMessage = "String length should be less than 2.")]
        public string UndertakingAck { get; set; }

        [MessageBodyMember(Name = "portingTransferDateTime")]
        public DateTime PortingTransferDateTime { get; set; }

        [MessageBodyMember(Name = "portingApprovalDateTime")]
        public DateTime PortingApprovalDateTime { get; set; }

        [MessageBodyMember(Name = "paymentCategory")]
        [StringLength(10, ErrorMessage = "String length should be less than 11.")]
        public string PaymentCategory { get; set; }

        [MessageBodyMember(Name = "routeNumber")]
        [StringLength(10, ErrorMessage = "String length should be less than 11.")]
        public string RouteNumber { get; set; } 

        [MessageBodyMember(Name = "individual")]
        public IndividualPorting Individual { get; set; }

        [MessageBodyMember(Name = "organization")]
        public OrganizationPorting Organization { get; set; }

        [MessageBodyMember(Name = "agreementSignatureDate")]
        public DateTime AgreementSignatureDate { get; set; }

    }
}