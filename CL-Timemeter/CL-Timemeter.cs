using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//custom include
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Win32;
using CL_Timemeter.Properties;
using System.Drawing.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;//test


namespace CL_Timemeter
{


    
    public partial class CL_Timemeter_Form : Form
    {
        
        public CL_Timemeter_Form()
        {
            InitializeComponent();
        }
        //public Image ImageIcon_CL_Timemeter = Bitmap.FromFile(filename: @"CL-Timemeter-icon64.png");
        //public Icon Icon_CL_Timemeter;
        //public System.Drawing.IconConverter Conv;
        /// ==========================================================================================
        /// <summary>
        /// /Дополнительные Свойства класса CL_Timemeter_Form ->>> to other projects of control elements ===================================
        /// </summary>
        [Category("Appearance")]
        [Description("Фон окна до запуска таймера")] //test
        [DisplayName("DefMode_Background")] //test
        [Browsable(true)]
        public Color BGColor_Default_Mode { get; set; } = Color.Coral;
        /// ==========================================================================================

        //TODO Cursor

        private void CL_Timemeter_Form_Load(object sender, EventArgs e)
        {
            //this.AcceptButton = StartButton;
            Hide_All_ControlElement_Labels();
        }

        private void Hide_All_ControlElement_Labels()
        {

            StartButton.Text = "";
            Pause_Button.Text = "";
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
        /// <summary>
        /// для смены цвета фона
        /// </summary>
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

            Minute_Progress_Label.Text = "";
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
            //for progress label minutes
            if ((int)current_seconds >= 1)
            {
                //Minute_Progress_Label.Text = "";
                Minute_Progress_Label.Text += ".";
            }
            else if ((int)current_seconds == 0)
            {
                Minute_Progress_Label.Text = "";
            }
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
            //object BG_Value = this.BackColor;
            //BG_Value = BG_Value.ToString();
            //BG_Value = new Random();

            //TimeMeterFunctions_GroupBox.ForeColor = System.Drawing.Color.White; // disabled
            Seconds_Label.ForeColor = System.Drawing.Color.White;
            Minutes_Label.ForeColor = System.Drawing.Color.White;
            Hours_Label.ForeColor = System.Drawing.Color.White;
            Split_Label_1.ForeColor = System.Drawing.Color.White;
            Split_Label_2.ForeColor = System.Drawing.Color.White;


            Set_RGB_Chanel_R = RandNumb.Next(50, 100);   // set R chanel from 150 to 200
            Set_RGB_Chanel_G = RandNumb.Next(50, 100);   // set G chanel from 0 to 255
            Set_RGB_Chanel_B = RandNumb.Next(50, 100);   // set B chanel from 150 to 200

            //Array Arr_ColorValuesRGB = new int Arr_ColorValuesRGB[];

            //string Arr_ColorValuesRGB[] = { BG_Value, BG_Value };

            //MessageBox.Show(BG_Value.ToString());
            this.BackColor = System.Drawing.Color.FromArgb(255, Set_RGB_Chanel_R, Set_RGB_Chanel_G, Set_RGB_Chanel_B);
           
        }


        //public static string NewPLayButtonImage_FileName = "Start_Button_Image.png";
        //public string NewPLayButtonImage = Path.GetFileName(NewPLayButtonImage_FileName);
        ////public object SetImg = System.Drawing.Image.FromStream(stream: );
        //public string SetImgPlayBtn = Application.StartupPath + NewPLayButtonImage_FileName;
        ////Path P1 = new Path() { };
        ////public Path PlayImg1 = new Path();


        /// <summary>
        /// IMAGE CONTROLS Folders Names 
        /// </summary>

        ///отностительные пути для тестовых экземпляров программы(только для отладки)
        //folder with images for control elements:
        //relative path:
        //*** chenge folders path for create different builds: debug, release, distrib folder, installation folder
        //public static string ImageControlsFolder_RelativePath = @"Debug\imgControls\"; //Debug folder/////////////////////////////////////////
        //public static string ImageControlsFolder_RelativePath = @"Release\imgControls\"; //Release folder/////////////////////////////////////////
        //public static string ImageControlsFolder_RelativePath = @"Distrib\imgControls\"; //Distrib folder/////////////////////////////////////////

