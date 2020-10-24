using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Capstone2TaskList
{

    public class TaskTask
    {
        private List<TaskTask> tasktask;
        private string teamname;
        private string description;
        private DateTime duedate;
        private bool taskcomplete;

        public string TeamName
        {
            get { return teamname; }
            set { teamname = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime DueDate
        {
            get { return duedate; }
            set { duedate = value; }
        }

        public bool TaskComplete
        {
            get { return taskcomplete; }
            set { taskcomplete = value; }
        }

        public TaskTask(string TeamName, string Description, DateTime DueDate, bool TaskComplete)
        {
            teamname = TeamName;
            description = Description;
            duedate = DueDate;
            taskcomplete = TaskComplete;
        }
        public TaskTask()
        {

        }
        public void PrintTask()
        {
            Console.WriteLine($"{TeamName} is supposed to accomplish the chore {Description} by {DueDate}. Did they finish?");
            if (taskcomplete)
            {
                Console.WriteLine($"Yes.");
            }
            else
            {
                Console.WriteLine("No.");
            }
           
        }
        //public List<TaskTask> ListOfTasks()
        //{
        //    GetType { return tasktask; }
        //    SetType{ tasktask = value; }
        //}
        //public void UserInput(string name, string description, DateTime dueDate, bool taskComplete)
        //{
        //    TaskTask tasktask= new TaskTask();
        //    tasktask.TeamName = name;
        //    tasktask.Description = description;
        //    tasktask.DueDate = duedate;
        //    tasktask.TaskComplete = taskComplete;
        //    TaskTask.Add
        //    Console.WriteLine("Success!");

        //}
       
    }
}



