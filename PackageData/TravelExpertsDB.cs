using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This is the data access class for Travel Experts database
 * Provides methodes to work with the database
 * 
 * Author: Abhilash Paul
 * Date:  16th July 2019 
 */
 
namespace PackageData
{
    public static class TravelExpertsDB
    {
        /// <summary>
        /// Connects to the Travel Experts database. Use "TravelExpertsDB.GetConnection(Environment.MachineName)" when calling the method.
        /// </summary>
        /// <param name="MachineName">name of the machine the application runs on</param>
        /// <returns> returns the connection</returns>
        public static SqlConnection GetConnection(string MachineName)       //works only if the application and server is in the same machine
        {
            string connectionString = "Data Source=" + MachineName + @"\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
