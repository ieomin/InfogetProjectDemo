using ProjectDemo.entity;
using ProjectDemo.service;
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
    public partial class ReserveCreateForm : Form
    {
        private ReserveMembersCreateForm reserveMembersCreateForm;
        private ReserveMemberCreateForm reserveMemberCreateForm;

        private List<Member> members;
        private ReserveListForm reserveList;
        private List<Reserve> reserves = new List<Reserve>();

        private ReserveService reserveService = new ReserveService();

        private MemberRepository memberRepository = new MemberRepository();

        public ReserveCreateForm(List<Member> members, ReserveListForm reserveListForm)
        {
            InitializeComponent();
            this.members = members;
            this.reserveList = reserveListForm;
        }

        private void reserveCreateButton_Click(object sender, EventArgs e)
        {
            reserveList.dataGridView1.Rows.Clear();
            Member findMember = memberRepository.findByName(reserveMemberCreateForm.MemberName);
            Reserve reserve = reserveService.createReserve(findMember, textBox2.Text, reserveMembersCreateForm.Members, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            reserves.Add(reserve);


            foreach (Reserve r in reserves)
            {
                string temp = "";
                foreach (Member member in reserve.Members)
                {
                    temp += (member.Name + " ");
                }

                reserveList.dataGridView1.Rows.Add(r.Member.Name, r.Purpose, temp, r.StartTime, r.EndTime);
            }

            this.Close();
        }

        private void reserveMemberCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveMemberCreateForm != null)
            {
                reserveMemberCreateForm.Dispose();
                reserveMemberCreateForm = null;
            }
            reserveMemberCreateForm = new ReserveMemberCreateForm(members);
            reserveMemberCreateForm.Show();
        }

        private void reserveMembersCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveMembersCreateForm != null)
            {
                reserveMembersCreateForm.Dispose();
                reserveMembersCreateForm = null;
            }
            reserveMembersCreateForm = new ReserveMembersCreateForm(this, members);
            reserveMembersCreateForm.Show();
        }
    }
}
