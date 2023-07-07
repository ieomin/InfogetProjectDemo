namespace ProjectDemo.form
{
    partial class ReserveUpdateForm
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
            dataGridView1 = new DataGridView();
            reserveUpdateButton = new Button();
            reserveMemberUpdateButton = new Button();
            reserveMembersUpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.AllowUserToAddRows = false;

            // 
            // reserveUpdateButton
            // 
            reserveUpdateButton.Location = new Point(464, 415);
            reserveUpdateButton.Name = "reserveUpdateButton";
            reserveUpdateButton.Size = new Size(75, 23);
            reserveUpdateButton.TabIndex = 1;
            reserveUpdateButton.Text = "예약 변경";
            reserveUpdateButton.UseVisualStyleBackColor = true;
            reserveUpdateButton.Click += reserveUpdateButton_Click;
            // 
            // reserveMemberUpdateButton
            // 
            reserveMemberUpdateButton.Location = new Point(245, 415);
            reserveMemberUpdateButton.Name = "reserveMemberUpdateButton";
            reserveMemberUpdateButton.Size = new Size(96, 23);
            reserveMemberUpdateButton.TabIndex = 2;
            reserveMemberUpdateButton.Text = "예약자명 변경";
            reserveMemberUpdateButton.UseVisualStyleBackColor = true;
            reserveMemberUpdateButton.Click += reserveMemberUpdateButton_Click;
            // 
            // reserveMembersUpdateButton
            // 
            reserveMembersUpdateButton.Location = new Point(347, 415);
            reserveMembersUpdateButton.Name = "reserveMembersUpdateButton";
            reserveMembersUpdateButton.Size = new Size(111, 23);
            reserveMembersUpdateButton.TabIndex = 3;
            reserveMembersUpdateButton.Text = "참석자들 변경";
            reserveMembersUpdateButton.UseVisualStyleBackColor = true;
            reserveMembersUpdateButton.Click += reserveMembersUpdateButton_Click;
            // 
            // ReserveUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reserveMembersUpdateButton);
            Controls.Add(reserveMemberUpdateButton);
            Controls.Add(reserveUpdateButton);
            Controls.Add(dataGridView1);
            Name = "ReserveUpdateForm";
            Text = "ReserveUpdateForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button reserveUpdateButton;
        private Button reserveMemberUpdateButton;
        private Button reserveMembersUpdateButton;
        public static DataGridView dataGridView1;
    }
}