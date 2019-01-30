namespace MeetingScheduler
{
    partial class ScheduleInterface
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
            this.components = new System.ComponentModel.Container();
            this.SubmitReq = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.scheduleInterfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParticipantsAvailable = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScheduledMeetings = new System.Windows.Forms.ListBox();
            this.CurrentDet = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleInterfaceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitReq
            // 
            this.SubmitReq.Location = new System.Drawing.Point(-1, 137);
            this.SubmitReq.Name = "SubmitReq";
            this.SubmitReq.Size = new System.Drawing.Size(117, 46);
            this.SubmitReq.TabIndex = 0;
            this.SubmitReq.Text = "Submit Meeting Request";
            this.SubmitReq.UseVisualStyleBackColor = true;
            this.SubmitReq.Click += new System.EventHandler(this.SubmitReq_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(117, 19);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(21, 19);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "-";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.durationBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(236, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Meeting ";
            // 
            // roomBox
            // 
            this.roomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Items.AddRange(new object[] {
            "              1 Hour(s)",
            "              2 Hour(s)"});
            this.roomBox.Location = new System.Drawing.Point(51, 158);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(132, 21);
            this.roomBox.TabIndex = 19;
            this.roomBox.SelectedIndexChanged += new System.EventHandler(this.roomBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Set Room";
            // 
            // durationBox
            // 
            this.durationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationBox.FormattingEnabled = true;
            this.durationBox.Items.AddRange(new object[] {
            "              1 Hour(s)",
            "              2 Hour(s)"});
            this.durationBox.Location = new System.Drawing.Point(51, 118);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(132, 21);
            this.durationBox.TabIndex = 17;
            this.durationBox.SelectedIndexChanged += new System.EventHandler(this.durationBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Set Duration";
            // 
            // timeBox
            // 
            this.timeBox.DataSource = this.scheduleInterfaceBindingSource;
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(51, 78);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(132, 21);
            this.timeBox.TabIndex = 15;
            this.timeBox.SelectedIndexChanged += new System.EventHandler(this.timeBox_SelectedIndexChanged);
            // 
            // scheduleInterfaceBindingSource
            // 
            this.scheduleInterfaceBindingSource.DataSource = typeof(MeetingScheduler.ScheduleInterface);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Set Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Set Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 39);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParticipantsAvailable);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.removeBtn);
            this.groupBox2.Location = new System.Drawing.Point(4, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invite Participants";
            // 
            // ParticipantsAvailable
            // 
            this.ParticipantsAvailable.FormattingEnabled = true;
            this.ParticipantsAvailable.Location = new System.Drawing.Point(8, 49);
            this.ParticipantsAvailable.Name = "ParticipantsAvailable";
            this.ParticipantsAvailable.Size = new System.Drawing.Size(207, 134);
            this.ParticipantsAvailable.TabIndex = 11;
            this.ParticipantsAvailable.SelectedIndexChanged += new System.EventHandler(this.ParticipantsAvailable_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(90, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(21, 19);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScheduledMeetings);
            this.groupBox3.Location = new System.Drawing.Point(4, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 192);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meetings Scheduled Today";
            // 
            // ScheduledMeetings
            // 
            this.ScheduledMeetings.FormattingEnabled = true;
            this.ScheduledMeetings.Location = new System.Drawing.Point(9, 19);
            this.ScheduledMeetings.Name = "ScheduledMeetings";
            this.ScheduledMeetings.Size = new System.Drawing.Size(207, 160);
            this.ScheduledMeetings.TabIndex = 10;
            // 
            // CurrentDet
            // 
            this.CurrentDet.AutoSize = true;
            this.CurrentDet.Location = new System.Drawing.Point(6, 22);
            this.CurrentDet.Name = "CurrentDet";
            this.CurrentDet.Size = new System.Drawing.Size(110, 13);
            this.CurrentDet.TabIndex = 0;
            this.CurrentDet.Text = "Details displayed here";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.backBtn);
            this.groupBox4.Controls.Add(this.SubmitReq);
            this.groupBox4.Controls.Add(this.CurrentDet);
            this.groupBox4.Location = new System.Drawing.Point(236, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 196);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Meeting details";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(122, 137);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 46);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Cancel And Return To Option Page";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // ScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 406);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleInterface";
            this.Text = "Meeting Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleInterfaceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitReq;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.ComboBox durationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource scheduleInterfaceBindingSource;
        private System.Windows.Forms.Label CurrentDet;
        private System.Windows.Forms.ListBox ScheduledMeetings;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.ListBox ParticipantsAvailable;
        private System.Windows.Forms.Button backBtn;
    }
}

