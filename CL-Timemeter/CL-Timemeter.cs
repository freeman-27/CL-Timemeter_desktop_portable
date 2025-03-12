using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
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



        /// <summary>
        /// Timmeter Template Variables
        /// </summary>
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

        /// <summary>
        /// Colors Settings Values
        /// </summary>
        //System.Drawing.Color
        object BGState = CL_Timemeter_Form.DefaultBackColor;
        //255 номеров RGB:
        int[] Arr_ColorNumbers = new int[255];

        //генерация случайных чисел до 255
        static Random RandNumb = new Random();
        public int Set_RGB_Chanel_R; //= RandNumb.Next(150, 201); in function TimemeterCover()   // set R chanel from 150 to 200
        public int Set_RGB_Chanel_G; //= RandNumb.Next(150, 201);   // set G chanel from 0 to 255
        public int Set_RGB_Chanel_B; //= RandNumb.Next(150, 201);   // set B chanel from 150 to 200

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


        /// <summary>
        /// Main Timemeter element function
        /// </summary>
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

        /// <summary>
        /// System Timer Method (interval 1000)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void main_system_timer_Tick(object sender, EventArgs e)
        {
            Timemeter_Core();
            //MessageBox.Show(Show_current_seconds);

        }

        /// <summary>
        /// System Timer Method 2 for function"Cover" (interval 9000)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_for_cover_Tick(object sender, EventArgs e)
        {
            //Set_RGB_Chanel_R = RandNumb.Next(50, 100);   // set R chanel from 150 to 200
            //Set_RGB_Chanel_G = RandNumb.Next(50, 100);   // set G chanel from 0 to 255
            //Set_RGB_Chanel_B = RandNumb.Next(50, 100);

            Timemeter_Cover();
        }

        /// <summary>
        /// Timemeter Customisation Function
        /// </summary>
        public void Timemeter_Cover()
        {
            Random Rand1 = new Random();
            Rand1.Next();

            //object BG_Value = this.BackColor;
            //BG_Value = BG_Value.ToString();
            //BG_Value = new Random();

            TimeValuesLabels_GroupBox.ForeColor = System.Drawing.Color.White;

            Set_RGB_Chanel_R = RandNumb.Next(50, 100);   // set R chanel from 150 to 200
            Set_RGB_Chanel_G = RandNumb.Next(50, 100);   // set G chanel from 0 to 255
            Set_RGB_Chanel_B = RandNumb.Next(50, 100);   // set B chanel from 150 to 200

            //Array Arr_ColorValuesRGB = new int Arr_ColorValuesRGB[];

            //string Arr_ColorValuesRGB[] = { BG_Value, BG_Value };

            //MessageBox.Show(BG_Value.ToString());
            this.BackColor = System.Drawing.Color.FromArgb(255, Set_RGB_Chanel_R, Set_RGB_Chanel_G, Set_RGB_Chanel_B);
        }



        private void StartButton_Click(object sender, EventArgs e)
        {

            //current_seconds = 55.00; //temp for test runing
            //current_minutes = 59.00; //temp for test runing
            //current_hours = 23.00; //temp for test runing

            TimemeterON = true;
            main_system_timer.Enabled = true;
            Timemeter_Core();

            StopButton.Visible = true;
            StartButton.Visible = false;
            Pause_Button.Visible = true;

            //customuse form
            timer_for_cover.Enabled = true;
            Timemeter_Cover(); // TO DO once used - only for first start.
            this.Opacity = 1;

        }

        public void StopButton_Click(object sender, EventArgs e)
        {
            //disable core:
            TimemeterON = false;
            main_system_timer.Enabled = false;
            Timemeter_ClearVolumes(); //full stop timer
            StopButton.Visible = false;
            StartButton.Visible = true;
            Pause_Button.Visible = false;
            //disable cover:
            //Timemeter_Cover(); //test
            this.BackColor = default;
            TimeValuesLabels_GroupBox.ForeColor = default;
            this.Opacity = 1;
            timer_for_cover.Enabled = false;
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            Pause_Button.Visible = false;
            StartButton.Visible = true;
            main_system_timer.Enabled = false;
            this.BackColor = System.Drawing.Color.DarkGray;
            TimeValuesLabels_GroupBox.ForeColor = default;
            //this.Opacity = 0.5;
            timer_for_cover.Stop();
            timer_for_cover.Enabled = false;

        }

        private void Minimise_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void CL_Timemeter_Form_MouseDown(object sender, MouseEventArgs e)
        {
            //this.OnMove(e); // moving window
            //this.BackColor = System.Drawing.Color.BurlyWood;
            this.Cursor = Cursors.SizeAll;

        }

        private void CL_Timemeter_Form_MouseUp(object sender, MouseEventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Cursor = Cursors.Default;
            this.Opacity = 1;

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

        private void CL_Timemeter_Form_Load(object sender, EventArgs e)
        {
            this.AcceptButton = StartButton;
        }

        private void CL_Timemeter_Form_MouseEnter(object sender, EventArgs e)
        {
            //TimeValuesLabels_GroupBox.BackColor = Color.Transparent;
        }

        private void TimeValuesLabels_GroupBox_Enter(object sender, EventArgs e)
        {
            //TimeValuesLabels_GroupBox.BackColor = Color.Red;
            this.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Fixate Windows and Disable Border Functions
        /// </summary>
        public void On_Border()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public void Off_Border()
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void Fixated_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Fixated_CheckBox.Checked) {
                Off_Border();
                CloseButton_Custom.Visible = true;
                Minimise_Button.Visible = true;
            } else {
                On_Border();
                CloseButton_Custom.Visible = false;
                Minimise_Button.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>


    }
}
