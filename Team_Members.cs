using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Team_Members : Team_List
    {
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string ROLE { get; set; }

        public Team_Members(string name, string email, string role)
        {
            NAME = name;
            EMAIL = email;
            ROLE = role;
        }
        public void AssignToTask(Task task)
        {
            task.AssignTo(this);
        }
        public string GetMemberDetails()
        {
            return $"Name: {NAME}, Role:{ROLE}, Email: {EMAIL}";
        }
    }
}
