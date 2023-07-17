using ProjectDemo.entity;
using ProjectDemo.form;
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

        private static MemberRepository instance;

        private MemberRepository() { }

        public static MemberRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberRepository();
                }
                return instance;
            }
        }

        public Member findByName(string name)
        {
            members = ReserveListForm.MemberDB;
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
