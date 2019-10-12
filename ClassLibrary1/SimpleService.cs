using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;


namespace ClassLibrary1
{
    //[ServiceBehavior(AddressFilterMode = AddressFilterMode.Any, ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerCall)]

    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerSession)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    public class SimpleService : ISimpleService, IReportService, IRestfulDNA
    {
        public int i;
        public SimpleService()
        {
            EmployeeData.AddEmploeeDetails(10000, 10);
        }
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

        public void ProcessReport()
        {
            throw new NotImplementedException();
        }

        public string RequestReplyOperation()
        {
            DateTime dtStart = DateTime.Now;
            Thread.Sleep(2000);
            DateTime dtEnd = DateTime.Now;

            return dtEnd.Subtract(dtStart).Seconds.ToString() + " seconds processing time";
        }

        public string RequestReplyOperation_Rest()
        {
            DateTime dtStart = DateTime.Now;
            Thread.Sleep(2000);
            DateTime dtEnd = DateTime.Now;

            return dtEnd.Subtract(dtStart).Seconds.ToString() + " seconds processing time with ";
        }

        public List<EmployeeDetails> RequestReplyOperationV1()
        {
            var employeeList = EmployeeData.GetAllEmploees();
            return employeeList;
        }

        public List<EmployeeDetails> RequestReplyOperation_RestV1()
        {
            //EmployeeData.AddEmploeeDetails(10000, 10);
            var employeeList = EmployeeData.GetAllEmploees();
            return employeeList;
        }

        public List<Customer> GetCustomerList_Rest()
        {
            DataAccess data = new DataAccess();
            return data.GetCustomerList();
        }

        public List<Customer> GetCustomerList()
        {
            DataAccess data = new DataAccess();
            return data.GetCustomerList();
        }

        public bool AddNewCustomer_Rest(Customer details)
        {
            DataAccess data = new DataAccess();
            return data.AddNewCustomer(details);
        }

        public bool AddNewCustomer(Customer details)
        {
            DataAccess data = new DataAccess();
            return data.AddNewCustomer(details);
        }

        /// <summary>
        /// This method is to test concurrency behaviour, instance mode.
        /// </summary>

        public void CheckConcurrencyBehaviour(int clientId)
        {
            i++;
            Console.WriteLine($" client {clientId} with value  {i.ToString()} is running on Thread {Thread.CurrentThread.ManagedThreadId}  processed at {DateTime.Now}");

            Thread.Sleep(5000);
        }
    }
}
