using System;
using System.ComponentModel.DataAnnotations;
using ClassLibrary;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p1 = new Project("Max", "Verstappen", 324.234, DateTime.Now, Progress.Completed);
            Project p2 = new Project("Lewis", "Hamilton", 3463.24, DateTime.Now, Progress.Completed);
            ProjectList projects = new ProjectList();
            projects.Add(p1);
            projects.Add(p2);
            FireStoreManager manager = new FireStoreManager("oopweb-43901");//ClassLibrary.Index to differentiate with System.Index
            var taskfb = System.Threading.Tasks.Task.Run(async () => await manager.SaveProjects(p1, ));
            taskfb.Wait();

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Cost);
            Console.ReadLine(); //makes the terminal stay open till click enter
            
        }
    }
}
