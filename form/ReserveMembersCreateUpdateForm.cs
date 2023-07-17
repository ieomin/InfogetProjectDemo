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
        public static List<Member> members;

        public delegate void MyEventHandler1(string membersString);
        public static event MyEventHandler1 myEventHandler1;

        public delegate void MyEventHandler2(string membersString);
        public static event MyEventHandler2 myEventHandler2;

        public ReserveMembersCreateUpdateForm(Form form, List<Member> ms)
        {
            InitializeComponent();
            members = ms;
            whatForm = form;
            if (form is ReserveCreateForm)
            {
                reserveMembersCreateUpdateButton.Text = "참여자들 생성";
            }
            else if (form is ReserveUpdateForm)
            {
                reserveMembersCreateUpdateButton.Text = "참여자들 변경";

            }

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
        
        private Form whatForm;
        private void reserveMembersCreateUpdateButton_Click(object sender, EventArgs e)
        {
            ReserveMembersCreateUpdateForm.members = new List<Member>();
            int memberCount = checkedListBox1.Items.Count;
            for (int i = 0; i < memberCount; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string memberName = checkedListBox1.Items[i].ToString();
                    Member member = MemberRepository.Instance.findByName(memberName);
                    ReserveMembersCreateUpdateForm.members.Add(member);
                }
            }

            string membersString = "";
            foreach (Member member in ReserveMembersCreateUpdateForm.members)
            {
                membersString += (member.Name + " ");
            }
            if (whatForm is ReserveCreateForm)
            {
                myEventHandler1(membersString);
            }
            else if (whatForm is ReserveUpdateForm)
            {
                //ReserveUpdateForm.dataGridView1.Rows[0].Cells[2].Value = membersString;
                myEventHandler2(membersString);
            }

            Close();

        }
    }
}
