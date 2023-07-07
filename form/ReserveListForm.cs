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

        private static void initializeDB()
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
            Member member1 = new Member("�̹���", MemberPositionStatus.����, team_etc);
            Member member2 = new Member("����", MemberPositionStatus.����, team_2);
            Member member3 = new Member("������", MemberPositionStatus.����, team_2);
            Member member4 = new Member("ȫ����", MemberPositionStatus.����, team_1);
            Member member5 = new Member("�վ���", MemberPositionStatus.����, team_mg);
            Member member6 = new Member("���λ�", MemberPositionStatus.����, team_2);
            Member member7 = new Member("������", MemberPositionStatus.å��, team_1);
            Member member8 = new Member("������", MemberPositionStatus.å��, team_2);
            Member member9 = new Member("�躸��", MemberPositionStatus.å��, team_1);
            Member member10 = new Member("��븸", MemberPositionStatus.å��, team_1);
            Member member11 = new Member("Ȳ����", MemberPositionStatus.å��, team_3);
            Member member12 = new Member("������", MemberPositionStatus.å��, team_3);
            Member member13 = new Member("������", MemberPositionStatus.å��, team_3);
            Member member14 = new Member("������", MemberPositionStatus.å��, team_4);
            Member member15 = new Member("������", MemberPositionStatus.å��, team_4);
            Member member16 = new Member("�浵��", MemberPositionStatus.å��, team_mg);
            Member member17 = new Member("�����", MemberPositionStatus.å��, team_mg);
            Member member18 = new Member("������", MemberPositionStatus.å��, team_mg);
            Member member19 = new Member("����ö", MemberPositionStatus.å��, team_etc);
            Member member20 = new Member("��ȣ", MemberPositionStatus.å��, team_ch);
            Member member21 = new Member("������", MemberPositionStatus.����, team_etc);

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
            Reserve reserve = ReserveService.Instance.createReserve(MemberDB[0], "Contech ȸ��", new List<Member> { MemberDB[1], MemberDB[2], MemberDB[3] }, timeDB[0], timeDB[1]);
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