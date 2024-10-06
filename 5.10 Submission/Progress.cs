using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    internal class Progress
    {
        public string TO_DO { get; set; }
        public string IN_PROGRESS { get; set; }
        public string COMPLETED { get; set; }
        public Progress(string to_do, string in_progress, string completed)
        {
            TO_DO = to_do;
            IN_PROGRESS = in_progress;
            COMPLETED = completed;
        }

        public void Display()
        {
            Console.WriteLine("Progress Status:");
            Console.WriteLine($"TO DO: {TO_DO}");
            Console.WriteLine($"IN PROGRESS: {IN_PROGRESS}");
            Console.WriteLine($"COMPLETED: {COMPLETED}");
        }

    }
}
