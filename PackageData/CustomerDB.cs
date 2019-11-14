using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public static class CustomerDB
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = null;

            //initialize db connection. 
            //Environment.MachineName provides name of the machine this application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, " +
                                     "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, AgentId " +
                                     "FROM Customers";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                //initialize sqlcommand
                {
                    connection.Open();                                                          //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader())                          //initialize reader
                    {
                        while (reader.Read())                                                      //if there is data to be read
                        {
                            customer = new Customer();                                        //create customer object
                            customer.CustomerId = (int)reader["CustomerId"];                          
                            customer.CustFirstName = reader["CustFirstName"].ToString();
                            customer.CustLastName = reader["CustLastName"].ToString();
                            customer.CustAddress = reader["CustAddress"].ToString();
                            customer.CustCity = reader["CustCity"].ToString();
                            customer.CustProv = reader["CustProv"].ToString();
                            customer.CustPostal = reader["CustPostal"].ToString();
                            customer.CustCountry = reader["CustCountry"].ToString();
                            customer.CustHomePhone = reader["CustHomePhone"].ToString();
                            customer.CustBusPhone = reader["CustBusPhone"].ToString();
                            customer.CustEmail = reader["CustEmail"].ToString();
                            customer.AgentId = (int)reader["AgentId"];
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;             //return list of customers
        }
    }
}
