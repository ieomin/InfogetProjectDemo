using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDemo.entity;

namespace ProjectDemo.service
{
    internal class ReserveService
    {


        public ReserveService()
        {
        }

        public Reserve createReserve(Member member, string purpose, List<Member> members, string startTime, string endTime)
        {
            Reserve reserve = new Reserve();
            reserve.Member = member;
            reserve.Purpose = purpose;
            reserve.Members = members;
            reserve.StartTime = startTime;
            reserve.EndTime = endTime;
            return reserve;
        }
    }
}
