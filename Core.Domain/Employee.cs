using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Domain
{
    public class Employee
    {
        //Property
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        //Constructor
        public Employee(string name)
        {
            Name = name;
        }
        public Employee(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        //Method
        //public bool ApproveRide(ride.Date)
    }
}
