using ProjectDemo.entity;
using ProjectDemo.form;
using ProjectDemo.service;

namespace ProjectDemo
{
    partial class ReserveListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            reserveCreateButton = new Button();
            panel1 = new Panel();
            monthDayLabel = new Label();
            rightButton = new Button();
            leftButton = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(795, 299);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // reserveCreateButton
            // 
            reserveCreateButton.Location = new Point(375, 426);
            reserveCreateButton.Name = "reserveCreateButton";
            reserveCreateButton.Size = new Size(75, 23);
            reserveCreateButton.TabIndex = 19;
            reserveCreateButton.Text = "예약 생성";
            reserveCreateButton.UseVisualStyleBackColor = true;
            reserveCreateButton.Click += reserveCreateButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(monthDayLabel);
            panel1.Controls.Add(rightButton);
            panel1.Controls.Add(leftButton);
            panel1.Controls.Add(reserveCreateButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 501);
            panel1.TabIndex = 20;
            // 
            // monthDayLabel
            // 
            monthDayLabel.AutoSize = true;
            monthDayLabel.Location = new Point(402, 63);
            monthDayLabel.Name = "monthDayLabel";
            monthDayLabel.Size = new Size(38, 15);
            monthDayLabel.TabIndex = 22;
            monthDayLabel.Text = "00.00";
            // 
            // rightButton
            // 
            rightButton.Location = new Point(447, 59);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(23, 23);
            rightButton.TabIndex = 21;
            rightButton.Text = ">";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // leftButton
            // 
            leftButton.Location = new Point(375, 59);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(19, 23);
            leftButton.TabIndex = 20;
            leftButton.Text = "<";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(944, 23);
            label1.TabIndex = 0;
            label1.Text = "InfogetStartProject";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(944, 213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 21;
            // 
            // ReserveListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 501);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Name = "ReserveListForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button reserveCreateButton;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        public static DataGridView dataGridView1;
        private Button leftButton;
        private Button rightButton;
        private Label monthDayLabel;
    }
}
