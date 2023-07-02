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
            Team team_1 = new Team("1��");
            Team team_2 = new Team("2��");
            Team team_3 = new Team("3��");
            Team team_4 = new Team("4��");
            Team team_mg = new Team("�濵������");
            Team team_ch = new Team("�߱�����");
            Team team_etc = new Team("��Ÿ");

            members.Add(new Member("���λ�", PositionStatus.����, team_2));
            members.Add(new Member("�վ���", PositionStatus.����, team_mg));
            members.Add(new Member("ȫ����", PositionStatus.����, team_1));
            members.Add(new Member("������", PositionStatus.����, team_2));
            members.Add(new Member("����", PositionStatus.����, team_2));
            members.Add(new Member("�̹���", PositionStatus.����, team_etc));
        }

        private void InitDatagridview()
        {
            dataGridView1.Columns.Add("?", "������");
            dataGridView1.Columns.Add("?", "������");
            dataGridView1.Columns.Add("?", "������");
            dataGridView1.Columns.Add("?", "���۽ð�");
            dataGridView1.Columns.Add("?", "����ð�");

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