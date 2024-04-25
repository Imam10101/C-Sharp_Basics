using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class FourWheeler : Vehicle, Iinterior
    {
        public int NumberOfDoor { get; set; }
        public void DesignInterior(Car car)
        {
            
   
        
            Console.WriteLine("=============================================");
            Console.WriteLine("Design " + car.vehicleTypes + " Is Car!!");
            Console.WriteLine("Car ModelNo:-" + car.ModelNo);
            Console.WriteLine("Number Of Seat:-" + car.NumberOfSeat);
            Console.WriteLine("Number  Of Door:-" + car.NumberOfDoor);
          
            Console.WriteLine("=============================================");
        }
    }
    
}
