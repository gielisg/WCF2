﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PortIn.DataContracts
{
    [MessageContract]
    public class ProductServiceID
    {
        [MessageBodyMember]
        public string serviceID { get; set; }
    }
}