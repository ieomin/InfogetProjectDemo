using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.entity
{
    public class Member
    {
        private string name;
        private PositionStatus positionStatus;
        private Team team;
        private List<Reserve> reserves;

        public Member(string name, PositionStatus positionStatus, Team team)
        {
            this.Name = name;
            this.PositionStatus = positionStatus;
            this.Team = team;
        }

        public string Name { get => name; set => name = value; }
        public PositionStatus PositionStatus { get => positionStatus; set => positionStatus = value; }
        public Team Team { get => team; set => team = value; }
        public List<Reserve> Reserves { get => reserves; set => reserves = value; }
    }
}
