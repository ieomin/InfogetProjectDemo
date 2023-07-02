using System;
using System.Data;
using ProjectDemo.entity;
using ProjectDemo.form;
using ProjectDemo.service;

namespace ProjectDemo
{
    public partial class ReserveList : Form
    {

        private List<Team> teams;
        public static List<Member> members = new List<Member>();
        private List<Reserve> reserves = new List<Reserve>();

        private ReserveService reserveService = new ReserveService();

        private MemberRepository memberRepository = new MemberRepository();

        private ReserveMembersCreate reserveMembersCreate;
        private ReserveMemberCreate reserveMemberCreate;
        private ReserveCreate reserveCreate;

        public ReserveList()
        {
            InitializeComponent();
            InitializeData();
            InitDatagridview();
        }

        private void InitializeData()
        {
            Team team_1 = new Team("1팀");
            Team team_2 = new Team("2팀");
            Team team_3 = new Team("3팀");
            Team team_4 = new Team("4팀");
            Team team_mg = new Team("경영지원팀");
            Team team_ch = new Team("중국지사");
            Team team_etc = new Team("기타");

            members.Add(new Member("유인상", PositionStatus.주임, team_2));
            members.Add(new Member("손아현", PositionStatus.주임, team_mg));
            members.Add(new Member("홍진주", PositionStatus.주임, team_1));
            members.Add(new Member("진동원", PositionStatus.선임, team_2));
            members.Add(new Member("김상겸", PositionStatus.주임, team_2));
            members.Add(new Member("이범진", PositionStatus.주임, team_etc));
        }

        private void InitDatagridview()
        {
            dataGridView1.Columns.Add("?", "예약자");
            dataGridView1.Columns.Add("?", "사용목적");
            dataGridView1.Columns.Add("?", "참석자");
            dataGridView1.Columns.Add("?", "시작시간");
            dataGridView1.Columns.Add("?", "종료시간");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reserveMembersCreate != null)
            {
                reserveMembersCreate.Dispose();
                reserveMembersCreate = null;
            }
            reserveMembersCreate = new ReserveMembersCreate(this, members);
            reserveMembersCreate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reserveMemberCreate != null)
            {
                reserveMemberCreate.Dispose();
                reserveMemberCreate = null;
            }
            reserveMemberCreate = new ReserveMemberCreate(members);
            reserveMemberCreate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Member findMember = memberRepository.findByName(reserveMemberCreate.MemberName);

            Reserve reserve = reserveService.createReserve(findMember, textBox2.Text, reserveMembersCreate.Members, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            reserves.Add(reserve);



            foreach (Reserve r in reserves)
            {
                string temp = "";
                foreach (Member member in reserve.Members)
                {
                    temp += (member.Name + " ");
                }

                dataGridView1.Rows.Add(r.Member.Name, r.Purpose, temp, r.StartTime, r.EndTime);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reserveCreate != null)
            {
                reserveCreate.Dispose();
                reserveCreate = null;
            }
            reserveCreate = new ReserveCreate(members);
            reserveCreate.Show();
        }
    }
}