using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceHW2
{
    public class DailyPurchase
    {
        public DateTime DDate { get; set; }
        public string Item { get; set; }
        public decimal Unitprice { get; set; }
        public int Quantity { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DailyPurchase> dp = new List<DailyPurchase>()
            {
                new DailyPurchase
                {
                    DDate = DateTime.Parse("2016-07-03"),
                    Item = "Pen",
                    Unitprice = 30,
                    Quantity = 2,
                },
                new DailyPurchase
                {
                    DDate = DateTime.Parse("2016-07-09"),
                    Item = "Travel Bag",
                    Unitprice = 350,
                    Quantity = 1,
                },
                new DailyPurchase
                {
                    DDate = DateTime.Parse("2016-08-13"),
                    Item = "Tooth Paste",
                    Unitprice = 80,
                    Quantity = 1,
                },
                new DailyPurchase
                {
                    DDate = DateTime.Parse("2016-08-22"),
                    Item = "Pillow Cover",
                    Unitprice = 120,
                    Quantity = 2,
                },
                new DailyPurchase
                {
                    DDate = DateTime.Parse("2016-12-27"),
                    Item = "Cofee",
                    Unitprice = 210,
                    Quantity = 1,
                }

            };
            // 1. LINQ query to show expenses in last month

            var dataOnDate = dp
                .Where(p => p.DDate == DateTime.Parse("2016-12-27"))
                .ToList();

            Console.WriteLine("1. Expenses in Last Month:");

            dataOnDate.ForEach(p=>Console.WriteLine($"Date: {p.DDate}, Item: {p.Item}, Unit Price: {p.Unitprice}, Quantity: {p.Quantity}"));


            // 2. LINQ query to show the most expensive product
            Console.WriteLine("\n2. Most Expensive Product:");
            var max = dp.Max(p => p.Unitprice);
            Console.WriteLine(max);

            //Console.WriteLine("\n2. Most Expensive Product:");
            //max.ForEach(p => Console.WriteLine($"Date: {p.DDate.ToShortDateString()}, Item: {p.Item}, Unit Price: {p.Unitprice}, Quantity: {p.Quantity}"));


            // 3. LINQ query to get total amount in last month
            decimal totalPrices = dp.Sum(p => p.Unitprice * p.Quantity);
            Console.WriteLine($"\n4. Total Prices: {totalPrices}");
        
        Console.ReadKey();
        }
    }
}
