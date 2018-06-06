using PortIn.DataContracts;
using System;
using System.ServiceModel;

namespace PortIn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PortInNotification" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PortInNotification.svc or PortInNotification.svc.cs at the Solution Explorer and start debugging.
    public class PortInNotification : IPortInNotification
    {
        public PortingResult PortInNotificationRequest(PortInNotificationRequest portInNotification)
        {
            #region validate request
            Guid output;
            if (!Guid.TryParse(portInNotification.RequestId, out output))
                throw new FaultException("The values that have been received are not able to be processed correctly. The RequestId is in the wrong format", new FaultCode("SDP_InputValidationFault"));
            if (!Guid.TryParse(portInNotification.ReferenceID, out output))
                throw new FaultException("The values that have been received are not able to be processed correctly. The ReferenceID is in the wrong format", new FaultCode("SDP_InputValidationFault"));
            if (string.IsNullOrEmpty(portInNotification.ReferenceID))
                throw new FaultException("Missing value in the request, the ReferenceId is missing in the request", new FaultCode("SDP_MandatoryParameterMissing"));
            if (portInNotification.ReferenceID == Guid.Empty.ToString())
                throw new FaultException("The RefernceId could not be found in the BSS", new FaultCode("SDP_EntityNotFound"));
            #endregion validate request
            try
            {
                PortingResult portingResult;
                


                //success
                if (portInNotification.ServiceId == "1")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNVAL, ReasonText = "Porting request has been accepted by CNPMS successfully and the application should await the next confirmation." };
                //failiure
                else if (portInNotification.ServiceId == "2")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNINV, ReasonText = "Porting request has not been validated correctly. This error should be raised and the porting request should be cancelled." };
                //failiure
                else if (portInNotification.ServiceId == "3")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNWIN, ReasonText = "Have not received a response from the donor. Awaiting response so shall trigger an extension to the waiting" };
                //success
                else if (portInNotification.ServiceId == "4")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNCON, ReasonText = "The porting has been approved by the donor and the BSS should wait to connect." };
                //failiure
                else if (portInNotification.ServiceId == "5")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNREJ, ReasonText = "The porting has been rejected by the donor and the BSS should cancel the porting request." };
                //success
                else if (portInNotification.ServiceId == "6")
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNCAN, ReasonText = "The cancellation request has been successful and the porting should be cancelled" };
                //failiure
                else
                    portingResult = new PortingResult() { ResponseCode = ResponseCode.PNCNT, ReasonText = "The cancellation request has not been successful and the application should generate an error and cancel the porting." };


                return portingResult;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("SDP_GeneralProviderError"));

            }
        }
    }
}

