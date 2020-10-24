using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Capstone2TaskList
{
    class Program
    {
       public static PropertyOfTask propertyOfTask = new PropertyOfTask();
        public static TaskTask tasktask = new TaskTask();

        static void Main(string[] args)
        {
            TaskTask Shake = new TaskTask("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false);
            TaskTask Frylock = new TaskTask("Frylock", "Clean Bathroom", DateTime.Parse("10/25/2020"), false);
            TaskTask StinkyMike = new TaskTask("Stinky Mike", "Clean Litterbox", DateTime.Parse("10/26/2020"), false);
            TaskTask Duncan = new TaskTask("Duncan", "Celebrate Birthday", DateTime.Parse("10/27/2020"), false);
            TaskTask Carl = new TaskTask("Carl", "Walk Dog", DateTime.Parse("10/28/2020"), false);
            Shake.PrintTask();
            

            //    foreach(var task in homeChores)
            //{
            //    Console.WriteLine(homeChores);
            //}
            List<TaskTask> homeChores = new List<TaskTask>(); //list of tasks by person assigned, job, date to be finished, if done or not (need user input to verify)
            {

                homeChores.Add(new TaskTask("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false));
                homeChores.Add(new TaskTask("Frylock", "Clean Bathroom", DateTime.Parse("10/25/2020"), false));
                homeChores.Add(new TaskTask("Stinky Mike", "Clean Litterbox", DateTime.Parse("10/26/2020"), false));
                homeChores.Add(new TaskTask("Duncan", "Celebrate Birthday", DateTime.Parse("10/27/2020"), false));
                homeChores.Add(new TaskTask("Carl", "Walk Dog", DateTime.Parse("10/28/2020"), false));
                foreach (var chore in homeChores)
                    Console.WriteLine(Convert.ToString(("Task: {0), {1},{2},{3},{4},{5}", chore.TeamName, chore.Description, chore.DueDate, chore.TaskComplete)));
            };

            

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static List<TaskTask> HomeChores()
        {
            List<TaskTask> homeChores = new List<TaskTask>(); //list of tasks by person assigned, job, date to be finished, if done or not (need user input to verify)
            {

                homeChores.Add(new TaskTask("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false));
                homeChores.Add(new TaskTask("Frylock", "Clean Bathroom", DateTime.Parse("10/25/2020"), false));
                homeChores.Add(new TaskTask("Stinky Mike", "Clean Litterbox", DateTime.Parse("10/26/2020"), false));
                homeChores.Add(new TaskTask("Duncan", "Celebrate Birthday", DateTime.Parse("10/27/2020"), false));
                homeChores.Add(new TaskTask("Carl", "Walk Dog", DateTime.Parse("10/28/2020"), false));
                foreach (var chore in homeChores)
                    Console.WriteLine(Convert.ToString(( chore.TeamName, chore.Description, chore.DueDate, chore.TaskComplete)));
            };
            return homeChores;
        }

        public static bool MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Welcome to the Task Manager!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\t1) List tasks");
            Console.WriteLine("\t2) Add Task");
            Console.WriteLine("\t3) Delete Task");
            Console.WriteLine("\t4) Mark task Complete");
            Console.WriteLine("\t5) Exit");
            Console.Write("\r\nSelect an option: ");

            Console.WriteLine("Please enter a number 1 through 5");
            switch (Console.ReadLine())  //use this for menus, user input direction from now on
            {
                case "1":
                    ListTask();
                    return true;
                case "2":
                  
                    AddTask();

                    return true;
                case "3":
                    DeleteTask();
                    return true;
                case "4":
                    MarkTaskComplete();
                    return true;
                case "5":

                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("To Add, Delete or Mark a Task Complete, please press Enter to return to the menu.");
            return Console.ReadLine();
        }

        
        public static void ListTask()
        {
            Console.Clear();
            Console.WriteLine("|||List of Tasks|||");

            //List<string> chores = propertyOfTask.GetChores();

            //foreach (string c in chores)
            //    Console.WriteLine(c);
            HomeChores();
            




            //DisplayResult(String.Concat(chores));
        }

        public static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("|||Add Task|||");

            //List<string> chores = propertyOfTask.GetChores();
            HomeChores();
            //foreach (string c in chores)
            //{ Console.WriteLine(c); }

            //HomeChores();
            Console.WriteLine("Please enter a task to add");
            string userInput = Console.ReadLine(); 
            Console.Clear();
            List<TaskTask> homeChores = new List<TaskTask>(); //list of tasks by person assigned, job, date to be finished, if done or not (need user input to verify)
           
                homeChores.Add(new TaskTask("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false));
                homeChores.Add(new TaskTask("Frylock", "Clean Bathroom", DateTime.Parse("10/25/2020"), false));
                homeChores.Add(new TaskTask("Stinky Mike", "Clean Litterbox", DateTime.Parse("10/26/2020"), false));
                homeChores.Add(new TaskTask("Duncan", "Celebrate Birthday", DateTime.Parse("10/27/2020"), false));
                homeChores.Add(new TaskTask("Carl", "Walk Dog", DateTime.Parse("10/28/2020"), false));
                foreach (var chore in homeChores)
               
                    Console.WriteLine(Convert.ToString((chore.TeamName, chore.Description, chore.DueDate, chore.TaskComplete)));

          
            
           



            //chores.Insert(5, userInput);
            //foreach (string c in chores)
            //{ Console.WriteLine(c); }
            //DisplayResult(String.Concat(userInput));






            DisplayResult(CaptureInput().Replace(" ", ""));
           

        }
        void UserAddTask()
        {
             
        }

        private static void DeleteTask()
        {
            Console.Clear();
            Console.WriteLine("Delete Task");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void MarkTaskComplete()
        {
            Console.Clear();
            Console.WriteLine("Would you like to mark the task complete?");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified task is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}

