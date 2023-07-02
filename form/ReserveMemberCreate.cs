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

namespace ProjectDemo
{

    public partial class ReserveMemberCreate : Form
    {
        private List<Member> members;
        private Panel radioPanel;
        private string memberName;

        public string MemberName { get => memberName; set => memberName = value; }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string selectedOption = radioButton.Text;
                // 선택된 옵션에 대한 처리
            }
        }

        public ReserveMemberCreate(List<Member> members)
        {
            InitializeComponent();
            this.members = members;

            radioPanel = new Panel();
            radioPanel.Location = new Point(10, 10);
            radioPanel.Size = new Size(200, 200);

            for (int i = 0; i < members.Count; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = members[i].Name;
                radioButton.Location = new Point(10, 30 * i);
                radioButton.AutoSize = true;

                // 라디오버튼 이벤트 핸들러 등록
                radioButton.CheckedChanged += RadioButton_CheckedChanged;

                // 패널에 라디오버튼 추가
                radioPanel.Controls.Add(radioButton);
            }

            // Form2에 패널 추가
            this.Controls.Add(radioPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedRadioButtonText = GetSelectedRadioButtonText();

            ReserveList form1 = Application.OpenForms.OfType<ReserveList>().FirstOrDefault();
            if (form1 != null)
            {
                form1.textBox3.Text = selectedRadioButtonText;
            }

            this.MemberName = selectedRadioButtonText;

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
