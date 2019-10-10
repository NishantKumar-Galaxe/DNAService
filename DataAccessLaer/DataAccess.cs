using DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DataAccessLayer
{
    public class DataAccess : BaseRepository
    {
        public List<Employee> GetEmployeeList()
        {
            List<Employee> list = new List<Employee>();
            using (IDbConnection connection = SqlOpenConnection())
            {
                var resultData = connection.Query<Employee>("select * from Employees", null, null, true, null, CommandType.Text);
                if (resultData != null & resultData.Count() > 0)
                    list = resultData.ToList<Employee>();
            }
            return list;
        }

        public List<Customer> GetCustomerList()
        {
            List<Customer> list = new List<Customer>();
            using (IDbConnection connection = SqlOpenConnection())
            {
                var resultData = connection.Query<Customer>("select * from Customers", null, null, true, null, CommandType.Text);
                if (resultData != null & resultData.Count() > 0)
                    list = resultData.ToList<Customer>();
            }
            return list;
        }

        /*
        public List<CurrencyCodes> GetCurrencyList()
        {
            List<CurrencyCodes> _currencyList = new List<CurrencyCodes>();
            using (IDbConnection connection = OpenConnection(DBConnectionType.Custom))
            {
                var resultData = connection.Query<CurrencyCodes>("[PMT].[uspGetCurrencyList]", null, null, true, null, CommandType.StoredProcedure);
                if (resultData != null & resultData.Count() > 0)
                    _currencyList = resultData.ToList<CurrencyCodes>();
            }
            return _currencyList;
        }

        public string SaveInvestmentBudgetDetails(InvestmentFinancialDetails details)
        {
            string result = "";
            try
            {
                using (SqlConnection connection = SqlOpenConnection(DBConnectionType.Custom))
                {
                    XElement dataXML = null;
                    if (details.AllDataValues != null)
                    {
                        dataXML = new XElement("root",
                        from obj in details.AllDataValues
                        select new XElement("Budget",
                            new XElement("EconomicModelId", obj.EconomicModelId),
                            new XElement("FinancialMonth", obj.FinancialMonth),
                            new XElement("FinancialYear", obj.FinancialYear),
                            new XElement("Amount", obj.Amount),
                            new XElement("AmountInQuarter", obj.AmountInQuarter)
                            ));
                    }

                    using (SqlCommand cmd = new SqlCommand("PMT.uspSaveInvestmentBudgetDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@investmentId", SqlDbType.Int).Value = details.InvestmentId;
                        cmd.Parameters.AddWithValue("@BudgetMode", SqlDbType.VarChar).Value = details.BudgetMode;
                        cmd.Parameters.AddWithValue("@BudgetStatus", SqlDbType.VarChar).Value = details.BudgetStatus;
                        cmd.Parameters.AddWithValue("@dataXML", SqlDbType.NVarChar).Value = dataXML != null ? Convert.ToString(dataXML) : null;
                        cmd.Parameters.AddWithValue("@CreatedBy", SqlDbType.VarChar).Value = details.createdBy;
                        var count = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;

        }
        */
    }
}
