using System;
using System.Data;
using System.Windows.Forms;
using ProjectDemo.entity;
using ProjectDemo.form;
using ProjectDemo.repositoryAndService;
using ProjectDemo.service;

namespace ProjectDemo
{
    public partial class ReserveListForm : Form
    {
        private ReserveCreateForm reserveCreateForm;
        private ReserveDetailForm reserveDetailForm;
        private MemberLoginForm memberLoginForm;
        private Member loginMember;
        public Member LoginMember { get => loginMember; set => loginMember = value; }

        public static List<Member> MemberDB = new List<Member>();
        public static List<Team> TeamDB = new List<Team>();
        public static List<Reserve> ReserveDB = new List<Reserve>();
        public static List<string> timeDB = new List<string>();

        public ReserveListForm(Member loginMember = null)
        {
            InitializeComponent();
            initDB();
            initDatagridview();
            initFirstData();
            this.LoginMember = loginMember;
            ReserveCreateForm.toDatagridview += ReserveCreateForm_toDatagridview;
            MemberLoginForm.mydelegate += MemberLoginForm_mydelegate;
        }

        private void MemberLoginForm_mydelegate(bool isloginFormButtonVisible, bool islogoutButtonVisible, bool isReserveCreateButtonVisible)
        {
            loginFormButton.Visible = isloginFormButtonVisible;
            logoutButton.Visible = islogoutButtonVisible;
            reserveCreateButton.Visible = isReserveCreateButtonVisible;
        }

        private void ReserveCreateForm_toDatagridview()
        {
            dataGridView1.Rows.Clear();
        }

        private static void initDB()
        {
            timeDB.AddRange(new string[] { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00" });

            Team team_1 = new Team("1��");
            Team team_2 = new Team("2��");
            Team team_3 = new Team("3��");
            Team team_4 = new Team("4��");
            Team team_mg = new Team("�濵������");
            Team team_ch = new Team("�߱�����");
            Team team_etc = new Team("��Ÿ");

            // team_mg�� ��ü�� �����Ǿ�� ����� �� ���� -> ���� �Լ� �� ������ ���� ȣ��Ǿ� �ʵ�� �����ϳ�

            Member member01 = MemberService.Instance.createMember("�̹���", "1", "�̹���", MemberPositionStatus.����, team_etc);
            Member member03 = MemberService.Instance.createMember("����", "1", "����", MemberPositionStatus.����, team_2);
            Member member02 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.����, team_2);
            Member member04 = MemberService.Instance.createMember("ȫ����", "1", "ȫ����", MemberPositionStatus.����, team_1);
            Member member05 = MemberService.Instance.createMember("�վ���", "1", "�վ���", MemberPositionStatus.����, team_mg);
            Member member06 = MemberService.Instance.createMember("���λ�", "1", "���λ�", MemberPositionStatus.����, team_2);
            Member member07 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_1);
            Member member08 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_2);
            Member member09 = MemberService.Instance.createMember("�躸��", "1", "�躸��", MemberPositionStatus.å��, team_1);
            Member member10 = MemberService.Instance.createMember("��븸", "1", "��븸", MemberPositionStatus.å��, team_1);
            Member member11 = MemberService.Instance.createMember("Ȳ����", "1", "Ȳ����", MemberPositionStatus.å��, team_3);
            Member member12 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_3);
            Member member13 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_3);
            Member member14 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_4);
            Member member15 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.��ǥ, team_4);
            Member member16 = MemberService.Instance.createMember("�浵��", "1", "�浵��", MemberPositionStatus.��ǥ, team_mg);
            Member member17 = MemberService.Instance.createMember("�����", "1", "�����", MemberPositionStatus.�λ���, team_mg);
            Member member18 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.å��, team_mg);
            Member member19 = MemberService.Instance.createMember("����ö", "1", "����ö", MemberPositionStatus.�λ���, team_etc);
            Member member20 = MemberService.Instance.createMember("��ȣ", "1", "��ȣ", MemberPositionStatus.å��, team_ch);
            Member member21 = MemberService.Instance.createMember("������", "1", "������", MemberPositionStatus.����, team_etc);
            Member member22 = MemberService.Instance.createMember("�Ի��", "1", "�Ի��", MemberPositionStatus.���̻�, team_etc);

            MemberDB.Add(member01);
            MemberDB.Add(member02);
            MemberDB.Add(member03);
            MemberDB.Add(member04);
            MemberDB.Add(member05);
            MemberDB.Add(member06);
            MemberDB.Add(member07);
            MemberDB.Add(member08);
            MemberDB.Add(member09);
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
            MemberDB.Add(member22);
            TeamDB.Add(team_1);
            TeamDB.Add(team_2);
            TeamDB.Add(team_3);
            TeamDB.Add(team_4);
            TeamDB.Add(team_mg);
            TeamDB.Add(team_ch);
            TeamDB.Add(team_etc);
        }

        private void initDatagridview()
        {
            dataGridView1.Columns.Add("?", "ID");
            dataGridView1.Columns.Add("?", "������");
            dataGridView1.Columns.Add("?", "������");
            dataGridView1.Columns.Add("?", "�����ڵ�");
            dataGridView1.Columns.Add("?", "���۽ð�");
            dataGridView1.Columns.Add("?", "����ð�");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "�����";
            buttonColumn.Text = "��ư";
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void initFirstData()
        {
            Reserve reserve = ReserveService.Instance.createReserve(ReserveListForm.MemberDB[0], "Contech ȸ��", new List<Member> { ReserveListForm.MemberDB[1], ReserveListForm.MemberDB[2], ReserveListForm.MemberDB[3] }, ReserveListForm.timeDB[0], ReserveListForm.timeDB[1]);
            ReserveListForm.ReserveDB.Add(reserve);
            refreshDataGridView();

            monthDayLabel.Text = DateTime.Now.ToString("MM-dd");

        }

        public void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Reserve reserve in ReserveListForm.ReserveDB)
            {
                if ((reserve.IsDelete == false) && (string.Equals(reserve.DateTime.ToString("MM-dd"), uiDateTime.ToString("MM-dd"))))
                {
                    string membersNameString = reserve.toStringMembers();
                    dataGridView1.Rows.Add(reserve.Id, reserve.Member.Name, reserve.Purpose, membersNameString, reserve.StartTime, reserve.EndTime);
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
                reserveDetailForm = new ReserveDetailForm(findReserve, this);
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
            reserveCreateForm = new ReserveCreateForm(this);
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

        private void loginFormButton_Click(object sender, EventArgs e)
        {
            if (memberLoginForm != null)
            {
                memberLoginForm.Dispose();
                memberLoginForm = null;
            }
            memberLoginForm = new MemberLoginForm(this);
            memberLoginForm.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.loginMember = null;
            loginFormButton.Visible = true;
            logoutButton.Visible = false;
            reserveCreateButton.Visible = false;
        }
    }
}