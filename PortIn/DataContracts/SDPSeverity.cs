using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PortIn.DataContracts
{
    [DataContract]
    public enum SDPSeverity
    {
        [EnumMember]
        SUCCESS,
        [EnumMember]
        ERROR,
        [EnumMember]
        WARNING,
        [EnumMember]
        CRITICAL,
        [EnumMember]
        INFO
    }
}