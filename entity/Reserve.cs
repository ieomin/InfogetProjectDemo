using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.entity
{
    public class Reserve
    {
        private long id;
        private Member member;
        private string purpose;
        private List<Member> members;
        private string startTime;
        private string endTime;
        int c;

        public long Id { get => id; set => id = value; }
        public Member Member { get => member; set => member = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public List<Member> Members { get => members; set => members = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
    }
}
