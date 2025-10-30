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
        //public omdat we er vanuit de UI bij willen
        //hier komen rides van de UI laag binnen

        //we kunnen hier validatie doen, met bijvoorbeeld RideResult teruggeven (of nieuw/ander result object)
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
                //Ongoing = ride.Ongoing
            });
        }

        //hiermee halen we rides op uit de database en returnen die naar de UI laag
        public IReadOnlyList<Ride> GetRides()
        {
            RideRepository repository = new RideRepository();
            List<RideDTO> rideDTOs = repository.GetRides();
            List<Ride> rides = new List<Ride>();
            foreach (RideDTO rideDTO in rideDTOs)
            {
                rides.Add(new Ride(rideDTO.Distance, rideDTO.Price /*rideDTO.Ongoing*/ ));
            }
            return rides;
        }
    }
}
