using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Vehicle
    {
        public VehicleType vehicleTypes { get; set; }
        public string ModelNo { get; set; }
      
        public int NumberOfSeat { get; set; }
      
    }
}
