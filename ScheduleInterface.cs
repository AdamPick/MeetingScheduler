using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class ScheduleInterface : Form
    {
        private List<string> timesToSelect = new List<string>(8);
        //times shown have boundary of working week 9-5(can't set a meeting for 5 as people will have finished)
        private List<string> durationToSelect = new List<string>(2);
        //the duration of a meeting could be any time 
        //but to show the prototype working every meeting will be either 1 or 2 hour(s)
        //private DateTime currentDateTimeSelected = DateTime.Today.AddHours
        private List<string> roomsToSelect = new List<string>(4);
        private List<string> participantsToSelect = new List<string>(5);
        private int roomSelected = 1;
        private int hoursSelected = 9;
        private int endHoursSelected = 9;
        private int numPeopleSelected = 0;
        private List<string> participantsSelected = new List<string>(5);
        private DateTime currentDateTimeSelected = DateTime.Today.AddHours(9);
        private DateTime endCurrentDateTimeSelected = DateTime.Today.AddHours(9);
        private int durationSelected = 1;
        private bool addParticipant = false;
        public ScheduleInterface()
        {
            InitializeComponent();
            //data box used for selection
            dateTimePicker1.MaxDate = DateTime.Today.AddMonths(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddMonths(1);
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker1.MinDate = DateTime.Today.AddDays(2);
                dateTimePicker2.MinDate = DateTime.Today.AddDays(3);
            }
            else if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
                dateTimePicker2.MinDate = DateTime.Today.AddDays(2);
            }
            else
            {
                dateTimePicker1.MinDate = DateTime.Today;
                dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
            }
            
            //int day = (int)dateTimePicker1.Value.DayOfWeek;
            //dateTimePicker1.MaxDate = DateTime.Today.AddDays(5-day);
            //makes sure no date before the present is displayed
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MinDate;
            //onscreen value shown is today's date 
            for (int i = 0; i < 8; i++) {
                if (i == 0)         
                    timesToSelect.Add("                09:00");
                else
                    timesToSelect.Add(("                "+(i+9)+":00"));
            }
            for (int j = 1; j < 3; j++)
                durationToSelect.Add("              "+ j +" hour(s)");
            for (int k = 1; k < 5; k++)
                roomsToSelect.Add("              Room " + k);
            timeBox.DataSource = timesToSelect;
            comboBox1.DataSource = timesToSelect;
            //display every time slot per day
            durationBox.DataSource = durationToSelect;
            roomBox.DataSource = roomsToSelect;
            //display every duration slot per day
            //DisplayCurrentDetails();
            //displayMeetingsOfDay(DateTime.Today);
            DisplayParticipantsOfSystem();
        }

        private void timeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoursSelected = int.Parse(timeBox.SelectedItem.ToString().Substring(16, 2));
            currentDateTimeSelected = dateTimePicker1.Value.AddHours(hoursSelected);
            List<string> fourOClock = new List<string> { "              " + (1) + " hour(s)" };
            if (hoursSelected == 16)
                durationBox.DataSource = fourOClock;
            else
                durationBox.DataSource = durationToSelect;
            //DisplayCurrentDetails();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)dateTimePicker1.Value.DayOfWeek == 0 || (int)dateTimePicker1.Value.DayOfWeek == 6)
            {
                timeBox.Enabled = false;
                durationBox.Enabled = false;
                roomBox.Enabled = false;
                SubmitReq.Enabled = false;
            }
            else
            {
                timeBox.Enabled = true;
                durationBox.Enabled = true;
                roomBox.Enabled = true;
                SubmitReq.Enabled = true;
                currentDateTimeSelected = dateTimePicker1.Value.AddHours(hoursSelected);
                //DisplayCurrentDetails();
            }
            //displayMeetingsOfDay(dateTimePicker1.Value);
        }

        private void durationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durationSelected = int.Parse(durationBox.SelectedItem.ToString().Substring(14, 1));
            //DisplayCurrentDetails();
        }

        private void SubmitReq_Click(object sender, EventArgs e)
                {
            /*if (timeBox.Enabled != false && CheckExists(currentDateTimeSelected,"Meetings.txt") == false && CheckExists(currentDateTimeSelected, "MeetingRequests.txt") == false)
            {
                DateTime setDate = currentDateTimeSelected;
                int setDuration = durationSelected;
                //string path = System.AppDomain.CurrentDomain.BaseDirectory;
                //string filePath = path.Substring(0, path.Length - ("\\bin\\Debug").Length)+"MeetingRequests.txt";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("MeetingRequests.txt", true))
                    file.WriteLine(setDate.ToString()+" "+setDuration.ToString()+"hrs Room "+roomSelected+" " + string.Join(", ", participantsSelected));
                    displayMeetingsOfDay(dateTimePicker1.Value);
            }*/
        }

        /*private void displayMeetingsOfDay(DateTime Date)
        {
            List<string> meetingsOfDay = new List<string> { };
            string[] allLines = readIn("Meetings.txt");

            if (allLines.Length != 0)
            {
                foreach (string line in allLines)
                {
                    if (line == "")
                        break;
                    else if (Convert.ToDateTime(line.Substring(0, 19)).ToShortDateString() == Date.ToShortDateString())
                        meetingsOfDay.Add(line);

                }
            }
            ScheduledMeetings.DataSource = meetingsOfDay;
        }*/

        private void DisplayParticipantsOfSystem()
        {
            string[] allLines = readIn("participants.txt");
            foreach (string line in allLines)
            {
                participantsToSelect.Add(line);
            }
            MembersAvailable.DataSource = participantsToSelect;
        }

        /*private void DisplayCurrentDetails()
        {
            List<string> meetingMembers = participantsSelected;
            if (numPeopleSelected < 1)
            {
                meetingMembers = new List<string> { "Not Enough People Selected!\nPlease select at least 2 people to hold a meeting" };
                SubmitReq.Enabled = false;
            }
            SubmitReq.Enabled = true;
            CurrentDet.Text = (currentDateTimeSelected.ToShortDateString() + "\n\n" + currentDateTimeSelected.ToShortTimeString() + " " + durationSelected +" hour(s)"+"\n\nRoom "+ roomSelected +"\n\n"+ string.Join(", ",meetingMembers));
        }*/

        private string[] readIn(String fileName)
        {
            string[] allLines = System.IO.File.ReadAllLines(fileName);
            return allLines;
        }

        /*private bool CheckExists(DateTime Date, string fileName)
        {
            string[] allLines = readIn(fileName);
            if (allLines.Length != 0)
            {
                foreach (string line in allLines)
                {
                    DateTime timeToCheck = Convert.ToDateTime(line.Substring(0, 19));
                    int durationToCheck = int.Parse(line.Substring(20, 1));
                    int roomToCheck = int.Parse(line.Substring(30, 1));
                    if ((timeToCheck.Equals(Date) ||(durationToCheck == 2 && timeToCheck.AddHours(1).Equals(Date))) && roomSelected == roomToCheck)
                        return true;
                }
                return false;
            }
            else
                return false;
        }*/

        private void roomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomSelected = int.Parse(roomBox.SelectedItem.ToString().Substring(19, 1));
            //DisplayCurrentDetails();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addParticipant = true;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            addParticipant = false;
        }

        private void ParticipantsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addParticipant == true)
                if (participantsSelected.Count() > 0)
                {
                    bool found = false;
                    foreach (string person in participantsSelected)
                    {
                        if (MembersAvailable.SelectedItem.ToString() == person)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        participantsSelected.Add(MembersAvailable.SelectedValue.ToString());
                        numPeopleSelected++;
                        //DisplayCurrentDetails();
                    }
                }
                else
                {
                    participantsSelected.Add(MembersAvailable.SelectedValue.ToString());
                    numPeopleSelected++;
                    //DisplayCurrentDetails();
                }
            else
            {
                if (participantsSelected.Count() > 0)
                {
                    participantsSelected.Remove(MembersAvailable.SelectedValue.ToString());
                    numPeopleSelected--;
                    //DisplayCurrentDetails();
                }
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if ((int)dateTimePicker2.Value.DayOfWeek == 0 || (int)dateTimePicker2.Value.DayOfWeek == 6)
            {
                timeBox.Enabled = false;
                durationBox.Enabled = false;
                roomBox.Enabled = false;
                SubmitReq.Enabled = false;
            }
            else
            {
                timeBox.Enabled = true;
                durationBox.Enabled = true;
                roomBox.Enabled = true;
                SubmitReq.Enabled = true;
                endCurrentDateTimeSelected = dateTimePicker2.Value.AddHours(endHoursSelected);
                //DisplayCurrentDetails();
            }
            //displayMeetingsOfDay(dateTimePicker2.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            endHoursSelected = int.Parse(comboBox1.SelectedItem.ToString().Substring(16, 2));
            endCurrentDateTimeSelected = dateTimePicker2.Value.AddHours(endHoursSelected);
            //DisplayCurrentDetails();
        }
    }
}


