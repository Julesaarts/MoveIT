using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Customer
    {
        //Field
        private int _id;
        private string _name;
        private int _phone;
        private string _email;

        //Property
        public string Name { get { return _name; } }
        public int Phone { get { return _phone; } }
        public string Email { get { return _email; } }

        //Constructor
        public Customer()
        { }

        //Constructor Overloading
        public Customer(string Name, int Phone, string Email)
        {
            _name = Name;
            _phone = Phone;
            _email = Email;
        }

        //Method
        //public bool RequestRide(ride.Date)

        //public bool RequestsPassengerTransport(VehicleType vehicle)
        //{
        //    if (vehicle == "PassengerTransport")
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
