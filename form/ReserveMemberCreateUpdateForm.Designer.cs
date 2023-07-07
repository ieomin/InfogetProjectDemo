namespace ProjectDemo
{
    partial class ReserveMemberCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button reverseMemberCreateUpdateButton;

        private void InitializeComponent()
        {
            reverseMemberCreateUpdateButton = new Button();
            SuspendLayout();
            // 
            // reverseMemberCreateUpdateButton
            // 
            reverseMemberCreateUpdateButton.Location = new Point(22, 513);
            reverseMemberCreateUpdateButton.Name = "reverseMemberCreateUpdateButton";
            reverseMemberCreateUpdateButton.Size = new Size(85, 23);
            reverseMemberCreateUpdateButton.TabIndex = 16;
            reverseMemberCreateUpdateButton.UseVisualStyleBackColor = true;
            reverseMemberCreateUpdateButton.Click += reverseMemberCreateUpdateButton_Click;
            // 
            // ReserveMemberCreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(reverseMemberCreateUpdateButton);
            Name = "ReserveMemberCreateUpdateForm";
            Text = "ReserveMemberCreateUpdateForm";
            ResumeLayout(false);
        }
    }
}