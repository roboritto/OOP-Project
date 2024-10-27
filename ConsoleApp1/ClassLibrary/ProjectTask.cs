using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary;
public class ProjectTask
{
    public string TaskName { get; set; }
    public string TaskDescription { get; set; }
    public Progress Status { get; set; }
    public DateTime AssignedDate { get; set; }
    public TeamMember TeamMember { get; set; }

    public ProjectTask(string taskName, string taskDescription, DateTime assignedDate)
    {
        TaskName = taskName;
        TaskDescription = taskDescription;
        AssignedDate = assignedDate;
        Status = Progress.ToDo;
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
        return $"{TaskDescription}, Status: {Status}, Assigned to: {TeamMember?.memberName}, Date: {AssignedDate}";
    }
}