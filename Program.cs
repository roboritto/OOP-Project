using System;
using ClassLibrary;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p1 = new Project("Max", "Verstappen", 324.234, DateTime.Now, Progress.Completed);
            ProjectList projects = new ProjectList();
            projects.Add(p1);
            ClassLibrary.Index index = new ClassLibrary.Index();//ClassLibrary.Index to differentiate with System.Index
            index.initFirestore();

            Console.WriteLine(p1.Date);
            Console.ReadLine(); //makes the terminal stay open till click enter
            
        }
    }
}
