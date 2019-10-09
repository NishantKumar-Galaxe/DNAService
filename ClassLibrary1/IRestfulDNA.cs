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
    interface IRestfulDNA
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/PayBill/{PayId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string RequestReplyOperation_Rest();
    }
}
