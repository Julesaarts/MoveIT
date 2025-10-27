using Infrastructure.DataAccess.DTO__data_transfer_object_;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.DataAccess
{
    public class RideRepository
    {
        public List<RideDTO> GetRides()
        {
            List<RideDTO> rides = new List<RideDTO>();

            string connectionString = "Server=localhost;Database=moveit;User ID=root;Password=Superman2910891!;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Distance, Price, Ongoing FROM ride", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RideDTO ride = new RideDTO()
                        {
                            //Date = reader.GetDateTime(0),
                            Distance = reader.GetInt32(1),
                            Price = reader.GetInt32(2),
                            //Ongoing = reader.GetBoolean(3)
                        };
                        rides.Add(ride);
                    }
                }
            }
            return rides;
        }

        //onderstaande moet straks worden vervangen met data uit de database
        //nu is het nog hardcoded

        //Dus eigenlijk staat hieronder:
        //haal dit en dit uit de database en return het
        //een andere class kan dan deze method aanroepen en die data uit de DB gereturned krijgen.

        //    List<RideDTO> rides = new List<RideDTO>()
        //{
        //    new RideDTO()
        //    {
        //        Date = new DateTime(2025,11,5),
        //        Distance = 100,
        //        Price = 10,
        //        Ongoing = false
        //    },
        //    new RideDTO()
        //    {
        //        Date = new DateTime(2025,11,5),
        //        Distance = 200,
        //        Price = 18,
        //        Ongoing = false
        //    },
        //    new RideDTO()
        //    {
        //        Date = new DateTime(2025,11,10),
        //        Distance = 150,
        //        Price = 12,
        //        Ongoing = false
        //    }
        //};
        //    return rides;

        public void AddRide(RideDTO rideDTO)
        {
            //ToDo: Insert data into database
        } 
    }
}
