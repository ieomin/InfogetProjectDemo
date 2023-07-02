using ProjectDemo.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemo.form
{
    public partial class ReserveCreate : UserControl
    {
        private List<Member> members;

        private ReserveMembersCreate reserveMembersCreate;
        private ReserveMemberCreate reserveMemberCreate;

        public ReserveCreate(List<Member> members)
        {
            InitializeComponent();
            this.members = members;
        }
    }
}
