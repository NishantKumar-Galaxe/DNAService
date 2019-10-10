using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLaer
{

    [DataContract]
    public class EmployeeDetails
    {
        public int id; //data member or instance variable    
        public string name; //data member or instance variable 
        public string department; //data member or instance variable  
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }
        public List<EmployeeAddress> AddressList { get; set; }

        public EmployeeDetails(int _id, string _name, string _department)
        {
            id = _id;
            name = _name;
            department = _department;
            AddressList = new List<EmployeeAddress>();
        }

        public EmployeeDetails GetDeepCopy()
        {
            return new EmployeeDetails(id, name, department);
        }
    }

    [DataContract]
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Country { get; set; }
        public EmployeeAddress(int id, int employeeId, string houseNumber, string addressLine1, string addressLine2, string cityName, string stateName, string country)
        {
            Id = id;
            EmployeeId = employeeId;
            HouseNumber = houseNumber;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            CityName = cityName;
            StateName = stateName;
            Country = country;
        }

        public EmployeeAddress GetDeepCopy()
        {
            return new EmployeeAddress(Id, EmployeeId, HouseNumber, AddressLine1, AddressLine2, CityName,StateName, Country);
        }

    }
}
