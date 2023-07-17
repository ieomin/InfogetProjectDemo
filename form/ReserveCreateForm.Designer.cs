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
            purposeTextbox = new TextBox();
            label7 = new Label();
            label5 = new Label();
            reserveMembersCreateButton = new Button();
            reserveCreateButton = new Button();
            membersTextbox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // purposeTextbox
            // 
            purposeTextbox.Location = new Point(316, 172);
            purposeTextbox.Name = "purposeTextbox";
            purposeTextbox.Size = new Size(163, 23);
            purposeTextbox.TabIndex = 38;
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
            // membersTextbox
            // 
            membersTextbox.Location = new Point(316, 200);
            membersTextbox.Name = "membersTextbox";
            membersTextbox.Size = new Size(163, 23);
            membersTextbox.TabIndex = 27;
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(purposeTextbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(reserveCreateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(membersTextbox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 501);
            panel1.TabIndex = 41;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(316, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 46;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(316, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 45;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // ReserveCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(reserveMembersCreateButton);
            Controls.Add(panel1);
            Name = "ReserveCreateForm";
            Text = "ReserveCreate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox purposeTextbox;
        private Label label7;
        private Label label5;
        private Button reserveMembersCreateButton;
        private Button reserveCreateButton;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox membersTextbox;
    }
}