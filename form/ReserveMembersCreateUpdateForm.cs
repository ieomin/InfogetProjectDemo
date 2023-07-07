using ProjectDemo.entity;
using ProjectDemo.form;
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

namespace ProjectDemo
{
    public partial class ReserveMembersCreateUpdateForm : Form
    {
        private ReserveCreateForm reserveCreateForm;
        private ReserveUpdateForm reserveUpdateForm;
        public static List<Member> members = ReserveUpdateForm.members;
        private Form whatForm;

        public ReserveMembersCreateUpdateForm(Form form, int option)
        {
            InitializeComponent();
            whatForm = form;
            if (form is ReserveCreateForm)
            {
                ReserveCreateForm reserveCreateForm = (ReserveCreateForm)form;
                this.reserveCreateForm = reserveCreateForm;
            }
            else if (form is ReserveUpdateForm)
            {
                ReserveUpdateForm reserveUpdateForm = (ReserveUpdateForm)form;
                this.reserveUpdateForm = reserveUpdateForm;

            }
            if (option == 0)
            {
                reserveMembersCreateUpdateButton.Text = "참여자들 생성";
            }
            else if (option == 1)
            {
                reserveMembersCreateUpdateButton.Text = "참여자들 변경";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Member member in ReserveListForm.MemberDB)
            {
                checkedListBox1.Items.Add(member.Name);
            }

            foreach (Team team in ReserveListForm.TeamDB)
            {
                TreeNode teamNode = new TreeNode(team.Name);
                treeView1.Nodes.Add(teamNode);

                foreach (Member member in team.Members)
                {
                    TreeNode memberNode = new TreeNode(member.Name);
                    teamNode.Nodes.Add(memberNode);
                }
            }
        }

        private void reserveMembersCreateUpdateButton_Click(object sender, EventArgs e)
        {
            members = new List<Member>();
            int memberCount = checkedListBox1.Items.Count;
            for (int i = 0; i < memberCount; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string memberName = checkedListBox1.Items[i].ToString();
                    Member member = MemberRepository.Instance.findByName(memberName);
                    members.Add(member);
                }
            }

            string memberNames = "";
            foreach (Member member in members)
            {
                memberNames += (member.Name + " ");
            }
            if (whatForm is ReserveCreateForm)
            {
                reserveCreateForm.textBox1.Text = memberNames;
            }
            else if (whatForm is ReserveUpdateForm)
            {
                ReserveUpdateForm.dataGridView1.Rows[0].Cells[2].Value = memberNames;
            }



            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
