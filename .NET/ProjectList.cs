using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgram
{
    public class ProjectList : List<Project>
    {
        public List<Project> Projects { get; set; }

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }

        public void RemoveProject(Project project)
        {
            Projects.Remove(project);
        }

        public List<Project> GetProjects()
        {
            return Projects;
        }

        public Project FindProject(string projectName)
        {
            return Projects.FirstOrDefault(p => p.Name == projectName);
        }
    }
}
