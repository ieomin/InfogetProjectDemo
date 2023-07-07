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
    public partial class ReserveUpdateForm : Form
    {
        private Reserve reserve;

        private ReserveMemberCreateUpdateForm reserveMemberForm;
        private ReserveMembersCreateUpdateForm reserveMembersForm;

        // 다른 데서 갖다 쓸려고
        public static Member member;
        public static List<Member> members;

        public ReserveUpdateForm(Reserve reserve)
        {
            InitializeComponent();
            InitDatagridview();
            this.reserve = reserve;
            member = reserve.Member;
            members = reserve.Members;

            string id = reserve.Id.ToString();
            string memberName = reserve.Member.Name;
            string purpose = reserve.Purpose.ToString();
            string ReserveMembers = reserve.toStringMembers();
            string startTime = reserve.StartTime;
            string endTime = reserve.EndTime;

            dataGridView1.Rows.Add(id, memberName, ReserveMembers, purpose, startTime, endTime);

            SetComboBoxCell(4, 0, ReserveListForm.timeDB, startTime);
            SetComboBoxCell(5, 0, ReserveListForm.timeDB, endTime);

            dataGridView1.Rows[0].Cells[0].ReadOnly = true;
        }

        private void InitDatagridview()
        {
            dataGridView1.Columns.Add("?", "예약ID");
            dataGridView1.Columns.Add("?", "예약자명");
            dataGridView1.Columns.Add("?", "참석자들");
            dataGridView1.Columns.Add("?", "사용목적");
            dataGridView1.Columns.Add("?", "시작시간");
            dataGridView1.Columns.Add("?", "종료시간");
        }

        private void reserveMemberUpdateButton_Click(object sender, EventArgs e)
        {
            if (reserveMemberForm != null)
            {
                reserveMemberForm.Dispose();
                reserveMemberForm = null;
            }
            reserveMemberForm = new ReserveMemberCreateUpdateForm(this, 1);
            reserveMemberForm.Show();
        }

        private void reserveMembersUpdateButton_Click(object sender, EventArgs e)
        {
            if (reserveMembersForm != null)
            {
                reserveMembersForm.Dispose();
                reserveMembersForm = null;
            }
            reserveMembersForm = new ReserveMembersCreateUpdateForm(this, 1);
            reserveMembersForm.Show();
        }

        private void reserveUpdateButton_Click(object sender, EventArgs e)
        {
            string reserveId = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string updateReservePurpose = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string updateReserveStartTime = dataGridView1.Rows[0].Cells[4].Value.ToString();
            string updateReserveEndTime = dataGridView1.Rows[0].Cells[5].Value.ToString();

            for (int i = 0; i < ReserveListForm.ReserveDB.Count; i++)
            {
                if (ReserveListForm.ReserveDB[i].Id.ToString() == reserveId)
                {
                    ReserveListForm.ReserveDB[i].Member = ReserveMemberCreateUpdateForm.member;
                    ReserveListForm.ReserveDB[i].Members = ReserveMembersCreateUpdateForm.members;
                    ReserveListForm.ReserveDB[i].Purpose = updateReservePurpose;
                    ReserveListForm.ReserveDB[i].StartTime = updateReserveStartTime;
                    ReserveListForm.ReserveDB[i].EndTime = updateReserveEndTime;
                }
            }

            ReserveDetailForm.dataGridView1.Rows.Clear();

            Reserve findReserve = ReserveRepository.Instance.findById(long.Parse(reserveId));

            ReserveDetailForm.dataGridView1.Rows.Add(
                findReserve.Id.ToString(),
                findReserve.Member.Name,
                findReserve.Member.PositionStatus.ToString(),
                findReserve.Member.Team.Name,
                findReserve.Purpose,
                findReserve.toStringMembers(),
                updateReserveStartTime,
                updateReserveEndTime);

            Close();
        }

        private void SetComboBoxCell(int columnIndex, int rowIndex, List<string> list, string timeName)
        {
            string[] items = list.ToArray();
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.Items.AddRange(items);
            comboBoxCell.Value = timeName;
            dataGridView1[columnIndex, rowIndex] = comboBoxCell;
        }

        DataGridViewComboBoxEditingControl comboBoxEditingControl;
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            comboBoxEditingControl = e.Control as DataGridViewComboBoxEditingControl;

            if (comboBoxEditingControl != null && dataGridView.CurrentCell is DataGridViewComboBoxCell)
            {
                comboBoxEditingControl.DropDownStyle = ComboBoxStyle.DropDown;

                comboBoxEditingControl.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                comboBoxEditingControl.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var currentCell = dataGridView1.CurrentCell;

            if (currentCell != null && comboBox.SelectedItem != null)
            {
                currentCell.Value = comboBox.SelectedItem.ToString();
                dataGridView1.EndEdit();
            }

            comboBoxEditingControl.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
        }
    }
}
