using System;
using System.Collections.Generic;

namespace Ladr.Library.Models
{
    public class Team
    {
        private List<Member> _members = new List<Member>() {};
        public Team()
        {
            
        }

        public List<Member> GetMembers()
        {
            return _members;
        }
    }
}
