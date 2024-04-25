using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public sealed class Motorcycle : TwoWheeler
    {

        public Motorcycle()
        {
            vehicleTypes = VehicleType.TwoWheeler;
            NumberOfSeat = 2;
        }
        public decimal KMPL { get; set; }
       
    }
}
