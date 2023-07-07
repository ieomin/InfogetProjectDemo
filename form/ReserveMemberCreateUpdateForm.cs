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

    public partial class ReserveMemberCreateUpdateForm : Form
    {
        private Panel radioPanel;
        private string memberName;
        public string MemberName { get => memberName; set => memberName = value; }
        private ReserveCreateForm reserveCreateForm;
        private ReserveUpdateForm reserveUpdateForm;
        public static Member member = ReserveUpdateForm.member;
        private Form whatForm;

        public ReserveMemberCreateUpdateForm(Form form, int option)
        {
            InitializeComponent();
            
            if (form is ReserveCreateForm)
            {
                ReserveCreateForm reserveCreateForm = (ReserveCreateForm)form;
                whatForm = reserveCreateForm;
                this.reserveCreateForm = reserveCreateForm;
            }

            else if (form is ReserveUpdateForm)
            {
                ReserveUpdateForm reserveUpdateForm = (ReserveUpdateForm)form;
                whatForm = reserveUpdateForm;
                this.reserveUpdateForm = reserveUpdateForm;
                
            }

            radioPanel = new Panel();
            radioPanel.Location = new Point(10, 10);
            radioPanel.Size = new Size(200, 200);

            for (int i = 0; i < ReserveListForm.MemberDB.Count; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = ReserveListForm.MemberDB[i].Name;
                radioButton.Location = new Point(10, 30 * i);
                radioButton.AutoSize = true;

                // 라디오버튼 이벤트 핸들러 등록
                radioButton.CheckedChanged += RadioButton_CheckedChanged;

                // 패널에 라디오버튼 추가
                radioPanel.Controls.Add(radioButton);
            }

            this.Controls.Add(radioPanel);

            if (option == 0)
            {
                reverseMemberCreateUpdateButton.Text = "예약자명 생성";
            }
            else if (option == 1)
            {
                reverseMemberCreateUpdateButton.Text = "예약자명 변경";
            }
        }

        public static void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string selectedOption = radioButton.Text;
            }
        }


        private void reverseMemberCreateUpdateButton_Click(object sender, EventArgs e)
        {
            string selectedRadioButtonText = GetSelectedRadioButtonText();
            if (whatForm is ReserveCreateForm)
            {
                reserveCreateForm.textBox3.Text = selectedRadioButtonText;
            }
            else if (whatForm is ReserveUpdateForm)
            {
                ReserveUpdateForm.dataGridView1.Rows[0].Cells[1].Value = selectedRadioButtonText;
            }

            this.MemberName = selectedRadioButtonText;
            member = MemberRepository.Instance.findByName(this.MemberName);

            this.Close();
        }

        private string GetSelectedRadioButtonText()
        {
            // 라디오버튼 컨트롤을 탐색하여 선택된 항목을 찾고 텍스트 값을 반환
            foreach (Control control in radioPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
    }
}
