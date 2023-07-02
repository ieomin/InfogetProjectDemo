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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(829, 384);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            reserveCreateButton.Location = new Point(388, 434);
            reserveCreateButton.Name = "button1";
            reserveCreateButton.Size = new Size(75, 23);
            reserveCreateButton.TabIndex = 19;
            reserveCreateButton.Text = "예약 등록";
            reserveCreateButton.UseVisualStyleBackColor = true;
            reserveCreateButton.Click += reserveCreateButton_Click;
            // 
            // ReserveList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 481);
            Controls.Add(reserveCreateButton);
            Controls.Add(dataGridView1);
            Name = "ReserveList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dataGridView1;
        private Button reserveCreateButton;
    }
}
    