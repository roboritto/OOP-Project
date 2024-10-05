using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Task
    {
        public string DESCRIPTION { get; set; }
        public string STATUS { get; set; }
        public string PRIORITY {  get; set; }
        public DateTime DEADLINE { get; set; }
        public string AssignedTo { get; set; }

        public Task(string  description, string status, string priority, DateTime deadline)
        {
            DESCRIPTION = description;
            STATUS = "Not Started";
            PRIORITY = priority;
            DEADLINE = deadline;
            AssignedTo = "Unassigned";
        }
        public void AssignTo(string teamMember)
        {
            AssignedTo = teamMember;
            Console.WriteLine($"Task '{DESCRIPTION}' assigned to {AssignedTo}.");
        }
        public void UpdateStatus(string newStatus)
        {
            STATUS = newStatus;
            Console.WriteLine($"Task '{DESCRIPTION}' status updated to '{STATUS}'.");
        }
        public string GetTaskDetails()
        {
            return $"Description: {DESCRIPTION}\n" +
                   $"Priority: {PRIORITY}\n" +
                   $"Deadline: {DEADLINE.ToShortDateString()}\n" +
                   $"Status: {STATUS}\n" +
                   $"Assigned To: {AssignedTo}";
        }

        internal void AssignTo(Team_Members team_Members)
        {
            throw new NotImplementedException();
        }
    }
}
