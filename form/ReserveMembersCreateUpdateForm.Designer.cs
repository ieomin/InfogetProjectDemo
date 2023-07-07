using ProjectDemo.entity;

namespace ProjectDemo
{
    partial class ReserveMembersCreateUpdateForm
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
            checkedListBox1 = new CheckedListBox();
            reserveMembersCreateUpdateButton = new Button();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(28, 11);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(352, 418);
            checkedListBox1.TabIndex = 0;
            // 
            // reserveMembersCreateUpdateButton
            // 
            reserveMembersCreateUpdateButton.Location = new Point(28, 446);
            reserveMembersCreateUpdateButton.Name = "reserveMembersCreateUpdateButton";
            reserveMembersCreateUpdateButton.Size = new Size(106, 23);
            reserveMembersCreateUpdateButton.TabIndex = 15;
            reserveMembersCreateUpdateButton.Text = "참여자들 생성";
            reserveMembersCreateUpdateButton.UseVisualStyleBackColor = true;
            reserveMembersCreateUpdateButton.Click += reserveMembersCreateUpdateButton_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(436, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(377, 417);
            treeView1.TabIndex = 16;
            treeView1.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            // 
            // ReserveMembersCreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 492);
            Controls.Add(treeView1);
            Controls.Add(reserveMembersCreateUpdateButton);
            Controls.Add(checkedListBox1);
            Name = "ReserveMembersCreateUpdateForm";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion



        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Parent != null && selectedNode.Parent.Text == "Teams")
            {
                // 팀 TreeNode을 클릭한 경우
                // 자식 노드 확장/축소 처리 등
                MessageBox.Show("TeamNodeSelect Alert");
            }
            else
            {
                // Member TreeNode을 클릭한 경우
                // 선택한 Member 객체에 대한 처리 등
                MessageBox.Show("MemberNodeSelect Alert");
            }
        }

        private CheckedListBox checkedListBox1;
        private Button reserveMembersCreateUpdateButton;
        private TreeView treeView1;

        private int checkBoxMargin = 5; // 체크박스의 수직 마진


    }
}
