using ProjectDemo.entity;
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
    public partial class ReserveDetailForm : Form
    {
        private Reserve reserve;

        private ReserveUpdateForm reserveUpdateForm;

        public ReserveDetailForm(Reserve reserve)
        {
            InitializeComponent();
            this.reserve = reserve;

            InitDatagridview();

            string reserveId = reserve.Id.ToString();
            string memberName = reserve.Member.Name;
            string memberPosition = reserve.Member.PositionStatus.ToString();
            string memberTeamName = reserve.Member.Team.Name;
            string purpose = reserve.Purpose;
            string members = reserve.toStringMembers();
            string startTime = reserve.StartTime;
            string endTime = reserve.EndTime;

            dataGridView1.Rows.Add(reserveId, memberName, memberPosition, memberTeamName, purpose, members, startTime, endTime);
        }

        private void InitDatagridview()
        {
            dataGridView1.Columns.Add("?", "예약ID");
            dataGridView1.Columns.Add("?", "예약자명");
            dataGridView1.Columns.Add("?", "예약자직급");
            dataGridView1.Columns.Add("?", "예약자팀이름");
            dataGridView1.Columns.Add("?", "예약목적");
            dataGridView1.Columns.Add("?", "참석자");
            dataGridView1.Columns.Add("?", "시작시간");
            dataGridView1.Columns.Add("?", "종료시간");
        }

        private void reserveUpdateButton_Click(object sender, EventArgs e)
        {
            if (reserveUpdateForm != null)
            {
                reserveUpdateForm.Dispose();
                reserveUpdateForm.Close();
            }
            reserveUpdateForm = new ReserveUpdateForm(reserve);

            reserveUpdateForm.ShowDialog();

            ReserveListForm.refreshDataGridView();
        }

        private void reserveDeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ReserveListForm.ReserveDB.Count; i++)
            {
                if (ReserveListForm.ReserveDB[i].Id == reserve.Id);
                {
                    ReserveListForm.ReserveDB[i].IsDelete = true;
                }
            }

            ReserveListForm.refreshDataGridView();

            Close();

        }
    }
}
