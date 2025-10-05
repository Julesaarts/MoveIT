using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO__data_transfer_object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    internal class RideService
    {
        public void AddRide(Ride ride)
        {
            //ToDo: Validate if date (or whatever) is unique (or whatever)
            //If ride exists, throw exeption
            //Else add ride

            RideRepository repository = new RideRepository();
            repository.AddRide(new RideDTO()
            {
                Date = ride.Date,
                Distance = ride.Distance,
                Price = ride.Price,
                Ongoing = ride.Ongoing
            });
        }
    }
}
