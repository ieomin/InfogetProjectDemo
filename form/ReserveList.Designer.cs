namespace ProjectDemo
{
    partial class ReserveList
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
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(824, 225);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "참여자";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 254);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "시작시간";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(873, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(812, 339);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 11;
            label4.Text = "테스트";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(873, 336);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 23);
            textBox4.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(873, 307);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "등록";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1042, 218);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 14;
            button1.Text = "추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(873, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(873, 277);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(762, 495);
            dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(931, 138);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 19;
            label2.Text = "예약페이지";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(812, 279);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 15;
            label5.Text = "종료시간";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(824, 174);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 20;
            label6.Text = "예약자";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(808, 199);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 21;
            label7.Text = "예약목적";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(873, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(873, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(1042, 165);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 24;
            button2.Text = "추가";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 562);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        public TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox textBox2;
        public TextBox textBox3;
        private Button button2;
    }
}