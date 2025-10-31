using Infrastructure.DataAccess.DTO__data_transfer_object_;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class VehicleRepository
    {
        //ophalen van alle ritten uit de database
        public List<VehicleDTO> GetVehicles()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>();

            string connectionString = $"Server=localhost;Database=moveit;User ID=root;Password={ww.DbPassword};";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Type, kmDriven, value, licensePlate FROM vehicle", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VehicleDTO vehicle = new VehicleDTO()
                        {
                            //Alle NULLs in de database opvangen en vervangen door 0

                            //Date = reader.GetDateTime(0),
                            type = reader.IsDBNull(0) ? "" : reader.GetString(0),
                            kmDriven = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            value = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                            licensePlate = reader.IsDBNull(3) ? "" : reader.GetString(3)
                            //Ongoing = reader.GetBoolean(3)
                        };
                        vehicles.Add(vehicle);
                    }
                }
            }
            return vehicles;
        }

        //Ik hoef nog geen nieuwe autos op te slaan, dus deze methode is voorlopig niet nodig
        //public void AddVehicle(RideDTO rideDTO)
        //{
        //    string connectionString = $"Server=localhost;Database=moveit;User ID=root;Password={ww.DbPassword};";

        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        conn.Open();
        //    }
        //}
    }
}
