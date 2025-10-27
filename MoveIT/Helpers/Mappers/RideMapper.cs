using Core.Domain;
using MoveIT.Models;

namespace MoveIT.Helpers.Mappers
{
    internal static class RideMapper
    {
        //Dit is een Extension method (dit is .Net specifiek)
        //oftewel een methode die je kunt aanroepen op een object van een bepaalde class
        //Hiermee kun je dus een RideModel 'omzetten' naar een Ride object
        //Dit is handig omdat je zo de mapping code op een centrale plek hebt staan
        //en niet verspreid door je codebase
        public static Ride Map(this RideModel rideModel)
        {
            return new Ride(
                //rideModel.Date,
                rideModel.Distance,
                rideModel.Price
                /*rideModel.Ongoing*/);
        }
    }
}