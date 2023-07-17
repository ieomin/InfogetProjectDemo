using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.entity
{
    public class Member
    {
        private string loginId;
        private string password;
        private string name;
        private MemberPositionStatus positionStatus;
        private Team team;
        private List<Reserve> reserves;

        public Member() { }

        public string Name { get => name; set => name = value; }
        public MemberPositionStatus PositionStatus { get => positionStatus; set => positionStatus = value; }
        public Team Team { get => team; set => team = value; }
        public List<Reserve> Reserves { get => reserves; set => reserves = value; }
        public string LoginId { get => loginId; set => loginId = value; }
        public string Password { get => password; set => password = value; }
    }

    
}
