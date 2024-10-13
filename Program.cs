using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project p1 = new Project("Adlin", "Aliya", 324.234, DateTime.Now, Progress.Completed);
            ProjectList projects = new ProjectList();
            projects.Add(p1);

            Console.WriteLine(p1.Date);
            Console.ReadLine(); //makes the terminal stay open till click enter
        }
    }
}
