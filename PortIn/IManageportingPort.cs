using PortIn.DataContracts;
using System.ServiceModel;

namespace PortIn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IManageportingPort" in both code and config file together.
    [ServiceContract]
    public interface IManageportingPort
    {
        [OperationContract]
        [FaultContract(typeof(SDPStatusFault),Name = "connectServiceFault",Namespace ="sgc")]
        ConnectServiceResponse ConnectService(ConnectService Request);

        [OperationContract]
        [FaultContract(typeof(SDPStatusFault), Name = "portInNotificationFault", Namespace = "sgc")]
        PortInNotificationResponse PortInNotification(PortInNotification Request);

        [OperationContract]
        [FaultContract(typeof(SDPStatusFault), Name = "validatePortOutFault", Namespace = "sgc")]
        ValidatePortOutResponse ValidatePortOut(ValidatePortOut Request);

        [OperationContract]
        [FaultContract(typeof(SDPStatusFault), Name = "validatePortOutInternalFault", Namespace = "sgc")]
        ValidatePortOutInternalResponse validatePortOutInternal(ValidatePortOutInternal Request);

    }
}
