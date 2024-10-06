using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Task_List
    {
        public string TASK_NAME {  get; set; }
        public List<Task> Tasks { get; set; }
        public Task_List(string task_name)
        {
            TASK_NAME = task_name;
        }
        public Task_List()
        {
            Tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }
        public List<Task> GetTasks()
        {
            return Tasks;
        }
        public string FindTask(string task_name)
        {
            if (Tasks.Contains(task_name))
            {
                return $"Task '{task_name}' not found.";
            }
            else
            {
                return $"Task '{task_name}' found."; 
            }
        }
    }
}
