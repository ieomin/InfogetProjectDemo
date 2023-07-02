using ProjectDemo.entity;
using ProjectDemo.form;
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
    public partial class ReserveMembersCreateForm : Form
    {
        private ReserveCreateForm reserveCreateForm;
        private List<Member> members;

        public List<Member> Members { get => members; set => members = value; }

        public ReserveMembersCreateForm(ReserveCreateForm form1, List<Member> members)
        {
            InitializeComponent();
            this.reserveCreateForm = form1;
            this.members = members;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Member member in members)
            {
                checkedListBox1.Items.Add(member.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            members = new List<Member>();
            int memberCount = checkedListBox1.Items.Count;
            for (int i = 0; i < memberCount; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string memberName = checkedListBox1.Items[i].ToString();
                    Member member = new Member(memberName, PositionStatus.주임, null);
                    members.Add(member);
                }
            }

            string text = "";
            foreach (Member member in members) text += (member.Name + " ");

            reserveCreateForm.textBox1.Text = text;

            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
