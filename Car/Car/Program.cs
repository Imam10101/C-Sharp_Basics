using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public enum VehicleType {TwoWheeler =2, ThreeWheeler = 3,FourWheeler =4 }
    public interface Iinterior
    {
        void DesignInterior(Car car);
    }
    public interface IExterior
    {
        void DesignExterior(Motorcycle mototrcycle);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose vehicle:");
            Console.WriteLine("Press '4' for car or Press '2' for motorcycle");
            int vehicleType = int.Parse(Console.ReadLine());
            //CAR
            if(vehicleType == (int)VehicleType.FourWheeler) 
            {

                Car c= new Car();
                c.ModelNo = "Audi X1";
                Console.WriteLine();
                c.NumberOfDoor = 4;
                Console.WriteLine();
                c.NumberOfSeat = 5;
                Console.WriteLine();
                Iinterior iInterior = new FourWheeler();
                iInterior.DesignInterior(c);
            }
            //Motorcycle 
            else if (vehicleType==(int)VehicleType.TwoWheeler)
            {
                Motorcycle m = new Motorcycle();
                m.ModelNo = "Royal Enfield";
                Console.WriteLine();
                m.NumberOfSeat= 2;
                Console.WriteLine();
                m.KMPL = 1;
                Console.WriteLine();
                m.FrontBreak = 2;
                IExterior iExterior = new TwoWheeler();
                iExterior.DesignExterior(m);

            }
            else
            {
                Console.WriteLine("vehicle not found.");
            }
            Console.ReadKey();
        }
    }
}
