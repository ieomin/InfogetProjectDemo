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
        private ReserveCreateForm reserveCreateForm;
        private ReserveDetailForm reserveDetailForm;

        public static List<Member> MemberDB = new List<Member>();
        public static List<Team> TeamDB = new List<Team>();
        public static List<Reserve> ReserveDB = new List<Reserve>();
        public static List<string> timeDB = new List<string>();

        public ReserveListForm()
        {
            InitializeComponent();
            initDatagridview();
            initializeDB();
            initFirstData();
        }
        private void initDatagridview()
        {
            dataGridView1.Columns.Add("?", "ID");
            dataGridView1.Columns.Add("?", "예약자");
            dataGridView1.Columns.Add("?", "사용목적");
            dataGridView1.Columns.Add("?", "참석자들");
            dataGridView1.Columns.Add("?", "시작시간");
            dataGridView1.Columns.Add("?", "종료시간");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "예약상세";
            buttonColumn.Text = "버튼";
            dataGridView1.Columns.Add(buttonColumn);
        }

        private static void initializeDB()
        {
            timeDB.AddRange(new string[] { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00" });

            Team team_1 = new Team("1팀");
            Team team_2 = new Team("2팀");
            Team team_3 = new Team("3팀");
            Team team_4 = new Team("4팀");
            Team team_mg = new Team("경영지원팀");
            Team team_ch = new Team("중국지사");
            Team team_etc = new Team("기타");

            // team_mg는 객체가 생성되어야 사용할 수 있음 -> 물론 함수 밖 선언이 먼저 호출되어 필드는 존재하나
            Member member1 = new Member("이범진", MemberPositionStatus.주임, team_etc);
            Member member2 = new Member("김상겸", MemberPositionStatus.주임, team_2);
            Member member3 = new Member("진동원", MemberPositionStatus.선임, team_2);
            Member member4 = new Member("홍진주", MemberPositionStatus.주임, team_1);
            Member member5 = new Member("손아현", MemberPositionStatus.주임, team_mg);
            Member member6 = new Member("유인상", MemberPositionStatus.주임, team_2);
            Member member7 = new Member("박진형", MemberPositionStatus.책임, team_1);
            Member member8 = new Member("윤정수", MemberPositionStatus.책임, team_2);
            Member member9 = new Member("김보경", MemberPositionStatus.책임, team_1);
            Member member10 = new Member("김대만", MemberPositionStatus.책임, team_1);
            Member member11 = new Member("황원록", MemberPositionStatus.책임, team_3);
            Member member12 = new Member("신현곤", MemberPositionStatus.책임, team_3);
            Member member13 = new Member("박지연", MemberPositionStatus.책임, team_3);
            Member member14 = new Member("강동균", MemberPositionStatus.책임, team_4);
            Member member15 = new Member("최형순", MemberPositionStatus.책임, team_4);
            Member member16 = new Member("경도현", MemberPositionStatus.책임, team_mg);
            Member member17 = new Member("손장락", MemberPositionStatus.책임, team_mg);
            Member member18 = new Member("강선영", MemberPositionStatus.책임, team_mg);
            Member member19 = new Member("김형철", MemberPositionStatus.책임, team_etc);
            Member member20 = new Member("우호", MemberPositionStatus.책임, team_ch);
            Member member21 = new Member("문종헌", MemberPositionStatus.선임, team_etc);

            MemberDB.Add(member1);
            MemberDB.Add(member2);
            MemberDB.Add(member3);
            MemberDB.Add(member4);
            MemberDB.Add(member5);
            MemberDB.Add(member6);
            MemberDB.Add(member7);
            MemberDB.Add(member8);
            MemberDB.Add(member9);
            MemberDB.Add(member10);
            MemberDB.Add(member11);
            MemberDB.Add(member12);
            MemberDB.Add(member13);
            MemberDB.Add(member14);
            MemberDB.Add(member15);
            MemberDB.Add(member16);
            MemberDB.Add(member17);
            MemberDB.Add(member18);
            MemberDB.Add(member19);
            MemberDB.Add(member20);
            MemberDB.Add(member21);
            TeamDB.Add(team_1);
            TeamDB.Add(team_2);
            TeamDB.Add(team_3);
            TeamDB.Add(team_4);
            TeamDB.Add(team_mg);
            TeamDB.Add(team_ch);
            TeamDB.Add(team_etc);
        }

        private void initFirstData()
        {
            Reserve reserve = ReserveService.Instance.createReserve(MemberDB[0], "Contech 회의", new List<Member> { MemberDB[1], MemberDB[2], MemberDB[3] }, timeDB[0], timeDB[1]);
            ReserveDB.Add(reserve);
            ReserveListForm.refreshDataGridView();

            monthDayLabel.Text = DateTime.Now.ToString("MM-dd");

        }

        public static void refreshDataGridView()
        {
            ReserveListForm.dataGridView1.Rows.Clear();
            foreach (Reserve reserve in ReserveListForm.ReserveDB)
            {
                if ((reserve.IsDelete == false) && (string.Equals(reserve.DateTime.ToString("MM-dd"), uiDateTime.ToString("MM-dd"))))
                {
                    string membersNameString = reserve.toStringMembers();
                    ReserveListForm.dataGridView1.Rows.Add(reserve.Id, reserve.Member.Name, reserve.Purpose, membersNameString, reserve.StartTime, reserve.EndTime);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[0];
                string s = cell.Value?.ToString();
                long id = long.Parse(s);
                Reserve findReserve = ReserveRepository.Instance.findById(id);

                if (reserveDetailForm != null)
                {
                    reserveDetailForm.Dispose();
                    reserveDetailForm = null;
                }
                reserveDetailForm = new ReserveDetailForm(findReserve);
                reserveDetailForm.Show();
            }
        }

        private void reserveCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveCreateForm != null)
            {
                reserveCreateForm.Dispose();
                reserveCreateForm = null;
            }
            reserveCreateForm = new ReserveCreateForm();
            reserveCreateForm.ShowDialog();
        }

        public static DateTime uiDateTime = DateTime.Now;

        private void leftButton_Click(object sender, EventArgs e)
        {
            uiDateTime = uiDateTime.AddDays(-1);

            monthDayLabel.Text = uiDateTime.ToString("MM-dd");

            refreshDataGridView();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            uiDateTime = uiDateTime.AddDays(1);

            monthDayLabel.Text = uiDateTime.ToString("MM-dd");

            refreshDataGridView();
        }
    }
}