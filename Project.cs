using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Project : Project_List
    {
        public string DESCRIPTION { get; set; }
        public List <string> TASK_LIST;
        public decimal COST { get; set; }
        

        public Project(string description, decimal cost)
        {
            DESCRIPTION = description;
            TASK_LIST = new List <string>();
            COST = cost;
        }
        public void AddTask(string taskName)
        {
            TASK_LIST.Add(taskName);
            Console.WriteLine($"Task '{taskName}' added to the project.");
        }

        // Method to remove a task from the project
        public void RemoveTask(string taskName)
        {
            if (TASK_LIST.Remove(taskName))
            {
                Console.WriteLine($"Task '{taskName}' removed from the project.");
            }
            else
            {
                Console.WriteLine($"Task '{taskName}' not found in the project.");
            }
        }

        // Method to get a list of all tasks in the project
        public List<string> GetAllTasks()
        {
            return new List<string>(TASK_LIST); // Return a copy of the task list
        }

        // Method to find a task by name
        public string FindTask(string taskName)
        {
            if (TASK_LIST.Contains(taskName))
            {
                return $"Task '{taskName}' found in the project.";
            }
            else
            {
                return $"Task '{taskName}' not found in the project.";
            }
        }
        public void UpdateDescription(string newDescription)
        {
            DESCRIPTION = newDescription;
            Console.WriteLine($"Project description updated to: '{DESCRIPTION}'.");
        }

    }
}
