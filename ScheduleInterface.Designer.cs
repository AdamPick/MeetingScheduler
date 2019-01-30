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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.scheduleInterfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MembersInvited = new System.Windows.Forms.ListBox();
            this.MembersAvailable = new System.Windows.Forms.ListBox();
            this.SubmitReq = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleInterfaceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.roomBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.durationBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Meeting";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.scheduleInterfaceBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // scheduleInterfaceBindingSource
            // 
            this.scheduleInterfaceBindingSource.DataSource = typeof(MeetingScheduler.ScheduleInterface);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "and";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "and";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Location = new System.Drawing.Point(261, 19);
            this.dateTimePicker2.MaxDate = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.Value = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // roomBox
            // 
            this.roomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Items.AddRange(new object[] {
            "              1 Hour(s)",
            "              2 Hour(s)"});
            this.roomBox.Location = new System.Drawing.Point(230, 81);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(91, 21);
            this.roomBox.TabIndex = 19;
            this.roomBox.SelectedIndexChanged += new System.EventHandler(this.roomBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room";
            // 
            // durationBox
            // 
            this.durationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationBox.FormattingEnabled = true;
            this.durationBox.Items.AddRange(new object[] {
            "              1 Hour(s)",
            "              2 Hour(s)"});
            this.durationBox.Location = new System.Drawing.Point(63, 81);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(90, 21);
            this.durationBox.TabIndex = 17;
            this.durationBox.SelectedIndexChanged += new System.EventHandler(this.durationBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Duration";
            // 
            // timeBox
            // 
            this.timeBox.DataSource = this.scheduleInterfaceBindingSource;
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(109, 49);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(115, 21);
            this.timeBox.TabIndex = 15;
            this.timeBox.SelectedIndexChanged += new System.EventHandler(this.timeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Time Between";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date Between";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 19);
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
            this.groupBox2.Controls.Add(this.MembersInvited);
            this.groupBox2.Controls.Add(this.MembersAvailable);
            this.groupBox2.Location = new System.Drawing.Point(16, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invite Participants";
            // 
            // MembersInvited
            // 
            this.MembersInvited.FormattingEnabled = true;
            this.MembersInvited.Location = new System.Drawing.Point(198, 49);
            this.MembersInvited.Name = "MembersInvited";
            this.MembersInvited.Size = new System.Drawing.Size(168, 134);
            this.MembersInvited.TabIndex = 12;
            // 
            // MembersAvailable
            // 
            this.MembersAvailable.FormattingEnabled = true;
            this.MembersAvailable.Location = new System.Drawing.Point(8, 49);
            this.MembersAvailable.Name = "MembersAvailable";
            this.MembersAvailable.Size = new System.Drawing.Size(168, 134);
            this.MembersAvailable.TabIndex = 11;
            this.MembersAvailable.SelectedIndexChanged += new System.EventHandler(this.ParticipantsAvailable_SelectedIndexChanged);
            // 
            // SubmitReq
            // 
            this.SubmitReq.Location = new System.Drawing.Point(414, 197);
            this.SubmitReq.Name = "SubmitReq";
            this.SubmitReq.Size = new System.Drawing.Size(105, 62);
            this.SubmitReq.TabIndex = 0;
            this.SubmitReq.Text = "Submit Meeting Request";
            this.SubmitReq.UseVisualStyleBackColor = true;
            this.SubmitReq.Click += new System.EventHandler(this.SubmitReq_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(414, 269);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 62);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Cancel And Return To Option Page";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(402, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(106, 94);
            this.checkedListBox1.TabIndex = 24;
            // 
            // ScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 343);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.SubmitReq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleInterface";
            this.Text = "Meeting Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleInterfaceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.ComboBox durationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource scheduleInterfaceBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.ListBox MembersAvailable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox MembersInvited;
        private System.Windows.Forms.Button SubmitReq;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

