using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

/*
 * This is the data access class for travel package entity.
 * All the properties except package id, package name and base price can be set to null.
 * 
 * Author: Abhilash Paul
 * Date:  26th July 2019 
 */

namespace DataAccessLayer
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
            //Environment.MachineName provides name of the machine this application running on. 
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



        /// <summary>
        /// Function to retrieve products included in the user selected package 
        /// </summary>
        /// <param name="packageID">Package id</param>
        /// <returns>list of products as an array list</returns>
        public static List<Product> GetProducts(int packageID)
        {
            //List to store products
            List<Product> products = new List<Product>();

            Product product = null;
            
            //initialize db connection. 
            //Environment.MachineName provides name of the machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT p.ProdName, p.ProductId FROM Packages_Products_Suppliers as pps " +
                                        "inner join Products_Suppliers as ps " +
                                        "on pps.ProductSupplierId = ps.ProductSupplierId " +
                                        "inner join Products as p on ps.ProductId = p.ProductId " +
                                        "where PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                        //initialize sqlcommand
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageID);                               //data bind package id                                              
                    connection.Open();                                                                  //open DB connection

                    using (SqlDataReader reader = cmd.ExecuteReader())                          //initialize reader
                    {
                        while (reader.Read())                                                      //if there is data to be read, create product objects and add them to list
                        {
                            product = new Product();                                                
                            product.ProductId = (int)reader["ProductId"];                           
                            product.ProdName = reader["ProdName"].ToString();
                            products.Add(product);
                        }
                    }
                    
                }
            }
            return products;  //return list of products
        }

        /// <summary>
        /// Function to retrieve suppliers included in the user selected package 
        /// </summary>
        /// <param name="packageID">Package id</param>
        /// <returns>list of suppliers as an array list</returns>
        public static List<Supplier> GetSuppliers(int packageID)
        {
            //List to store suppliers
            List<Supplier> suppliers = new List<Supplier>();
            Supplier supplier = null;

            //initialize db connection. 
            //Environment.MachineName provides name of the machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT s.SupplierId, s.SupName FROM Packages_Products_Suppliers as pps " +
                                        "inner join Products_Suppliers as ps " +
                                        "on pps.ProductSupplierId = ps.ProductSupplierId " +
                                        "inner join Suppliers as s on ps.SupplierId = s.SupplierId " +
                                        "where PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                        //initialize sqlcommand
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageID);                               //data bind package id                                              
                    connection.Open();                                                                  //open DB connection

                    using (SqlDataReader reader = cmd.ExecuteReader())                         
                    {
                        while (reader.Read())                                                      //if there is data to be read, create supplier objects and add them to list
                        {
                            supplier = new Supplier();                                            
                            supplier.SupplierId = (int)reader["SupplierId"];
                            supplier.SupName = reader["SupName"].ToString();
                            suppliers.Add(supplier);
                        }
                    }
                }
            }
            return suppliers;  //return list of suppliers
        }


        /// <summary>
        /// Function to retrieve products included in the user selected package 
        /// </summary>
        /// <param name="packageID">Package id</param>
        /// <returns>list of products as an array list</returns>
        public static DataTable GetProductsAndSuppliers(int packageID)
        {
            //Array list to product names
            DataTable dt = new DataTable();
            //initialize db connection. 
            //Environment.MachineName provides name of teh machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT p.ProdName as Product, s.SupName as Supplier FROM Packages_Products_Suppliers as pps " +
                                        "inner join Products_Suppliers as ps " +
                                        "on pps.ProductSupplierId = ps.ProductSupplierId " +
                                        "inner join Products as p on ps.ProductId = p.ProductId " +
                                        "inner join Suppliers as s on ps.SupplierId = s.SupplierId " +
                                        "where PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                        //initialize sqlcommand
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageID);                               //data bind package id                                              
                    connection.Open();                                                                  //open DB connection
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;  //return list of products
        }

    }
}
