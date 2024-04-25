using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvidenceHW1.Permanentemployee;

namespace EvidenceHW1
{
    public abstract class Employee
    {
        public DateTime Joindate { get; set; }

        //Method
        public abstract decimal monthlygrosspayable();
        
    }
    public class Permanentemployee : Employee
    {
        public decimal Basic { get; set; }
        public decimal Allowence { get; set; }
        //Override Method
        public override decimal monthlygrosspayable()
        {
            return Basic + Allowence;
        }
        public class hiredemployee : Employee
        {
            public DateTime HireDate { get; set; }
            public decimal PayRate { get; set; }
            public int WorkHoursPerDay { get; set; }

            public override decimal monthlygrosspayable()
            {
                int workingDaysPerMonth = 22;

                return PayRate * WorkHoursPerDay * workingDaysPerMonth;
            }
        }



    }
        internal class Program
    { 
        static void Main(string[] args)
        {
            // Permanent Employee

            Permanentemployee p = new Permanentemployee()
            {
                Joindate = DateTime.Parse("2022-01-25"),
                Basic = 50000,
                Allowence = 1000

            };
            decimal ps = p.monthlygrosspayable();
            Console.WriteLine($"Permanent Employee Gross Payable: {ps}");


            hiredemployee h = new hiredemployee()
            {
                Joindate = DateTime.Parse("2024-01-25"),
                HireDate = DateTime.Parse("2022-01-01"),
               
                PayRate = 20,
                WorkHoursPerDay = 8

            };
            decimal hs = h.monthlygrosspayable();
            Console.WriteLine($"Hired Employee Gross Payable: {hs}");

            Console.ReadKey();

        }
    }
}
