using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multitasking_01
{
    internal class Program
    {
        static void createtaskusingfactorymethod()
        {
            Console.WriteLine("The task is created using Factory Method");
        }

        static async Task createtaskusingasync()
        {
            Console.WriteLine("The task is created using Async");
            await Task.Delay(3000);
        }

        static void createtaskusingaction()
        {
            Console.WriteLine("The task is created using Action Delegate");
        }

        static void createtaskusingdelegate()
        {
            Console.WriteLine("The task is created using Delegate");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("===================================");

            Task factoryTask = Task.Factory.StartNew(() => { createtaskusingfactorymethod(); });
             await createtaskusingasync();  // or createtaskusingasync().Wait();

            Task actionT = new Task(new Action(createtaskusingaction));
            actionT.Wait(2000);
            actionT.Start();
            

            Task del = new Task(delegate { createtaskusingdelegate(); });
            del.Start();
            del.Wait(2000);




            Console.WriteLine("===============All tasks completed.============");
            Console.ReadKey();
        }
    }
}
    

