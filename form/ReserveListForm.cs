using System;
using System.Data;
using System.Windows.Forms;
using ProjectDemo.entity;
using ProjectDemo.form;
using ProjectDemo.service;

namespace ProjectDemo
{
    public partial class ReserveListForm : Form
    {
        public static List<Member> members = new List<Member>();
        private ReserveCreateForm reserveCreateForm;

        public ReserveListForm()
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

        private void reserveCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveCreateForm != null)
            {
                reserveCreateForm.Dispose();
                reserveCreateForm = null;
            }
            reserveCreateForm = new ReserveCreateForm(members, this);
            reserveCreateForm.ShowDialog();
        }
    }
}