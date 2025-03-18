using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Timemeter
{
    public partial class InstallerMainForm : Form
    {

        public InstallerMainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        public void InstallerMainForm_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// 
        /// </summary>
        private void BackToStart_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form StartForm_InstVar = new InstallerForm_Start(); // InstallerMainForm
            StartForm_InstVar.Show(); // InstallerMainForm
        }
        public int progressBar_Full = 0;
        public int i;

        public void Install_Button_Click(object sender, EventArgs e)
        {
            this.BackToStart_Button.Visible = false;
            this.Install_Button.Enabled = false;

            Installation_Progress_Bar.Visible = true;
            instalation_program_timer.Enabled = true;
            //MessageBox.Show(Installation_Progress_Bar.Maximum.ToString());
            //Installation_Progress_Bar.BackColor = System.Drawing.Color.DarkGreen;
            progressBar_Full = 1;
            i = 1;

            OutputLog_ListBox.Visible = true;
            Install_Form_Header_Label.SetBounds(36, 9, 133, 20);
            //this.SetBounds(500, 400, 400, 350);


            Installation_Progress_Bar.Increment(5);
            Installation_Progress_Bar.Increment(10);
            Installation_Progress_Bar.Increment(15);
            Installation_Progress_Bar.Increment(20);
            Installation_Progress_Bar.Increment(25);
            Installation_Progress_Bar.Increment(50);
            Installation_Progress_Bar.Increment(75);
            Installation_Progress_Bar.Increment(100);

            MainInstall_Func();

        }



        public void OpenEndForm()
        {
            Form EndForm = new InstallerForm_End();
            EndForm.Show();
            this.Close();
        }

        private void Instalation_program_timer_Tick(object sender, EventArgs e)
        {
            do
            {
                i += 10;
            } while (i < 1501);
            Inst_Progress_End();
        }

        public void Inst_Progress_End()
        {
            if (i == 1501)
            {
                Installation_Done_Button.Visible = true;
                //Installation_Done_Button.SetBounds(265, 261, 85, 23);
                Install_Button.Visible = true;
            }
        }


        /// <summary>
        /// Вызов главных функций установвщика
        /// </summary>
        ///
        public void MainInstall_Func()
        {
            Creation_Folders();
            DestinationPathPrepare();
            CopyProgram_Files_To_OS_AndOutputLog();
        }
        /// <summary>
        /// Создание каталогов установки
        /// </summary>
        //string DefaultProgramInstallPath = "E:\\Progtam files\\wmit\\CL-Timemeter\\";
        public static string AboutFiles_InstallPath_Relative = "about\\";
        public static string ImageControls_InstallPath_Relative = "imgControls\\";
        public static string DefaultProgramInstallPath_Relative = "WMit\\CL-Timemeter\\";
        public static string DefaultSystemProgramsFolder = "C:\\Program files\\";
        //public string DestinationFolder_PathCombined; //in finction DestinationPathPrepare()
        public static string DestinationFolder_PathCombined  = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative);

        public void Creation_Folders()
        {
            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative));
            OutputLog_ListBox.Items.Add("Program destination folder created.");
            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, ImageControls_InstallPath_Relative));
            OutputLog_ListBox.Items.Add("Controls folder created.");
            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, AboutFiles_InstallPath_Relative));
            OutputLog_ListBox.Items.Add("About files folder created.");


        }
        /// <summary>
        /// Копирование файлов в системный каталог
        /// </summary>
        ///
        //пути основных файлов программы для установщика:
        public static string Program_EXE_FileName = Path.GetFileName("CL-Timemeter.exe");
        public static string Program_EXE_Distrib_FolderPath = Path.GetDirectoryName("Distrib_Folder\\");
        public static string EXE_FromDistrib_Path = Path.Combine(Program_EXE_Distrib_FolderPath, Program_EXE_FileName);

        public static string Program_EXE_FilePath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), Program_EXE_FileName); 
        
        public static string Program_EXEconfig_FileName = Path.GetFileName("CL-Timemeter.exe.config");
        public static string Program_EXEconfig_FilePath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), Program_EXEconfig_FileName);
        //public static string Program_EXE_FilePath_Destination = Path.Combine(Path.GetDirectoryName(Application.StartupPath), Program_EXE_FileName);

        public string DestinationPathPrepare()
        {
            DestinationFolder_PathCombined = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative);
            return DestinationFolder_PathCombined;
        }
        public void CopyProgram_Files_To_OS_AndOutputLog()
        {
            //File File_EXE;
            //FileStream File_EXE_str;
            //File_EXE_str;


            /// <summary>
            ////Copy main application files (FileName, @FolderPath):
            /// </summary>
            //File.Copy();
            File.Copy(EXE_FromDistrib_Path, DestinationFolder_PathCombined + "CL-Timemeter.exe");
            OutputLog_ListBox.Items.Add("Cltimemeter.exe Installed");   
            
            File.Copy(Program_EXEconfig_FilePath, DestinationFolder_PathCombined + @"CL-Timemeter.exe.config");
            OutputLog_ListBox.Items.Add("CL-Timemeter.exe.config Installed"); 
            
            //File.Copy(@"CL-Timemeter.exe.manifest", @DefaultProgramInstallPath_Relative + "CL-Timemeter.exe.manifest");
            //OutputLog_ListBox.Items.Add("CL-Timemeter.exe.manifest Installed");

            //copy controls images:
            File.Copy(@"imgControls\Start_Button_Image.png", DestinationFolder_PathCombined + @"Start_Button_Image.png");
            File.Copy(@"imgControls\Start_Button_Image_Transparent.png", DestinationFolder_PathCombined + @"Start_Button_Transparent_Image.png");
                        
            File.Copy(@"imgControls\Pause_Button_Image.png", DestinationFolder_PathCombined + @"Pause_Button_Image.png");
            File.Copy(@"imgControls\Pause_Button_Image_Transparent.png", DestinationFolder_PathCombined + @"Pause_Button_Transparent_Image.png");
            File.Copy(@"imgControls\PauseActivated_Button_Image.png", DestinationFolder_PathCombined + @"PauseActivated_Button_Image.png");
                       
            File.Copy(@"imgControls\Stop_Button_Rectangle_Image.png", DestinationFolder_PathCombined + @"Stop_Button_Rectangle_Image.png");
            File.Copy(@"imgControls\Stop_Button_Rectangle_Transparent_Image.png", DestinationFolder_PathCombined + "Stop_Button_Rectangle_Transparent_Image.png");
            File.Copy(@"imgControls\green_land_light.png", DestinationFolder_PathCombined + @"green_land_light.png");
            File.Copy(@"imgControls\info_Button_Image.png", DestinationFolder_PathCombined + @"info_Button_Image.png");
            File.Copy(@"imgControls\info_Button_Image_Transparent.png", DestinationFolder_PathCombined + @"info_Button_Image_Transparent.png");
            OutputLog_ListBox.Items.Add("Controls Elements Installed");

            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");
            //OutputLog_ListBox.Items.Add("file Installed");

            //File.Create();
            //string InstPAth = @"E:\TestInst_Auto";
            //System.IO.FileOptions Options = new System.IO.FileOptions();
            //Options
        }

        private void Installation_Done_Button_Click(object sender, EventArgs e)
        {
            OpenEndForm();
        }

        private void Test_PathFolder_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative));
            MessageBox.Show(Path.Combine(Program_EXE_FilePath, Program_EXE_FileName));
            MessageBox.Show(Path.Combine(EXE_FromDistrib_Path));
            MessageBox.Show(DestinationFolder_PathCombined);
        }
    }
}
