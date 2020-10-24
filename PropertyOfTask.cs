using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2TaskList
{
    class PropertyOfTask
    {

       //private List<string> homeChores = new List<string>(); //list of tasks by person assigned, job, date to be finished, if done or not (need user input to verify)
            
       //      // TaskTask Shake=  new TaskTask ("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false),
       //       homeChores.Add(new string("Master Shake", "Wash Dishes", DateTime.Parse("10/24/2020"), false));
       // homeChores.Add(newstring("Frylock", "Clean Bathroom", DateTime.Parse("10/25/2020"), false));
       //         homeChores.Add(new TaskTask("Stinky Mike", "Clean Litterbox", DateTime.Parse("10/26/2020"), false));
       //         homeChores.Add(new TaskTask("Duncan", "Celebrate Birthday", DateTime.Parse("10/27/2020"), false));
       //         homeChores.Add(new TaskTask("Carl", "Walk Dog", DateTime.Parse("10/28/2020"), false));
            
       

        private List<string> chores = new List<string>() { "Wash Dishes", "Clean Bathroom", "Clean Litterbox", "Celebrate Birthday", "Walk Dog" };
     

        public List<string> GetChores()
        {
            return chores;
 }






        // chores.Insert(1, "Change Oil in Truck");
        //foreach (string c in chores)
            //Console.WriteLine(c);
        
    }

}
