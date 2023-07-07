using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.entity
{
    public class Reserve
    {
        private static long nextId = 1;
        public static long NextId { get => nextId; set => nextId = value; }

        private long id;
        private Member member;
        private string purpose;
        private List<Member> members;
        private string startTime;
        private string endTime;
        private bool isDelete = false;
        private DateTime dateTime;

        public long Id { get => id; set => id = value; }
        public Member Member { get => member; set => member = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public List<Member> Members { get => members; set => members = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public string toStringMembers()
        {
            string result = "";
            foreach (Member member in members)
            {
                result += (member.Name + " ");
            }
            return result;
        }
    }
}
