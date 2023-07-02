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