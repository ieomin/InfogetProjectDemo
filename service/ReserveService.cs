using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDemo.entity;

namespace ProjectDemo.service
{
    public class ReserveService
    {
        private static ReserveService instance;

        private ReserveService()
        {
        }

        public static ReserveService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ReserveService();
                }
                return instance;
            }
        }

        public Reserve createReserve(Member member, string purpose, List<Member> members, string startTime, string endTime)
        {
            Reserve reserve = new Reserve();
            reserve.Id = Reserve.NextId++;
            reserve.Member = member;
            reserve.Purpose = purpose;
            reserve.Members = members;
            reserve.StartTime = startTime;
            reserve.EndTime = endTime;
            reserve.DateTime = DateTime.Now;
            return reserve;
        }
    }
}
