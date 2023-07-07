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
        private ReserveMemberCreateUpdateForm reserveMemberCreateUpdateForm;
        private ReserveMembersCreateUpdateForm reserveMembersCreateUpdateForm;

        public ReserveCreateForm()
        {
            InitializeComponent();
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

        private void reserveMemberCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveMemberCreateUpdateForm != null)
            {
                reserveMemberCreateUpdateForm.Dispose();
                reserveMemberCreateUpdateForm = null;
            }
            reserveMemberCreateUpdateForm = new ReserveMemberCreateUpdateForm(this, 0);
            reserveMemberCreateUpdateForm.Show();
        }

        private void reserveMembersCreateButton_Click(object sender, EventArgs e)
        {
            if (reserveMembersCreateUpdateForm != null)
            {
                reserveMembersCreateUpdateForm.Dispose();
                reserveMembersCreateUpdateForm = null;
            }
            reserveMembersCreateUpdateForm = new ReserveMembersCreateUpdateForm(this, 0);
            reserveMembersCreateUpdateForm.Show();
        }

        private void reserveCreateButton_Click(object sender, EventArgs e)
        {
            ReserveListForm.dataGridView1.Rows.Clear();
            Member findMember = MemberRepository.Instance.findByName(reserveMemberCreateUpdateForm.MemberName);
            Reserve reserve = ReserveService.Instance.createReserve(findMember, textBox2.Text, ReserveMembersCreateUpdateForm.members, combobox1String, combobox2String);
            ReserveListForm.ReserveDB.Add(reserve);

            ReserveListForm.refreshDataGridView();

            this.Close();
        }
    }
}
