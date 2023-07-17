using ProjectDemo.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.repositoryAndService
{
    public class MemberService
    {
        private static MemberService instance;

        private MemberService() { }

        public static MemberService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MemberService();
                }
                return instance;
            }
        }

        public Member createMember(string loginId, string password, string name, MemberPositionStatus positionStatus, Team team)
        {
            Member member = new Member();
            member.LoginId = loginId;
            member.Password = password;
            member.Name = name;
            member.PositionStatus = positionStatus;
            member.Team = team;
            return member;
        }


    }
}
