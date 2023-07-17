using ProjectDemo.entity;
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

namespace ProjectDemo.form
{

    public partial class ReserveCreateForm : Form
    {
        private ReserveMembersCreateUpdateForm reserveMembersCreateUpdateForm;
        public delegate void MyDelegate();
        public static event MyDelegate toDatagridview;
        private ReserveListForm reserveListForm;

        public ReserveCreateForm(ReserveListForm reserveListForm)
        {
            InitializeComponent();
            comboBox1.DataSource = new List<string>(ReserveListForm.timeDB);
            comboBox2.DataSource = new List<string>(ReserveListForm.timeDB);
            ReserveMembersCreateUpdateForm.myEventHandler1 += toMembersTextbox;
            this.reserveListForm = reserveListForm;
        }

        private string combobox1String, combobox2String;

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox1String = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox2String = comboBox2.SelectedItem.ToString();
        }

        private void reserveMembersCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveMembersCreateUpdateForm != null)
            {
                reserveMembersCreateUpdateForm.Dispose();
                reserveMembersCreateUpdateForm = null;
            }
            reserveMembersCreateUpdateForm = new ReserveMembersCreateUpdateForm(this, null);
            reserveMembersCreateUpdateForm.Show();
        }

        private void reserveCreateButton_Click(object sender, EventArgs e)
        {
            //ReserveListForm.dataGridView1.Rows.Clear();
            toDatagridview();
            Reserve reserve = ReserveService.Instance.createReserve(MemberLoginForm.loginMember, purposeTextbox.Text, ReserveMembersCreateUpdateForm.members, combobox1String, combobox2String);
            ReserveListForm.ReserveDB.Add(reserve);

            reserveListForm.refreshDataGridView();

            this.Close();
        }

        private void toMembersTextbox(string memberNames)
        {
            membersTextbox.Text = memberNames;
        }

    }
}
