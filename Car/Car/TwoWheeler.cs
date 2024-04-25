using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class TwoWheeler : Vehicle, IExterior
    {
        public int FrontBreak { get; set; }
        
      

        public void DesignExterior(Motorcycle motorcycle)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("Design " + motorcycle.vehicleTypes + " Motorcycle !!");
            Console.WriteLine("MotorCycle ModelNo:-" + motorcycle.ModelNo);
            
            Console.WriteLine("Number Of Seat:-" + motorcycle.NumberOfSeat);
         
          
            Console.WriteLine("MileagePower:-" + motorcycle.KMPL + "KMPL");
            
           
            Console.WriteLine("Number Of Front Break:-" + motorcycle.FrontBreak);
         
            Console.WriteLine("=======================================================");
        }
}
 
}
