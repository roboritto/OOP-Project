using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgram
{
    public class Task
    {
        public string TaskName {  get; set; }
        public string TaskDescription { get; set; }
        public Progress Status { get; set; }
        public DateTime AssignedDate { get; set; }
        public TeamMember TeamMember { get; set; }

        public Task(string name, string description, DateTime assignedDate) 
        {
            TaskName = name;
            TaskDescription = description;
            AssignedDate = assignedDate;
        }

        public void AssignTo(TeamMember member)
        {
            TeamMember = member;
        }

        public void SetStatus(Progress status)
        {
            Status = status;
        }

        public string GetTaskDetails()
        {
            return $"{TaskDescription}, Status: {Status}, Assigned to: {TeamMember?.Name}";
        }
    }
}
