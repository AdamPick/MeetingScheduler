namespace MeetingScheduler
{
    partial class ViewMeetings
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScheduledMeetings = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequestsToReview = new System.Windows.Forms.ListBox();
            this.DropBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Attendees = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Label();
            this.Equipment = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScheduledMeetings);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 192);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meetings Scheduled";
            // 
            // ScheduledMeetings
            // 
            this.ScheduledMeetings.FormattingEnabled = true;
            this.ScheduledMeetings.Location = new System.Drawing.Point(9, 19);
            this.ScheduledMeetings.Name = "ScheduledMeetings";
            this.ScheduledMeetings.Size = new System.Drawing.Size(207, 160);
            this.ScheduledMeetings.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RequestsToReview);
            this.groupBox1.Location = new System.Drawing.Point(449, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 192);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meeting Requests";
            // 
            // RequestsToReview
            // 
            this.RequestsToReview.FormattingEnabled = true;
            this.RequestsToReview.Location = new System.Drawing.Point(9, 19);
            this.RequestsToReview.Name = "RequestsToReview";
            this.RequestsToReview.Size = new System.Drawing.Size(207, 160);
            this.RequestsToReview.TabIndex = 10;
            // 
            // DropBtn
            // 
            this.DropBtn.Location = new System.Drawing.Point(21, 211);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Size = new System.Drawing.Size(207, 38);
            this.DropBtn.TabIndex = 12;
            this.DropBtn.Text = "Drop Out";
            this.DropBtn.UseVisualStyleBackColor = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(458, 211);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(94, 38);
            this.AcceptBtn.TabIndex = 13;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Meeting Information";
            // 
            // Attendees
            // 
            this.Attendees.AutoSize = true;
            this.Attendees.Location = new System.Drawing.Point(244, 57);
            this.Attendees.Name = "Attendees";
            this.Attendees.Size = new System.Drawing.Size(58, 13);
            this.Attendees.TabIndex = 16;
            this.Attendees.Text = "Attendees:";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(244, 83);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(50, 13);
            this.Duration.TabIndex = 17;
            this.Duration.Text = "Duration:";
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(244, 112);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(38, 13);
            this.Room.TabIndex = 18;
            this.Room.Text = "Room:";
            // 
            // Equipment
            // 
            this.Equipment.AutoSize = true;
            this.Equipment.Location = new System.Drawing.Point(244, 140);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(60, 13);
            this.Equipment.TabIndex = 19;
            this.Equipment.Text = "Equipment:";
            // 
            // ViewMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 257);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Attendees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.DropBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ViewMeetings";
            this.Text = "ViewMeetings";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ScheduledMeetings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox RequestsToReview;
        private System.Windows.Forms.Button DropBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Attendees;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label Equipment;
    }
}