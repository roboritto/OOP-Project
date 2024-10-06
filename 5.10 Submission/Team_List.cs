using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Web
{
    public class Team_List
    {
        public List <Team_List> Teams {get; set;}
        public string TEAM_NAME {  get; set; }
        public Team_List(string team_name)
        {
            TEAM_NAME = team_name;
            Teams = new List<Team_List>();
        }
        public void Add(Team_List team_list)
        { 
            Teams.Add(team_list); 
        }
    }
}
