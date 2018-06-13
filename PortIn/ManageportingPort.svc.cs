using PortIn.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PortIn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ManageportingPort" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ManageportingPort.svc or ManageportingPort.svc.cs at the Solution Explorer and start debugging.
    public class ManageportingPort : IManageportingPort
    {
        
        public ConnectServiceResponse ConnectService(ConnectService Request)
        {
            //throw new NotImplementedException();
            ConnectServiceResponse ConnectServiceResponse = new ConnectServiceResponse();

            //  Check the Reference Id is not null
            if (Request.ServiceDetailElement.ReferenceId.Id == null)
            {
                throw new FaultException(new FaultReason("test NULL reference.Id"));
            }
            //  Invalid Reference Id 
            if (Request.ServiceDetailElement.ReferenceId.Id != "VT40000287_160727")
            {
                throw new FaultException(new FaultReason("Invalid Reference Id"));
                
            }
            //  Check the MSISDN
            if (Request.ServiceDetailElement.ServiceID == null)
            {
                throw new FaultException(new FaultReason("test NULL service.Id"));
            }

            //  Invalid MSISDN
            if (Request.ServiceDetailElement.ServiceID.serviceID != "98340654")
            {
                throw new FaultException(new FaultReason("test 98340654 service.Id"));
            }

            ConnectServiceResponse = new ConnectServiceResponse();

            ConnectServiceResponse.RequestId = Request.RequestId.Id;
            ConnectServiceResponse.ReferenceId = Request.ServiceDetailElement.ReferenceId.Id;
            ConnectServiceResponse.ResponseDateTime = DateTime.Now;
            ConnectServiceResponse.RequestDateTime = Request.sdpServiceHeaders.consumerReferenceDateTime;
            ConnectServiceResponse.Results = "SUCCESS";

            return ConnectServiceResponse;


        }

    }
}
