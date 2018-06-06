using PortIn.DataContracts;
using System.ServiceModel;

namespace PortIn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPortInNotification" in both code and config file together.
    [ServiceContract]
    public interface IPortInNotification
    {
        [OperationContract]
        PortingResult PortInNotificationRequest(PortInNotificationRequest portInNotification);
    }
}
