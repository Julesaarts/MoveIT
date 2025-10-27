// See https://aka.ms/new-console-template for more information
using Core.Domain;

Console.WriteLine("Goedemiddag");

Systemo ritten = new Systemo("Ritten");
foreach (Ride ride in ritten.Rides)
{
    Console.WriteLine($"Distance: {ride.Distance}, Price: {ride.Price}");
}

Console.WriteLine("press key");
Console.ReadKey();





//Vehicle vehicle1 = new Vehicle("123ABC", 123, 123);
//Vehicle vehicle2 = new Vehicle("string", 123, 123);

//if (vehicle1.LicensePlate == "string")
//{
//    Console.WriteLine("iets");
//}

