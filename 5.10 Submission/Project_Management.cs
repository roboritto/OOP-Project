using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Project_Management
    {
        public string LOGOUT { get; set; }
        public string LOGIN { get; set; }
        public string SEARCH { get; set; }

        public Project_Management(string logout, string login, string search)
        {
            LOGOUT = logout;
            LOGIN = login;
            SEARCH = search;
        }

        public void Display()
        {
            Console.WriteLine("Project Management Details:");
            Console.WriteLine($"LOGIN: {LOGIN}");
            Console.WriteLine($"LOGOUT: {LOGOUT}");
            Console.WriteLine($"SEARCH: {SEARCH}");
        }
    }
}
