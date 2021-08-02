using System;
using System.Collections.Generic;
using System.Linq;
using DesignPrinciples.DesignPrinciple.Single_Responsibilty_Principle;

namespace DesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {

            var scheduler = new Scheduler();
            //Adding Entires in list
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Update the task ", ExecuteOn = DateTime.Now.AddDays(2) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 3, Content = "Develop the Module", ExecuteOn = DateTime.Now.AddDays(3) });
            //Printing the data using Tostring method
            Console.WriteLine(scheduler.ToString());
            //remove the entry using index
            scheduler.RemoveEntryAt(2);
            Console.WriteLine("\nRemoved Successfully");
            Console.WriteLine("\nAfter remvoing the data\n");
            Console.WriteLine(scheduler.ToString());
        }
    }
}
