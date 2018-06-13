using PortIn.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PortIn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IManageportingPort" in both code and config file together.
    [ServiceContract]
    public interface IManageportingPort
    {
        [OperationContract]
        [FaultContract(typeof(SDPStatusFault),Name = "connectServiceFault",Namespace ="sgc")]
        ConnectServiceResponse ConnectService(ConnectService Request);


    }
}
