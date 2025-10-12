using Core.Domain;
using MoveIT.Models;

namespace MoveIT.Helpers.Mappers
{
    internal static class RideMapper
    {
        //Dit is een Extension method (dit is .Net specifiek)
        public static Ride Map(this RideModel rideModel)
        {
            return new Ride(
                //rideModel.Date,
                rideModel.Distance,
                rideModel.Price,
                rideModel.Ongoing);
        }
    }
}