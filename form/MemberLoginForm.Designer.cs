namespace ProjectDemo.form
{
    partial class MemberLoginForm
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
            loginIdTextbox = new TextBox();
            loginPasswordTextbox = new TextBox();
            loginIdLabel = new Label();
            loginPasswordLabel = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // loginIdTextbox
            // 
            loginIdTextbox.Location = new Point(313, 147);
            loginIdTextbox.Name = "loginIdTextbox";
            loginIdTextbox.Size = new Size(184, 23);
            loginIdTextbox.TabIndex = 0;
            loginIdTextbox.TextChanged += loginIdTextbox_TextChanged;
            // 
            // loginPasswordTextbox
            // 
            loginPasswordTextbox.Location = new Point(313, 190);
            loginPasswordTextbox.Name = "loginPasswordTextbox";
            loginPasswordTextbox.Size = new Size(184, 23);
            loginPasswordTextbox.TabIndex = 1;
            loginPasswordTextbox.TextChanged += loginPasswordTextbox_TextChanged;
            // 
            // loginIdLabel
            // 
            loginIdLabel.AutoSize = true;
            loginIdLabel.Location = new Point(282, 150);
            loginIdLabel.Name = "loginIdLabel";
            loginIdLabel.Size = new Size(19, 15);
            loginIdLabel.TabIndex = 2;
            loginIdLabel.Text = "ID";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Location = new Point(282, 193);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(25, 15);
            loginPasswordLabel.TabIndex = 3;
            loginPasswordLabel.Text = "PW";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(365, 232);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "로그인";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // MemberLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(loginPasswordLabel);
            Controls.Add(loginIdLabel);
            Controls.Add(loginPasswordTextbox);
            Controls.Add(loginIdTextbox);
            Name = "MemberLoginForm";
            Text = "MemberLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginIdTextbox;
        private TextBox loginPasswordTextbox;
        private Label loginIdLabel;
        private Label loginPasswordLabel;
        private Button loginButton;
    }
}
