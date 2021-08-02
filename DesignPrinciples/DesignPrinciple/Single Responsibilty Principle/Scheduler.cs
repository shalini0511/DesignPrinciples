using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DesignPrinciples.DesignPrinciple.Single_Responsibilty_Principle
{
    class Scheduler : IEntryManager<ScheduleTask>
    {
        //Declaring a list 
        private List<ScheduleTask> scheduleTasks;
        //Constructor
        public Scheduler()
        {
            scheduleTasks = new List<ScheduleTask>();
        }
        //ADDENTRY--->To add te data in list
        public new void AddEntry(ScheduleTask entry)
        {
            scheduleTasks.Add(entry);
        }
        //REMOVEENTRY---->Remove the index using lambda expression
        public new void RemoveEntryAt(int index) =>
            scheduleTasks.RemoveAt(index);

        public override string ToString() =>
       string.Join(Environment.NewLine, scheduleTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}
