using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public static class EmployeeData
    {
        static List<EmployeeDetails> list;
        static EmployeeData()
        {
            list = new List<EmployeeDetails>();
        }

        public static void AddEmploeeDetails(int count, int addressCount)
        {
            for (int index = 0; index < count; index++)
            {
                var emp = new EmployeeDetails(count, $"Sample Name { count}", $" Sample Department {count}");

                for (int a = 0; a < addressCount; a++)
                {
                    emp.AddressList.Add(new EmployeeAddress(a, index, $" House Number {a}", $" Address line one for testing {a}", $" Address line two for testing {a}", "City Sample", "GOA", "India"));
                }

                list.Add(emp);
            }
        }

        public static List<EmployeeDetails> GetAllEmploees()
        {
            //Create a seprate list to return
            var lst = new List<EmployeeDetails>();
            foreach (var item in list)
            {
                lst.Add(item.GetDeepCopy());
            }
            return lst;
        }
    }
}
