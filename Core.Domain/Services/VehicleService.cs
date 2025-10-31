using Core.Domain.Vehicles;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO__data_transfer_object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class VehicleService
    {
        //hiermee halen we rides op uit de database en returnen die naar de UI laag
        public IReadOnlyList<Vehicles.Vehicle> GetVehicles()
        {
            VehicleRepository repository = new VehicleRepository();
            List<VehicleDTO> vehicleDTOs = repository.GetVehicles();
            List<Vehicles.Vehicle> vehicles = new List<Vehicles.Vehicle>();
            foreach (VehicleDTO vehicleDTO in vehicleDTOs)
            {
                vehicles.Add(new Vehicle(vehicleDTO.type, vehicleDTO.kmDriven, vehicleDTO.value, vehicleDTO.licensePlate /*rideDTO.Ongoing*/ ));
            }
            return vehicles;
        }
    }
}
