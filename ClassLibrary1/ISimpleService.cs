using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISimpleService" in both code and config file together.
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract(IsOneWay =true)]
        void DoWork();

        //Message exchange pattern, default is "RequestReply"
        //Client waits till the response returned by service i.e. WCF Service.

        [OperationContract]
        string GetMessage();

        [OperationContract]
        string RequestReplyOperation();

        //If IsOneWay is true, return type should be void.
        [OperationContract(IsOneWay = true)]
        void OneWayOperationDemo();

    }
}
