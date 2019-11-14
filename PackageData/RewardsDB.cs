using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RewardsDB
    {
        public static List<Reward> GetRewards(int customerID)
        {
            List<Reward> rewards = new List<Reward>();
            Reward reward = null;

            //initialize db connection. 
            //Environment.MachineName provides name of teh machien the application running on. 
            //Works only if the database is installed on the same machine
            using (SqlConnection connection = TravelExpertsDB.GetConnection(Environment.MachineName))
            {
                //define select query
                string selectQuery = "SELECT r.RewardId, RwdName, RwdNumber " +
                                     "FROM Customers_Rewards as cr inner join Rewards as r on cr.RewardId = r.RewardId " +
                                     "where CustomerId = @CustomerId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))                //initialize sqlcommand
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerID);                       // data bind customer id                                              
                    connection.Open();                                                          //open connection
                    using (SqlDataReader reader = cmd.ExecuteReader())                          //initialize reader
                    {
                        while (reader.Read())                                                      //if there is data to be read
                        {
                            reward = new Reward();                                                //create reward
                            reward.RewardId = (int)reader["RewardId"];
                            reward.RewardName = reader["RwdName"].ToString();
                            reward.RewardNumber = reader["RwdNumber"].ToString();
                            rewards.Add(reward);
                        }
                    }
                }
            }
            return rewards;             //return list of package objects
        }
    }
}
