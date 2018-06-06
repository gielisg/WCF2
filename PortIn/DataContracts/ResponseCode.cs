using System.Runtime.Serialization;

namespace PortIn.DataContracts
{
    [DataContract]
    public enum ResponseCode
    {
        [EnumMember]
        PNVAL,
        [EnumMember]
        PNCON,
        [EnumMember]
        PNCAN,
        [EnumMember]
        PNINV,
        [EnumMember]
        PNWIN,
        [EnumMember]
        PNREJ,
        [EnumMember]
        PNCNT
    }
}