using ProjectDemo.entity;
using ProjectDemo.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.service
{
    public class ReserveRepository
    {
        private List<Reserve> reserves;

        private static ReserveRepository instance;

        private ReserveRepository() { }

        public static ReserveRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReserveRepository();
                }
                return instance;
            }
        }

        public Reserve findById(long id)
        {
            reserves = ReserveListForm.ReserveDB;
            foreach(Reserve reserve in reserves)
            {
                if(reserve.Id == id)
                {
                    return reserve;
                }
            }
            return null;
        }
    }
}
