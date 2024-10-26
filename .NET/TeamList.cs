using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamList
    {
        public List<Team> Teams { get; set; }

        public TeamList()
        {
            Teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }

        public List<Team> GetTeams()
        {
            return Teams;
        }

        public Team FindTeam(string teamName)
        {
            return Teams.FirstOrDefault(t => t.Name == teamName);
        }
    }
}