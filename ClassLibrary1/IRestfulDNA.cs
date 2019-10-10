using DataAccessLaer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [ServiceContract]

    public interface IRestfulDNA
    {
        [OperationContract]

        [WebGet(UriTemplate = "/PayBill/", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string RequestReplyOperation_Rest();

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<EmployeeDetails> RequestReplyOperation_RestV1();

    }
}
