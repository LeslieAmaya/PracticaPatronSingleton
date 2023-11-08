using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronSingleton
{
    public class Task
    {
        public int taskId { get; set; }
        public string? taskName { get; set; }
        public string? taskDescription { get; set; }
        public string? taskStatus { get; set; }
        public string? taskPriority { get; set; }
        public Task(int Id, string Name, string Description, string Status,string Priority) 
        {
            taskId = Id;
            taskName = Name;
            taskDescription = Description;
            taskStatus = Status;
            taskPriority = Priority;
        }
    }
}
