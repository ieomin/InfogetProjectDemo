using ProjectDemo.entity;
using ProjectDemo.service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ProjectDemo.form
{
    partial class ReserveCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reserveMemberCreateButton = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            reserveMembersCreateButton = new Button();
            reserveCreateButton = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reserveMemberCreateButton
            // 
            reserveMemberCreateButton.Location = new Point(485, 142);
            reserveMemberCreateButton.Name = "reserveMemberCreateButton";
            reserveMemberCreateButton.Size = new Size(96, 23);
            reserveMemberCreateButton.TabIndex = 40;
            reserveMemberCreateButton.Text = "예약자 생성";
            reserveMemberCreateButton.UseVisualStyleBackColor = true;
            reserveMemberCreateButton.Click += reserveMemberCreateButton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 180);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 37;
            label7.Text = "예약목적";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 150);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 36;
            label6.Text = "예약자";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 261);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 32;
            label5.Text = "종료시간";
            // 
            // reserveMembersCreateButton
            // 
            reserveMembersCreateButton.Location = new Point(485, 195);
            reserveMembersCreateButton.Name = "reserveMembersCreateButton";
            reserveMembersCreateButton.Size = new Size(96, 23);
            reserveMembersCreateButton.TabIndex = 31;
            reserveMembersCreateButton.Text = "참여자들 생성";
            reserveMembersCreateButton.UseVisualStyleBackColor = true;
            reserveMembersCreateButton.Click += reserveMembersCreateButton_Click;
            // 
            // reserveCreateButton
            // 
            reserveCreateButton.Location = new Point(316, 287);
            reserveCreateButton.Name = "reserveCreateButton";
            reserveCreateButton.Size = new Size(75, 23);
            reserveCreateButton.TabIndex = 30;
            reserveCreateButton.Text = "예약 생성";
            reserveCreateButton.UseVisualStyleBackColor = true;
            reserveCreateButton.Click += reserveCreateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 237);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 26;
            label3.Text = "시작시간";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 208);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 25;
            label1.Text = "참여자들";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(reserveCreateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 501);
            panel1.TabIndex = 41;
            // 
            // button1
            // 
            button1.Location = new Point(397, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 42;
            button1.Text = "창닫기";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(0, 483);
            label2.Name = "label2";
            label2.Size = new Size(944, 18);
            label2.TabIndex = 1;
            label2.Text = "v1.0";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(944, 23);
            label4.TabIndex = 0;
            label4.Text = "InfogetStartProject";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(316, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 45;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.AddRange(ReserveListForm.timeDB.ToArray());
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(316, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 46;

            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox2.Items.AddRange(ReserveListForm.timeDB.ToArray());
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // ReserveCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(reserveMemberCreateButton);
            Controls.Add(textBox3);
            Controls.Add(reserveMembersCreateButton);
            Controls.Add(panel1);
            Name = "ReserveCreateForm";
            Text = "ReserveCreate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reserveMemberCreateButton;
        public TextBox textBox3;
        public TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button reserveMembersCreateButton;
        private Button reserveCreateButton;
        public TextBox textBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}