        ///отностительный путь для установленного экземпляра программы(!!!!!используется в финальной сборке)
        public static string ImageControlsFolder_RelativePath = "CL-Timemeter\\imgControls\\"; //Installation folder ////////////////////////////// destination folder for installer) //////////////////////////////////////////////////////


        //public string CustomUserPath = Path.GetDirectoryName(UserFolderNameInput); //TODO


        //Составление полного пути к папке с изображениями элементов управления:
        public static string ImageContolElement_AutoCombinePathFolder = Path.Combine(Path.GetDirectoryName(Application.StartupPath), ImageControlsFolder_RelativePath); //installation folder

        /// <summary>
        /// IMAGE CONTROLS File Names 
        /// </summary>
        public static string ImageStartButtonHover_FileName = Path.GetFileName("Start_Button_Image.png");
        public static string ImageStartButton_FileName = Path.GetFileName("Start_Button_Transparent_Image.png");

        public static string ImagePauseActivated_FileName = Path.GetFileName("PauseActivated_Button_Image.png");
        public static string ImagePauseHover_FileName = Path.GetFileName("Pause_Button_Image.png");
        public static string ImagePause_FileName = Path.GetFileName("Pause_Button_Transparent_Image.png");

        public static string ImageStopButton_FileName = Path.GetFileName("Stop_Button_Rectangle_Transparent_Image.png");
        public static string ImageStopButtonHover_FileName = Path.GetFileName("Stop_Button_Rectangle_Image.png");

        public static string ImageInfoButtonHover_FileName = Path.GetFileName("info_Button_Image.png");
        public static string ImageInfoButton_FileName = Path.GetFileName("info_Button_Transparent_Image.png");
        public static string DefaultBackgroundImage_FileName = Path.GetFileName("green_land_light.png");




        /// <summary>
        /// Execution Status Compare:  4=Continue; 3=Active;  2=Pause; 1=Stop;
        /// </summary>
        public int ExecutionStatus;
        public void ExecutionStatus_Changed()
        {
            if (ExecutionStatus == 3 || ExecutionStatus == 4) {
                //call base app functions
                Timemeter_Core();
                Timemeter_Cover();
                //main_system_timer.Start();
                main_system_timer.Enabled = true;
                //timer_for_cover.Start();
                timer_for_cover.Enabled = true;
                //ExecutionStatus = 4;                
            } else if (ExecutionStatus == 2){
                //main_system_timer.Stop();

            } else {
              
            }
        }

