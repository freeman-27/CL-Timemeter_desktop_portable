using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Timemeter
{
    public partial class CL_Timemeter_Form : Form
    {
        public CL_Timemeter_Form()
        {
            InitializeComponent();
        }

        private void CloseButton_Custom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //System.Drawing.Color

        object BGState = CL_Timemeter_Form.DefaultBackColor;       

        //void BGState = System.Drawing.Color.FromArgb(((int)(((byte)(01)
        public string Show_current_seconds;
        public string Show_current_minutes;
        public string Show_current_hours;
        bool TimemeterON;
        public bool TimemeterOFF = true;
        //core variables
        int current_seconds = 0;
        double current_minutes = 0.00;
        double current_hours = 0.00;


        public void Timemeter_Cover()
        {
            current_seconds = 1;

        }

        public void Timemeter_Core()
        {
            //object current_seconds = Environment.TickCount;

            SecondsIncr();
            //MessageBox.Show(current_seconds.ToString()); //test
            if (current_seconds > 59)
            {
                MinutesIncr();
            } else if (current_minutes == 59.59)
            {
                HoursIncr();
            } else
            {
                Show_current_seconds = current_seconds.ToString();
                Show_current_minutes = current_minutes.ToString();
                Show_current_hours = current_hours.ToString();

                current_seconds += 1;
                current_minutes = 0.01;
                current_hours += 0.01;
             }

        }

        public void SecondsIncr()
        {
            current_seconds += 1;
        }        
        public void MinutesIncr()
        {
            current_seconds = 0;
            current_minutes += 1;
        }
        public void HoursIncr()
        {
            current_minutes = 0;
            current_hours += 1;
        }

        public void Timemeter_ClearVolumes()
        {
            current_seconds = 0;
            current_minutes = 0.00;
            current_hours = 0.00;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TimemeterFunctions IncludeCoreTimemeter = new TimemeterFunctions();
            IncludeCoreTimemeter.Timemeter_Core_Global(); //test

            object current_seconds = "00:00:01";
            Timemeter_Label.Text = "test timmeter";
            //CLSCompliantAttribute - учитывать CLS

            //test values
            //Timemeter_Core();

            TimemeterON = true;
            timer1.Enabled = true;
            //Timemeter_Cover();

            //Hours_Label.Text = Show_current_hours;
            //Minutes_Label.Text = Show_current_minutes;
            //Seconds_Label.Text = Show_current_seconds;

        }

        public void StopButton_Click(object sender, EventArgs e)
        {
            TimemeterON = false;
            Timemeter_ClearVolumes(); //full stop timer
            timer1.Enabled = false;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            do
            {
                Timemeter_Core();
            }
            while (TimemeterON == true);
        }
    }
}
