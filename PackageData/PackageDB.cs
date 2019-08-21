using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is the data access class for travel package entity.
 * All the properties except package id, package name and base price can be set to null.
 * 
 * Author: Abhilash Paul
 * Date:  26th July 2019 
 */

namespace PackageData
{
    public static class PackageDB
    {
        /// <summary>
        /// Retrieves all the packages
        /// </summary>
        /// <returns> the package listcreated using retrieved order information</returns>
        public static List<Package> GetPackage()
        {
            //List to store all the packages
            List<Package> packages = new List<Package>();

            //Package object
            Package pkg = null;

            //initialize db connection. 
            //Environment.MachineName provides name of teh machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT PackageId, PkgName, PkgDesc, PkgStartDate, " +
                                     "PkgEndDate, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                //initialize sqlcommand
                {                                            
                    connection.Open();                                                          //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader())                          //initialize reader
                    {
                        while (reader.Read())                                                      //if there is data to be read
                        {
                            pkg = new Package();                                                //create package object
                            pkg.PackageID = (int)reader["PackageId"];                           //get the package id
                            pkg.PackageName = reader["PkgName"].ToString();                     //get the package name
                            pkg.BasePrice = (Decimal)reader["PkgBasePrice"];                    //get the package base price

                            // for the columns that can be null, determine if returns null from data base and set the variables accordingly
                            pkg.PackageDesc = Convert.IsDBNull(reader["PkgDesc"]) ? "" : reader["PkgDesc"].ToString();
                            pkg.StartDate = Convert.IsDBNull(reader["PkgStartDate"]) ? (DateTime?)null : (DateTime)reader["PkgStartDate"];
                            pkg.EndDate = Convert.IsDBNull(reader["PkgEndDate"]) ? (DateTime?)null : (DateTime)reader["PkgEndDate"];
                            pkg.AgencyCommission = Convert.IsDBNull(reader["PkgAgencyCommission"]) ? (decimal?)null : (decimal)reader["PkgAgencyCommission"];
                            packages.Add(pkg);
                        }
                    }
                }
            }
            return packages;             //return list of package objects
        }

        /// <summary>
        /// Retrieves details of the apckage with the specified package id
        /// </summary>
        /// <param name="orderID"> speciified package id</param>
        /// <returns> the package object created using retrieved order information</returns>
        public static Package GetPackage(int packageID)
        {
            Package pkg = null;
            //initialize db connection. 
            //Environment.MachineName provides name of teh machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT PackageId, PkgName, PkgDesc, PkgStartDate, " +
                                     "PkgEndDate, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " +
                                     "WHERE PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                //initialize sqlcommand
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageID);                       // data bind order id                                              
                    connection.Open();                                                          //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader())                          //initialize reader
                    {
                        if (reader.Read())                                                      //if there is data to be read
                        {
                            pkg = new Package();                                                //create package object
                            pkg.PackageID = (int)reader["PackageId"];                           //get the package id
                            pkg.PackageName = reader["PkgName"].ToString();                     //get the package name
                            pkg.BasePrice = (Decimal)reader["PkgBasePrice"];                    //get the package base price

                            // for the columns that can be null, determine if returns null from data base and set the variables accordingly
                            pkg.PackageDesc = Convert.IsDBNull(reader["PkgDesc"]) ? "" : reader["PkgDesc"].ToString();
                            pkg.StartDate = Convert.IsDBNull(reader["PkgStartDate"]) ? (DateTime?)null : (DateTime)reader["PkgStartDate"];
                            pkg.EndDate = Convert.IsDBNull(reader["PkgEndDate"]) ? (DateTime?)null : (DateTime)reader["PkgEndDate"];
                            pkg.AgencyCommission = Convert.IsDBNull(reader["PkgAgencyCommission"]) ? (decimal?)null : (decimal)reader["PkgAgencyCommission"];
                        }
                    }
                }
            }
            return pkg;             //return list of package objects
        }

    }
}
