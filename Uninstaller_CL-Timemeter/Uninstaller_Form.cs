using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//custom namespase
using CL_Timemeter;
using Uninstaller_CL_Timemter;

namespace Uninstaller_CL_Timemeter
{
    public partial class Uninstaller_Form : Form
    {
        public Uninstaller_Form()
        {
            InitializeComponent();
        }

        //if (string.IsNullOrEmpty(ReadingArr))
        ///array istalled items list (default list)
        string[] ArrayText_ToLog = new string[10] {  // многомерный массив в переменной
                "green_land_light.png",
                "Info_Button_Image.png",
                "Info_Button_Image_Transparent.png",
                "Pause_Button_Image.png",
                "Pause_Button_Image_Transparent.png",
                "PauseActivated_Button_Image.png",
                "Start_Button_Image.png",
                "Start_Button_Image_Transparent.png",
                "Stop_Button_Rectangle_Image.png",
                "Stop_Button_Rectangle_Transparent_Image.png"
            };

        public string ReadingArr; // for reading array by index
        private void Uninstall_Button_Click(object sender, EventArgs e)
        {
            Un_Install_timer.Enabled = true;
            i = 1;

            Main_Un_Install_Func();

            this.Uninstall_Process_ListBox.Visible = true;
            this.Uninstall_Button.Enabled = false;
            Uninstall_Process_Description_Label.Visible = false;
            Uninstall_Process_Description_Label.Visible = false;
            this.progressBar1.Visible = true;
            
            //progressBar1.Increment(IncrementProgressBar);
            //progressBar1.Increment(10);
            //progressBar1.Increment(15);
            //progressBar1.Increment(15);

            Uninstall_Process_ListBox.Visible = true;
            //Uninstall_Process_ListBox.Items.Clear();
            Uninstall_Process_ListBox.Items.AddRange(new object[] { }); //add array with elements

            Array array1 = new int[2]{ 10, 165 };
            Array TextOutlog = new string[2] { "test1", "test2"}; // многомерный массив




            //ArrayText_ToLog.GetValue(IndexArrayReading).ToString(); 
            Uninstall_Process_ListBox.Visible = true; //test

            ArrayText_ToLog.Append("\n *");




            array1.SetValue(15, 0);
            //array1.Initialize();
            array1.GetValue(0);
            //MessageBox.Show(array1.GetValue(0).ToString());
            //MessageBox.Show(ArrayText_ToLog.GetValue(0, 1).ToString());
            //MessageBox.Show(getSTR1_2);
            //ArrayText_ToLog.GetValue(0).ToString();
            //MessageBox.Show(ArrayText_ToLog.ToString());



        }
        /// <summary>
        /// Удаление каталогов установки
        /// </summary>
        //string DefaultProgramInstallPath = "E:\\Progtam files\\wmit\\CL-Timemeter\\"; ///develop
        public static string DefaultSystemProgramsFolder = "C:\\Program files\\";

        public static string DefaultProgramInstallPath_Relative = "WMit\\CL-Timemeter\\";

        public static string AboutFiles_InstallPath_Relative = "about\\";
        public static string ImageControls_InstallPath_Relative = "imgControls\\";
        //public string DestinationFolder_PathCombined; //in finction DestinationPathPrepare()
        public static string DestinationFolder_PathCombined = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative);

