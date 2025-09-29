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
        private string _address;
        private int _phone;

        //Property
        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public int Phone { get { return _phone; } }

        //Constructor
        public Customer()
        { }

        //Constructor Overloading
        public Customer(string Name, string Address, int Phone)
        {
            _name = Name;
            _address = Address;
            _phone = Phone;
        }

        //Method
        //public bool RequestRide(ride.Date)
    }
}