        /// <summary>
        /// START TIMMETER FUNCTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void Activate_TimemeterElement_Click(object sender, EventArgs e)
        {

            //current_seconds = 55.00; //temp for test runing
            //current_minutes = 59.00; //temp for test runing
            //current_hours = 23.00; //temp for test runing

            TimemeterON = true;
            main_system_timer.Enabled = true;


            Timemeter_Core();

            //StopButton.Visible = true; //// Button Element - disabled
            //Pause_Button.Visible = true; //// Button Element - disabled
            //StartButton.Visible = false; //// Control Element - disable

            StartButton_PictureBox.Visible = false;
            PauseButton_PictureBox.Visible = true;
            StopButton_PictureBox.Visible = true; 

            //StartButton.BackgroundImage = Bitmap.FromFile(filename: SetImgPlayBtn, useEmbeddedColorManagement: true);
            //StartButton.BackgroundImage = NewPLayButtonImage;
            //StartButton.BackgroundImage = new System.Drawing.Image();

            //show label "Running"

            //customuse form
            timer_for_cover.Enabled = true;
            Timemeter_Cover(); // TO DO once used - only for first start.
            this.Opacity = 1;



            //Activate Style PauseBtn:
            //MessageBox.Show(ImagePauseActivated_FileName);
            PauseButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImagePauseActivated_FileName));

        }


        /// <summary>
        /// PAUSE FUNCTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Pause_Button_Click(object sender, EventArgs e)
        {
            //Pause_Button.Visible = false;
            //StartButton.Visible = true;
            main_system_timer.Enabled = false; 
            main_system_timer.Stop();
            this.BackColor = System.Drawing.Color.DarkGray;
            TimeMeterFunctions_GroupBox.ForeColor = default;
            //this.Opacity = 0.5;
            timer_for_cover.Stop();
            timer_for_cover.Enabled = false;
            PauseButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImagePauseActivated_FileName));
            if (ExecutionStatus != 2){
                ExecutionStatus = 2;
                main_system_timer.Enabled = false;
                //timer_for_cover.Stop();
                timer_for_cover.Enabled = false;
                ExecutionStatus_Changed();
            }
            else {
                ExecutionStatus = 4;
                ExecutionStatus_Changed(); 
            }
            //show label "Paused"
        }


        
        public void PauseButton_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PauseButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImagePauseHover_FileName));
            Cursor = Cursors.Hand;
        }
        
        public void PauseButton_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PauseButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImagePause_FileName));
            Cursor = Cursors.Default;
        }


        /// <summary>
        /// STOP TIMEMETER FUNCTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StopButton_Click(object sender, EventArgs e)
        {
            //disable core:
            TimemeterON = false;
            main_system_timer.Enabled = false;
            Timemeter_ClearVolumes(); //full stop timer
            //StopButton.Visible = false; // Button Element - disabled
            //StartButton.Visible = true; // Button Element - disabled
            StartButton_PictureBox.Visible = true;
            Pause_Button.Visible = false;
            StopButton.Visible = false;
            PauseButton_PictureBox.Visible = false;
            StopButton_PictureBox.Visible = false;

            //disable cover:
            //Timemeter_Cover(); //test
            this.BackColor = default;
            TimeMeterFunctions_GroupBox.ForeColor = default;
            Seconds_Label.ForeColor = default;
            Minutes_Label.ForeColor = default;
            Hours_Label.ForeColor = default;
            Split_Label_1.ForeColor = default;
            Split_Label_2.ForeColor = default;
            this.Opacity = 1;
            timer_for_cover.Enabled = false;
            TimeMeterFunctions_GroupBox.ForeColor = default;
            //show Label "Stoped"
            Minute_Progress_Label.Text = "";
        }




        private void Minimise_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void CL_Timemeter_Form_MouseDown(object sender, MouseEventArgs e)
        {
            //this.OnMove(e); // moving window
            //this.BackColor = System.Drawing.Color.BurlyWood;

            //this.Cursor = Cursors.SizeAll;  //// test
            
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
                MessageBox.Show("Details group enabled", caption: "Details group", buttons: MessageBoxButtons.OK, icon: iM1, defaultButton: MessageBoxDefaultButton.Button1, options: 0, displayHelpButton: false);

            }
            else {
                TimemeterCheckGroupBox.Visible = false;
            }

        }

        private void ShowTime_Button_Click(object sender, EventArgs e)
        {
            if (Small_Timemeter_Label.Visible == false)
            {
                //show time and date:
                Small_Timemeter_Label.Visible = true;
                RealDate_Label.Visible = true;
                RealTime_OutputToLabel(sender, e);
            } else {
                //hide time and date:
                Small_Timemeter_Label.Visible = false;
                RealDate_Label.Visible = false;


            }
        }

        private void CL_Timemeter_Form_MouseEnter(object sender, EventArgs e)
        {
            //TimeValuesLabels_GroupBox.BackColor = Color.Transparent;
            //this.Cursor = Cursors.PanNW;
            this.Cursor = Cursors.Default;
        }

        private void TimeValuesLabels_GroupBox_Enter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Fixate Windows and Disable Border Functions
        /// </summary>
        public void On_Border()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Align_Button.Visible = true;

        }
        public void Off_Border()
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void Fixated_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Fixated_CheckBox.Checked) {
                Off_Border();
                CloseButton_Custom.Visible = true;
                //Minimise_Button.Visible = true;
                Align_Button.Visible = true;
                Align_Button.SetBounds(221, -1, 40, 40);
                Info_Button_PictureBox.SetBounds(185, 0, 35, 35);
            }
            else {
                On_Border();
                CloseButton_Custom.Visible = false;
                Minimise_Button.Visible = false;
                Align_Button.Visible = true;
                Align_Button.SetBounds(260, 35, 40, -1);
                Info_Button_PictureBox.SetBounds(260, 0, 35, 35);


            }
        }

        private void StartBtn_PictureBox_Click(object sender, EventArgs e)
        {

        }
        

        public void StartButton_PictureBox_MouseEnter(object sender, EventArgs e)
        {

            //MessageBox.Show(ImageContolElement_AutoCombinePathFolder.ToString());

            //MessageBox.Show(Path.Combine(ImageStartHover_FilePath, ImageStartHover_FileName));
            //MessageBox.Show(Path.Combine(ImageContolElement_PathFolder, ImageStartButtonHover_FileName));
            //MessageBox.Show(Path.Combine(ImageContolElement_PathDebug, ImageStartButtonHover_FileName));
            //MessageBox.Show(Path.Combine(ImageControlsFolder_RelativePath, ImageStartButtonHover_FileName));

            //MessageBox.Show(Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageStartButtonHover_FileName));
            //StartButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(Path.GetDirectoryName(Application.StartupPath), Path.GetFileName(ImageStartButtonHover_FileName)));
            StartButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageStartButtonHover_FileName));
            StartButton_PictureBox.Cursor = Cursors.Hand;
        }

        public void StartButton_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            StartButton_PictureBox.Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageStartButton_FileName));
        }

        public void Cursor_enters_element_Style(object sender, EventArgs e)
        {
            StartButton.Cursor = Cursors.Hand;
            Pause_Button.Cursor = Cursors.Hand;
            StopButton.Cursor = Cursors.Hand;
            PauseButton_PictureBox.Cursor = Cursors.Hand;
        }        
        private void Cursor_leaves_element_Style(object sender, EventArgs e)
        {
            StartButton.Cursor = Cursors.Default;
            Pause_Button.Cursor = Cursors.Default;
            StopButton.Cursor = Cursors.Default;
            PauseButton_PictureBox.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Display Functions GroupBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enable_Group_TimemeterFunctions_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable_Group_TimemeterFunctions.Checked) {
                TimeMeterFunctions_GroupBox.Visible = true;
            }
            else {
                TimeMeterFunctions_GroupBox.Visible = false;
            }
        }


        //public static Stream Stream_Image_BGForm = File.OpenRead(@"\\imgControls\\banner_blue.jpg");
        //public static Image BG_Form = Image.FromStream(Stream_Image_BGForm);


        public static string Background_For_TimeMode = DefaultBackgroundImage_FileName;
        //public Bitmap BG_mode2 = (Bitmap)BG_Form; //приведение типа Image к типу Bitmap

        Form CustomInfoBoxMessage = new TimeModeEnableInfoDialog();

        public void Switch_Mode_Button_Click(object sender, EventArgs e)
        {
            CustomInfoBoxMessage.Show();
            StopButton_Click(sender, e);
            //string V1 = Path.GetFileName(Path.GetDirectoryName(Application.CommonAppDataPath.ToLower());

            //Bitmap testc = (Bitmap)BG_Form;
            //MessageBox.Show(testc.GetHbitmap().ToString());
            //
            //MessageBox.Show(BG_Mode2_FilePath);
            //MessageBox.Show("Time mode enabled");


            RealTime_Label.Visible = true;
            RealDate_Label.Visible = true;
            Seconds_Label.Visible = false;
            Minutes_Label.Visible = false;
            Hours_Label.Visible = false;
            Split_Label_1.Visible = false;
            Split_Label_2.Visible = false;
            //Fixated_CheckBox.Visible = false;
            ShowCheckGroup_Button.Visible = false;
            ShowTime_Button.Visible = false; 
            //switch mode buttons:
            Switch_Mode_Button.Enabled = false;
            DefaultMode_Button.Enabled = true;
            //Align Button Align:
            //// ====== //RealTime_Label.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);  //// ToDo Enable in ver. 2.0
            this.BackgroundImage = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, Background_For_TimeMode));
            
            //this.BackgroundImage = Bitmap.FromFile(filename: @"banner_blue.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;


            Align_Button_Click(sender,e);
            Enable_Group_TimemeterFunctions.Checked = false;
            Fixated_CheckBox.Checked = true;
            RealTime_OutputToLabel(sender, e);
            StartButton_PictureBox.Enabled = false;
            StartButton_PictureBox.Visible = false;

            //Hide Secondary Timemeter Labels:
            Small_Timemeter_Label.Visible = false;
            TimemeterCheckGroupBox.Visible = false;

            //stop timemeter main and cover timers
            main_system_timer.Enabled = false;
            timer_for_cover.Enabled = false;
            //Timer_ShowRealTime.Enabled = Enabled;
            Timemeter_ClearVolumes();


            //Minute_Progress_Label.ForeColor = System.Drawing.Color.White;

            //Fixated_CheckBox_CheckedChanged(sender, e);

            //public static string Path = new Path.GetRelativePath("E:\\_Мои файлы\\Разработка\\_ПроектыWMit\\_CL - TimeMeter\\CL - TimemeterDesktop(WinForms)\\CL - Timemeter\\CL - Timemeter\\imgControls\\banner_blue.jpg");
            //{

            //    string relativeTo = "E:\\_Мои файлы\\Разработка\\_ПроектыWMit\\_CL - TimeMeter\\CL - TimemeterDesktop(WinForms)\\CL - Timemeter\\CL - Timemeter\\imgControls\\banner_blue.jpg";
            //    path
            //} 

            //string path1 = @"c:\temp\MyTest.txt";
            //string path2 = @"c:\temp\MyTest";
            //string path3 = @"temp";

            //else
            //{
            //    RealTime_Label.Visible = false;
            //}
        }
        public MessageBox CustomMessageMode;
        public MessageBox DefaultMessageMode;

        public MessageBoxIcon iM1 = MessageBoxIcon.Information;


        public void DefMode_ON(object sender, EventArgs e)
        {
            //CustomMessageMode.
            //CustomMessageMode.Show("Default mode enabled");
            //string A1 = 256.ToString().Substring(A1.ToString());
            //MessageBox.Show(A1);
            //MessageBox.Show("1");

            //Tiemeter buttons enabled:
            //MessageBox.Show("Default Mode Enabled", caption: "Default Mode", buttons:MessageBoxButtons.OK, icon: iM1, defaultButton: MessageBoxDefaultButton.Button1, options: 0, displayHelpButton: false );
            TimeModeEnableInfoDialog Def_ModeEnableInfoDialog = new TimeModeEnableInfoDialog();
            Def_ModeEnableInfoDialog.BackColor = System.Drawing.Color.DarkKhaki;
            Def_ModeEnableInfoDialog.TimeModeInfo_MessageLabel.ForeColor = System.Drawing.Color.Black;
            Def_ModeEnableInfoDialog.TimeModeInfo_MessageLabel.Text = "Timemeter mode enabled";

            //Def_ModeEnableInfoDialog.TimeModeInfo_MessageLabel.BackColor = BackColor = System.Drawing.Color.Black;

            Def_ModeEnableInfoDialog.Show();
            StartButton_PictureBox.Visible = true;
            StartButton_PictureBox.Enabled = true;


            RealTime_Label.Visible = false;
            Seconds_Label.Visible = true;
            Minutes_Label.Visible = true; 
            Hours_Label.Visible = true;
            Split_Label_1.Visible = true;
            Split_Label_2.Visible = true;
            Fixated_CheckBox.Visible = true;
            ShowCheckGroup_Button.Visible = true;
            ShowTime_Button.Visible = true;
            this.BackgroundImage = default;

            ShowCheckGroup_Button.Visible = true;
            ShowTime_Button.Visible = true;

            ////==== function buttons: 
            /////Background functions buttons - Enable in ver. 2.0
            //ChangeBG_Button.Enabled = false;
            //Default_BG_Button.Enabled = false;

            //switch mode buttons:
            Switch_Mode_Button.Enabled = true;
            DefaultMode_Button.Enabled = false;

            //stop all timers
            main_system_timer.Enabled = false;
            timer_for_cover.Enabled = false;
            Timer_ShowRealTime.Enabled = false;
            Timemeter_ClearVolumes();
        }
        /// <summary>
        /// Align Form to corner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Align_Button_Click(object sender, EventArgs e)
        {
            //Get Primary Screen Size:
            Size Screen_Resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            //Size Screen_Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            //Size Screen_Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            //MessageBox.Show(Screen_Resolution.Width.ToString()); //test
            string Screen_Width = Screen_Resolution.Width.ToString();
            int Horisontal_Align = ((Screen_Resolution.Width) - 375);
            this.SetDesktopLocation(Horisontal_Align, 50);
        }

        private void Default_BG_Button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = default;
        }
        /// <summary>
        /// Функция изменения фона главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBG_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenBG_Image = new OpenFileDialog();
            OpenBG_Image.ShowDialog();
            string FileAndPathNameBGImage = OpenBG_Image.FileName;
            MessageBox.Show(FileAndPathNameBGImage);
            Image CustomBG_Image_File = Bitmap.FromFile(filename: @FileAndPathNameBGImage);
            Image DefaultBG_Image_File = Bitmap.FromFile(filename: @"u9_2923.jpg");
            if (FileAndPathNameBGImage == null)
            {
                this.BackgroundImage = DefaultBG_Image_File;
            }
            else
            {
                this.BackgroundImage = CustomBG_Image_File;
            }
        }

        private void CL_Timemeter_Form_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /// <summary>
        /// Real Time Output functions and control element
        /// </summary>
        public Timer Timer_ShowRealTime = new Timer();
    
        //public System.DateTime RealTimeElement = DateTime.UtcNow;
        public System.DateTime RealTimeElement = DateTime.Now;
        public string TimeOutputValume;

        public void Get_RealTime()
        {

            
            RealDate_Label.Text = RealTimeElement.ToString("HH:mm:ss");

            //RealTimeElement.GetDateTimeFormats();

            //RealTimeElement.GetDateTimeFormats().FirstOrDefault();
            //RealTimeElement.ToLocalTime();
            //RealTimeElement.ToUniversalTime();
            //RealTimeElement.TimeOfDay.ToString();

            //MessageBox.Show(RealTimeElement.ToUniversalTime().ToString());
            //MessageBox.Show(T2.ToLocalTime().ToLongTimeString());
            //MessageBox.Show(T2.ToLocalTime().ToLongDateString());
            //MessageBox.Show(T2.ToLocalTime().GetDateTimeFormats()[25].ToString());
            //MessageBox.Show(RealTimeElement.ToUniversalTime().ToString());
            //MessageBox.Show(RealTimeElement.ToLocalTime().ToString());
            //MessageBox.Show(TimeOutputValume);
            //MessageBox.Show(RealTimeElement.GetDateTimeFormats().FirstOrDefault());


            //RealTime_Label.Text = RealTimeElement.TimeOfDay.ToString();

        }
        
        public void Timer_ShowRealTime_Tick(object sender, EventArgs e)
        {
            //Timer_ShowRealTime.Start();
            //Get_RealTime();
            //RealTimeElement.AddMinutes(5);
            //RealTimeElement.AddMinutes(5);
            //System.Timers.Timer timer1 = new System.Timers.Timer();
            //DateTimeOffset
            //RealTimeElement.Add(TimeSpan.Zero);

            //RealTime_Label.Text = RealTimeElement.Date.GetDateTimeFormats()[60].ToString();
            //RealTime_Label.Text = RealTimeElement.Date.GetDateTimeFormats()[51].ToString();
            //RealTime_Label.Text = RealTimeElement.Date.AddMinutes(5).ToString("HH:mm:ss");
            //RealTime_Label.Text = RealTimeElement.Add(TimeSpan.FromSeconds(1518148484)).ToString("HH:mm:ss"); 


            //RealTime_Label.Text = RealTimeElement.ToLocalTime().ToString("HH:mm:ss");  /////////////////////


            //RealTime_Label.Text = RealTimeElement.Date.ToString("HH:mm:ss");



            //RealDate_Label.Text = RealTimeElement.Date.ToString("dd:MM:yyyy");          ///////////////////

            //TimeSpan.FromHours
            //string Rtime = RealTimeElement.ToLocalTime().ToOADate().ToString();

            //string Rtime = RealTimeElement.ToString(DateTimeKind.Local.ToString("HH:mm:ss"));
            //string Rtime = RealTimeElement.ToOADate().(DateTimeKind.Local.ToString("HH:mm:ss"));

            //string Rtime = RealTimeElement.ToOADate().ToString();
            //RealTimeElement.ToLocalTime().ToShortTimeString();
            //string RealTimeOutput =
            
            ////RealTimeElement.Second.ToString() + ":" +
            ////RealTimeElement.Minute.ToString() + ":" +
            ////RealTimeElement.Hour.ToString();
            //RealTime_Label.Text = RealTimeOutput;
            //MessageBox.Show(Rtime);

            //RealTime_Label.Text = RealTimeElement.Date.ToString("dd.MM.yyyy");
            System.DateTime RealTimeOutput2 = DateTime.Now;
     

            //RealTime_Label.Text = RealTimeOutput;
            RealTime_Label.Text = RealTimeOutput2.ToString("HH:mm:ss");
            Small_Timemeter_Label.Text = RealTimeOutput2.ToString("HH:mm:ss");
            RealDate_Label.Text = RealTimeOutput2.ToString("dd.MM.yyyy");
            //Get_RealTime();

            //main_system_timer_Tick(sender, e);
            //Minute_Progress_Label.Text += ".";

        }




        public void RealTime_OutputToLabel(object sender, EventArgs e)
        {
            Timer_ShowRealTime.Interval = 1000;

            Timer_ShowRealTime.Enabled = true;
            //Timer_ShowRealTime.Start();
            Timer_ShowRealTime.Tick += Timer_ShowRealTime_Tick;

            //RealTime_Label.ForeColor = System.Drawing.Color.YellowGreen;
            //Get_RealTime();
            //MessageBox.Show(RealTimeElement.TimeOfDay.ToString());
        }

        private void RealTime_Label_Layout(object sender, LayoutEventArgs e)
        {

            //T1.Start();
            //RealTime_Label.Text = T1.ToString();
        }

        private void Align_Button_MouseEnter(object sender, EventArgs e)
        {
            //Align_Button.BackColor = System.Drawing.Color = global::System.Drawing.Color.FromArgb(((int)(((byte)()))));
            Align_Button.BackColor = System.Drawing.Color.YellowGreen;
        }

        private void Align_Button_MouseLeave(object sender, EventArgs e)
        {
            Align_Button.BackColor = default;
        }

        private void CloseButton_Custom_MouseEnter(object sender, EventArgs e)
        {
            CloseButton_Custom.BackColor = System.Drawing.Color.IndianRed;
            CloseButton_Custom.ForeColor = System.Drawing.Color.White;
        }

        private void CloseButton_Custom_MouseLeave(object sender, EventArgs e)
        {
            CloseButton_Custom.BackColor = default;
            CloseButton_Custom.ForeColor = default;

        }

        private void StopButton_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image StopButton_Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageStopButton_FileName));
            StopButton_PictureBox.Image = StopButton_Image;
        }

        private void StopButton_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image StopButtonHover_Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageStopButtonHover_FileName));
            StopButton_PictureBox.Image = StopButtonHover_Image;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Info_Button_PictureBox_Click(object sender, EventArgs e)
        {

            ////Open form About
            About_Form AboutForm_Open = new About_Form();
            AboutForm_Open.Show();
        }


        private void Info_Button_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Image Info_ButtonHover_Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageInfoButtonHover_FileName));
            Info_Button_PictureBox.Image = Info_ButtonHover_Image;

        }

        private void Info_Button_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Image Info_Button_Image = Bitmap.FromFile(filename: Path.Combine(ImageContolElement_AutoCombinePathFolder, ImageInfoButton_FileName));
            Info_Button_PictureBox.Image = Info_Button_Image;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>


    }
}
