using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TaskList : List<Task>
    {
        public List<Task> Tasks {  get; set; }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }

        public List<Task> GetTask()
        {
            return Tasks;
        }

        public Task FindTask(string taskName)
        {
            return Tasks.FirstOrDefault(t => t.TaskName == taskName);
        }
    }
}
