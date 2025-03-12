using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        public double current_seconds = 0.00;
        public double current_minutes = 0.00;
        public double current_hours = 0.00;


        public void SecondsIncr()
        {
            current_seconds += 1;
            //current_minutes += 0.01;
            Full_Seconds_Label.Text = current_seconds.ToString(); //test viewing
            Full_Minutes_Label.Text = current_minutes.ToString(); //test viewing
            Full_Hours_Label.Text = current_hours.ToString(); //test viewing

        }
        public void MinutesIncr()
        {
            current_seconds = 0;
            current_minutes += 1.00; // необязательно если задано в SecondsIncr(): current_minutes += 0.01;
        }
        public void HoursIncr()
        {
            //current_minutes = 0; // необязательно если используется MinutesReset()
            current_hours += 1.00;
        }
        public void MinutesReset()
        {
            current_minutes = 0;
        }        
        public void HoursReset()
        {
            current_hours = 0;
        }

        public void Timemeter_ClearVolumes()
        {
            current_seconds = 0;
            current_minutes = 0.00;
            current_hours = 0.00;
            Show_current_seconds = "0" + current_seconds.ToString();
            Show_current_minutes = "0" + current_minutes.ToString();
            Show_current_hours = "0" + current_hours.ToString();
            Seconds_Label.Text = Show_current_seconds;
            Minutes_Label.Text = Show_current_minutes;
            Hours_Label.Text = Show_current_hours;
            //clear time labels:
            Full_Seconds_Label.Text = "00";
            Full_Minutes_Label.Text = "00";
            Full_Seconds_Label.Text = "00";
            Full_Day_Over_Label.Text = "0";
        }



        public void Timemeter_Core()
        {
            //object current_seconds = Environment.TickCount;
            SecondsIncr();

            //MessageBox.Show(current_seconds.ToString()); //test
            if (current_seconds == 59.00)
            {
                MinutesIncr();
                current_seconds = 0.00;
            } else

            if (current_minutes > 59.00)
            {
                HoursIncr();
                MinutesReset();
            } else

            if (current_hours > 23)
            {
                Full_Day_Over_Label.Text = "One Day Over";
                MinutesReset();
                HoursReset(); //set current_hours = 0.00;
            }


            if (current_seconds >= 0)
            {
                Show_current_seconds = "0" + current_seconds.ToString();
                Seconds_Label.Text = Show_current_seconds;

                if (current_seconds >= 10)
                {
                    Show_current_seconds = current_seconds.ToString();
                    Seconds_Label.Text = Show_current_seconds;
                }
            }
            if (current_minutes >= 0)
            {
                Show_current_minutes = "0" + current_minutes.ToString();
                Minutes_Label.Text = Show_current_minutes;

                if (current_minutes >= 10)
                {
                    Show_current_minutes = current_minutes.ToString();
                    Minutes_Label.Text = Show_current_minutes;
                    if (current_minutes > 59.00)
                    {
                        HoursIncr();
                        MinutesReset();
                        Show_current_minutes = "0" + current_minutes.ToString();
                        Minutes_Label.Text = Show_current_minutes;
                    }
                }
            }
            if (current_hours >= 0)
            {
                Show_current_hours = "0" + current_hours.ToString();
                Hours_Label.Text = Show_current_hours;

                if (current_hours >= 10)
                {
                    Show_current_hours = current_hours.ToString();
                    Hours_Label.Text = Show_current_hours;
                    if (current_hours >= 23 && current_minutes >= 59 && current_seconds >= 59)
                    {
                        HoursReset();
                        Show_current_hours = "0" + current_hours.ToString();
                    }
                }
            }
            else
            {
                Show_current_seconds = current_seconds.ToString();
                Minutes_Label.Text = Show_current_minutes;
                Hours_Label.Text = Show_current_hours;

                Show_current_seconds = current_seconds.ToString();
                Show_current_minutes = current_minutes.ToString();
                Show_current_hours = current_hours.ToString();
            }

        }


        public void Timemeter_Cover()
        {
            

        }



        private void StartButton_Click(object sender, EventArgs e)
        {

            //current_seconds = 55.00; //temp for test runing
            //current_minutes = 59.00; //temp for test runing
            //current_hours = 23.00; //temp for test runing

            TimemeterON = true;
            timer1.Enabled = true;
            Timemeter_Core();

            //Timemeter_Cover();
            StopButton.Visible = true;
            StartButton.Visible = false;
            Pause_Button.Visible = true;

        }

        public void StopButton_Click(object sender, EventArgs e)
        {
            TimemeterON = false;
            timer1.Enabled = false;
            Timemeter_ClearVolumes(); //full stop timer
            StopButton.Visible = false;
            StartButton.Visible = true;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Timemeter_Core();
            //MessageBox.Show(Show_current_seconds);

        }

        private void Minimise_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void CL_Timemeter_Form_MouseDown(object sender, MouseEventArgs e)
        {
            //this.OnMove(e); // moving window
            this.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void CL_Timemeter_Form_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = default;

        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            Pause_Button.Visible = false;
            StartButton.Visible = true;
            timer1.Enabled = false;
        }

        public void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void ShowCheckGroup_Button_Click(object sender, EventArgs e)
        {
            if (TimemeterCheckGroupBox.Visible == false)
            {
                TimemeterCheckGroupBox.Visible = true;
            }
            else {
                TimemeterCheckGroupBox.Visible = false;
            }

        }

        private void ShowTime_Button_Click(object sender, EventArgs e)
        {
            if (Timemeter_Label.Visible == false)
            {
                Timemeter_Label.Visible = true;
                //show time
            } else { 
            Timemeter_Label.Visible = false;
            //hide time
            }
        }
    }
}
