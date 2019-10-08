using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    public class SimpleService : ISimpleService
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} processing request at {DateTime.Now}");
        }

        public string GetMessage()
        {
            return "Hello GxService, I am here";
        }

        public void OneWayOperationDemo()
        {
            Thread.Sleep(1000);
            return;
        }

        public string RequestReplyOperation()
        {
            DateTime dtStart = DateTime.Now;
            Thread.Sleep(2000);
            DateTime dtEnd = DateTime.Now;

            return dtEnd.Subtract(dtStart).Seconds.ToString() + " seconds processing time";
        }
    }
}
