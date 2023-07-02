using ProjectDemo.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.service
{
    public class MemberRepository
    {
        private List<Member> members;

        public MemberRepository() { }

        public Member findByName(string name)
        {
            members = ReserveList.members;
            foreach (Member member in members)
            {
                if (member.Name == name)
                {
                    return member;
                }
            }
            return null;
        }
    }
}
