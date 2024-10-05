using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Project_List
    {
        public string PROJECT_NAME { get; set; }
        public string STATUS { get; set; }
        public Project_List(string project_name, string status)
        {
            PROJECT_NAME = project_name;
            STATUS = status;
        }
        public List<Project> Projects { get; set; }
        public Project_List()
        {
            Projects = new List<Project>();
        }
        public void AddProject(Project project)
        {
            Projects.Add(project);
        }

        public void
            RemoveProject(Project project)
        {
            Projects.Remove(project);
        }
        
    }
}
