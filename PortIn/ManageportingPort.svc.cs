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
                var sdpStatusFault = new SDPStatusFault()
                {
                    consumerReferenceID = Request.sdpServiceHeaders.consumerReferenceId,
                    sdpStatusLine = new SDPStatusLine()
                    {
                        severity = SDPSeverity.ERROR,
                        statusCode="500",
                        statusDescription= "Reference Id is null"
                    }

                };
                throw new FaultException<SDPStatusFault>(sdpStatusFault);
            }
            //  Invalid Reference Id 
            if (Request.ServiceDetailElement.ReferenceId.Id != "VT40000287_160727")
            {
                var sdpStatusFault = new SDPStatusFault()
                {
                    consumerReferenceID = Request.sdpServiceHeaders.consumerReferenceId,
                    sdpStatusLine = new SDPStatusLine()
                    {
                        severity = SDPSeverity.ERROR,
                        statusCode = "500",
                        statusDescription = "Invalid Reference Id "
                    }

                };
                throw new FaultException<SDPStatusFault>(sdpStatusFault);
                

            }
            //  Check the MSISDN
            if (Request.ServiceDetailElement.ServiceID == null)
            {
                var sdpStatusFault = new SDPStatusFault()
                {
                    consumerReferenceID = Request.sdpServiceHeaders.consumerReferenceId,
                    sdpStatusLine = new SDPStatusLine()
                    {
                        severity = SDPSeverity.ERROR,
                        statusCode = "500",
                        statusDescription = "ServiceID is null"
                    }

                };
                throw new FaultException<SDPStatusFault>(sdpStatusFault);
            }

            //  Invalid MSISDN
            if (Request.ServiceDetailElement.ServiceID.serviceID != "98340654")
            {
                var sdpStatusFault = new SDPStatusFault()
                {
                    consumerReferenceID = Request.sdpServiceHeaders.consumerReferenceId,
                    sdpStatusLine = new SDPStatusLine()
                    {
                        severity = SDPSeverity.ERROR,
                        statusCode = "500",
                        statusDescription = "Invalid MSISDN"
                    }

                };
                throw new FaultException<SDPStatusFault>(sdpStatusFault);
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
