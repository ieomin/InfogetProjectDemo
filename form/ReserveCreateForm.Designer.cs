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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            reserveMembersCreateButton = new Button();
            reserveCreateButton = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            reserveMemberCreateButton.Location = new Point(485, 142);
            reserveMemberCreateButton.Name = "button2";
            reserveMemberCreateButton.Size = new Size(65, 23);
            reserveMemberCreateButton.TabIndex = 40;
            reserveMemberCreateButton.Text = "추가";
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
            textBox2.Location = new Point(316, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 176);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 37;
            label7.Text = "예약목적";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 151);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 36;
            label6.Text = "예약자";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(316, 254);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(316, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 256);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 32;
            label5.Text = "종료시간";
            // 
            // button1
            // 
            reserveMembersCreateButton.Location = new Point(485, 195);
            reserveMembersCreateButton.Name = "button1";
            reserveMembersCreateButton.Size = new Size(65, 23);
            reserveMembersCreateButton.TabIndex = 31;
            reserveMembersCreateButton.Text = "추가";
            reserveMembersCreateButton.UseVisualStyleBackColor = true;
            reserveMembersCreateButton.Click += reserveMembersCreateButton_Click;
            // 
            // button4
            // 
            reserveCreateButton.Location = new Point(316, 284);
            reserveCreateButton.Name = "button4";
            reserveCreateButton.Size = new Size(75, 23);
            reserveCreateButton.TabIndex = 30;
            reserveCreateButton.Text = "등록";
            reserveCreateButton.UseVisualStyleBackColor = true;
            reserveCreateButton.Click += reserveCreateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 231);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 26;
            label3.Text = "시작시간";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 202);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 25;
            label1.Text = "참여자";
            // 
            // ReserveCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reserveMemberCreateButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(reserveMembersCreateButton);
            Controls.Add(reserveCreateButton);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ReserveCreate";
            Text = "ReserveCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reserveMemberCreateButton;
        public TextBox textBox3;
        public TextBox textBox2;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button reserveMembersCreateButton;
        private Button reserveCreateButton;
        public TextBox textBox1;
        private Label label3;
        private Label label1;
    }
}