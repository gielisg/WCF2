using System.Runtime.Serialization;


namespace PortIn.DataContracts
{
    [DataContract]
    public class PortingResult
    {
        [DataMember]
        public ResponseCode ResponseCode {get; set;}
        [DataMember]
        public string RejectionCode {get; set;}
        [DataMember]
        public string ReasonText {get; set; }
    }

   

}