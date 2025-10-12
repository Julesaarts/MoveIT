using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO__data_transfer_object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    //in 'services' heb je typische Use Cases
    public class RideService
    {
        public void AddRide(Ride ride)
        {
            //ToDo: Validate if date (or whatever) is unique (or whatever)
            //If ride exists, throw exeption
            //Else add ride

            RideRepository repository = new RideRepository();
            repository.AddRide(new RideDTO()
            {
                Distance = ride.Distance,
                Price = ride.Price,
                Ongoing = ride.Ongoing
            });
        }
        public List<Ride> GetRides()
        {
            RideRepository repository = new RideRepository();
            List<RideDTO> rideDTOs = repository.GetRides();
            List<Ride> rides = new List<Ride>();
            foreach (RideDTO rideDTO in rideDTOs)
            {
                rides.Add(new Ride(rideDTO.Distance, rideDTO.Price, rideDTO.Ongoing));
            }
            return rides;
        }
        
    }
}