        public void Main_Un_Install_Func()
        {
            //delete files (array list):

            //System.IO.File.Delete("");
            //System.IO.Directory.Delete(Path.Combine(DefaultSystemProgramsFolder, ImageControls_InstallPath_Relative));
            System.IO.Directory.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "imgControls"), recursive: true);
            Uninstall_Process_ListBox.Items.Add("Controls folder - Deleted.");

            System.IO.Directory.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "about"), recursive: true);
            Uninstall_Process_ListBox.Items.Add("About files folder - Deleted.");

            //System.IO.Directory.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative), recursive: true);
            //Uninstall_Process_ListBox.Items.Add("Program destination folder Deleted.");

            System.IO.File.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "CL-Timemeter.exe"));
            Uninstall_Process_ListBox.Items.Add("CL-Timemeter.exe - Deleted.");

            System.IO.File.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "CL-Timemeter.exe.config"));
            Uninstall_Process_ListBox.Items.Add("CL-Timemeter.exe.config - Deleted.");
        }

        public void IncrementBrogressBar()
        {
            progressBar1.Increment(IncrementProgressBar);
        }

        public int i;
        int IncrementProgressBar = 1;
        bool Uninstall_Ended = false;
        public void Un_Install_timer_Tick(object sender, EventArgs e)
        {
            
            do
            {
                i += 10;
                IncrementProgressBar += 10;
                LogToListOutputer();
            } while (i < 3001);
            
            IncrementBrogressBar();
            UninstallProccess();
            
        }
        public void UninstallProccess()
        {
            if (i > 3001) 
            Uninstall_Ended = true;
            Un_Inst_Progress_End();
        }

        public void Un_Inst_Progress_End()
        {
            if (Uninstall_Ended == true)
            {
                Uninstall_Process_Finished_Label.Visible = true;
                Exit_Button.Visible = true;
                Uninstall_Button.Enabled = false;
            }
        }

        public void LogToListOutputer()
        {

            int FullAray = ArrayText_ToLog.GetLength(0); // full array = all indexes count
            int IndexArrayReading = 0; // read array from 0 to 9
            do
            {
                ReadingArr = ArrayText_ToLog.GetValue(IndexArrayReading).ToString();
                //if (string.IsNullOrEmpty(ReadingArr))
                //MessageBox.Show(ReadingArr);
                Uninstall_Process_ListBox.Items.Add(ReadingArr);

                IndexArrayReading += 1;

                //Uninstall_Process_ListBox.Items.AddRange(ArrayText_ToLog.GetValue(IndexArrayReading).ToString());
            }
            while (IndexArrayReading != 10);
        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            ///uninstaller filed delete:
            //System.IO.File.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "Uninstaller_CL-Timemeter.exe"));
            //TODO external process for delete uninstaller itself
            Application.Exit();
        }

        private void Uninstaller_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///uninstaller filed delete:
            //System.IO.File.Delete(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, "Uninstaller_CL-Timemeter.exe"));
            //TODO external process for delete uninstaller itself
            Application.Exit(); //if form closed by default close button on form
        }
        /// <summary>
        /// test array list items output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Test_Array_Button_Click(object sender, EventArgs e)
        {
            var ArrayText_ToLog = new string[10] {  // многомерный массив в переменной
                "green_land_light.png",
                "Info_Button_Image.png",
                "Info_Button_Image_Transparent.png",
                "Pause_Button_Image.png",
                "Pause_Button_Image_Transparent.png",
                "PauseActivated_Button_Image.png",
                "Start_Button_Image.png",
                "Start_Button_Image_Transparent.png",
                "Stop_Button_Rectangle_Image.png",
                "Stop_Button_Rectangle_Transparent_Image.png"
            };

            int FullAray = ArrayText_ToLog.GetLength(0); // full array = all indexes count
            int IndexArrayReading = 0; // read array from 0 to 9

            //ArrayText_ToLog.GetValue(IndexArrayReading).ToString(); 
            Uninstall_Process_ListBox.Visible = true; //test
            do
            {
                ReadingArr = ArrayText_ToLog.GetValue(IndexArrayReading).ToString();
                //MessageBox.Show(ReadingArr);
                
                Uninstall_Process_ListBox.Items.Add(ReadingArr);

                IndexArrayReading += 1;

            }
            while (IndexArrayReading != 10);

            ////MessageBox.Show(ArrayText_ToLog.GetValue(9).ToString());
            ////MessageBox.Show(ArrayText_ToLog.GetValue(8).ToString());
            //MessageBox.Show(FullAray.ToString());

        }
    }
}
