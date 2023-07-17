using ProjectDemo.entity;
using ProjectDemo.repositoryAndService;
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
    public partial class MemberLoginForm : Form
    {
        public static Member loginMember;
        private ReserveListForm reserveListForm;

        public delegate void MyDelegate(bool isloginFormButtonVisible, bool islogoutButtonVisible, bool isReserveCreateButtonVisible);
        public static event MyDelegate mydelegate;

        public MemberLoginForm(ReserveListForm reserveListForm)
        {
            InitializeComponent();
            this.reserveListForm = reserveListForm;
        }

        private string loginId, password;
        private void loginIdTextbox_TextChanged(object sender, EventArgs e)
        {
            loginId = loginIdTextbox.Text;
        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            password = loginPasswordTextbox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (Member member in ReserveListForm.MemberDB)
            {
                if (member.LoginId == loginId)
                {
                    b = true;
                    if (member.Password == password)
                    {
                        loginMember = member;

                        reserveListForm.LoginMember = loginMember;
                        //ReserveListForm.loginFormButton.Visible = false;
                        //ReserveListForm.logoutButton.Visible = true;
                        mydelegate(false, true, true);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다");
                        break;
                    }
                }
            }

            if(b == false)
            {
                MessageBox.Show("일치하는 로그인 ID가 존재하지 않습니다");
            }
        }
    }
}
