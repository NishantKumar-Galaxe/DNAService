using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DNARestService.Controllers
{
   [RoutePrefix("api/DNADirector")]
    public class DNADirectorController : ApiController
    {
        [HttpGet]
        [Route("GetEmployeeList")]
        public List<Employee> GetEmployeeList()
        {
            List<Employee> lst = new List<Employee>();
            DataAccessLayer.DataAccess data = new DataAccessLayer.DataAccess();
            lst = data.GetEmployeeList();
            return lst;

        }

        [HttpGet]
        [Route("GetCustomerList")]
        public List<Customer> GetCustomerList()
        {
            DataAccessLayer.DataAccess data = new DataAccessLayer.DataAccess();
            List<Customer> lst = data.GetCustomerList();
            return lst;

        }
    }
}