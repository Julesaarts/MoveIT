using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO__data_transfer_object_
{
    public class VehicleDTO
    {
        //hier halen we data uit onze database
        //het is niet de verantwoordelijkheid voor dit object om de data te controleren. omdat de data uit de database al correct moet zijn.
        //het is al gecontroleerd door de core laag (toen deze werd opgeslagen?)

        //public DateTime Date { get; set; }
        public string type { get; set; }
        public int kmDriven { get; set; }
        public int value { get; set; }
        public string licensePlate { get; set; }
    }
}
