namespace ProjectDemo.form
{
    partial class ReserveDetailForm
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
            reserveDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(888, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.AllowUserToAddRows = false;
            // 
            // reserveUpdateButton
            // 
            reserveUpdateButton.Location = new Point(353, 455);
            reserveUpdateButton.Name = "reserveUpdateButton";
            reserveUpdateButton.Size = new Size(75, 23);
            reserveUpdateButton.TabIndex = 1;
            reserveUpdateButton.Text = "예약 변경";
            reserveUpdateButton.UseVisualStyleBackColor = true;
            reserveUpdateButton.Click += reserveUpdateButton_Click;
            // 
            // reserveDeleteButton
            // 
            reserveDeleteButton.Location = new Point(434, 455);
            reserveDeleteButton.Name = "reserveDeleteButton";
            reserveDeleteButton.Size = new Size(75, 23);
            reserveDeleteButton.TabIndex = 2;
            reserveDeleteButton.Text = "예약 삭제";
            reserveDeleteButton.UseVisualStyleBackColor = true;
            reserveDeleteButton.Click += reserveDeleteButton_Click;
            // 
            // ReserveDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(reserveDeleteButton);
            Controls.Add(reserveUpdateButton);
            Controls.Add(dataGridView1);
            Name = "ReserveDetailForm";
            Text = "ReserveDetailForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button reserveUpdateButton;
        private Button reserveDeleteButton;
        public static DataGridView dataGridView1;
    }
}
