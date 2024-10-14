using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgram
{
    public class TeamMember
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

        public TeamMember(string name, string role, string email)
        {
            Name = name;
            Role = role;
            Email = email;
        }

        public void AssignToTask(Task task)
        {
            task.AssignTo(this);
        }

        public string GetMemberDetails()
        {
            return $"Name: {Name}, Role: {Role}, Email: {Email}";
        }
    }
}
