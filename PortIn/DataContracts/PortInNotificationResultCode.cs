using System.Runtime.Serialization;
using System.ServiceModel;

namespace PortIn.DataContracts
{
    [DataContract(Name = "PortInNotificationResultCode")]
    public enum PortInNotificationResultCode
    {
        [EnumMember()]
        PNVAL,
        [EnumMember()]
        PNINV,
        [EnumMember()]
        PNCON,
        [EnumMember()]
        PNREJ,
        [EnumMember()]
        PNSCN,
        [EnumMember()]
        PNFAI,
        [EnumMember()]
        PNCAN,
        [EnumMember()]
        PNCNT,
        [EnumMember()]
        PWNCON,
        [EnumMember()]
        PWNREJ
    }
}