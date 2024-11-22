namespace DemoDotnet8BlazorQuickGrid.Pages
{
    public class TeamMemberService
    {
        // Dictionary to store team members (team name as key, list of members as value)
        public Dictionary<string, List<string>> TeamMembers { get; private set; } = new Dictionary<string, List<string>>();

        // Add a team member
        public void AddMember(string teamName, string memberName)
        {
            if (!TeamMembers.ContainsKey(teamName))
            {
                TeamMembers[teamName] = new List<string>();
            }
            TeamMembers[teamName].Add(memberName);
        }

        // Edit a team member
        public void EditMember(string teamName, string oldMemberName, string newMemberName)
        {
            if (TeamMembers.ContainsKey(teamName))
            {
                var members = TeamMembers[teamName];
                var index = members.IndexOf(oldMemberName);
                if (index >= 0)
                {
                    members[index] = newMemberName;
                }
            }
        }

        // Delete a team member
        public void DeleteMember(string teamName, string memberName)
        {
            if (TeamMembers.ContainsKey(teamName))
            {
                TeamMembers[teamName].Remove(memberName);
                if (TeamMembers[teamName].Count == 0)
                {
                    TeamMembers.Remove(teamName);
                }
            }
        }
    }

}
