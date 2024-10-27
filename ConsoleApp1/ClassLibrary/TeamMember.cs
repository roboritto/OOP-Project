using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamMember
    {
        public string memberName { get; set; }
        public string memberRole { get; set; }
        public string memberEmail { get; set; }

        public TeamMember(string memberName)
        {
            this.memberName = memberName;
        }

        public TeamMember() { }

        public string GetMemberDetails()
        {
            return $"Name: {memberName}, Role: {memberRole}, Email: {memberEmail}";
        }
    }
}

