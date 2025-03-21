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
            this.BackToStart_Button.Enabled = false;
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
            //DestinationPathPrepare();
            CopyProgram_Files_To_OS_AndOutputLog();
        }
        /// <summary>
        /// Создание каталогов установки
        /// </summary>
        public string Installer_Folder = Path.GetFullPath(Application.StartupPath); // Distrubution folder only for execution installer.exe
        public string Distrib_SubFolder = Path.Combine(Path.GetFullPath(Application.StartupPath), "Distrib_folder\\"); // sub_folder for resources for installer.exe


        public static string DefaultSystemProgramsFolder = "C:\\Program files\\WMit\\";

        public static string DefaultProgramInstallPath_Relative = "CL-Timemeter\\";
        public static string AboutFiles_InstallPath_Relative = "about\\";
        public static string ImageControls_InstallPath_Relative = "imgControls\\";

        public static string DestinationFolder_PathCombined  = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative);    

        public static string DestinationFolder_imgControls_PathCombined  = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, ImageControls_InstallPath_Relative);




        public void Creation_Folders()
        {
            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, "CL-Timemeter\\" ));
            OutputLog_ListBox.Items.Add("Program destination folder created.");

            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, ImageControls_InstallPath_Relative));
            OutputLog_ListBox.Items.Add("Controls folder created.");

            System.IO.Directory.CreateDirectory(Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative, AboutFiles_InstallPath_Relative));
            OutputLog_ListBox.Items.Add("About files folder created.");


        }
        /// <summary>
        /// Копирование файлов в системный каталог //////////////////////////////
        /// </summary>
        ///
        //пути и имена основных файлов программы для установщика:
        //1. имена файлов:
        public static string Program_EXE_FileName = Path.GetFileName("CL-Timemeter.exe");
        public static string Program_EXEconfig_FileName = Path.GetFileName("CL-Timemeter.exe.config");

        //2. пути основных файлов:
        public static string Program_EXE_Distrib_SubFolderPath = Path.GetDirectoryName("Distrib_folder\\");
        public static string Program_EXEconfig_Distrib_SubFolderPath = Path.GetDirectoryName("Distrib_folder\\");
        //public static string EXE_FromDistrib_Path = Path.Combine(Program_EXE_Distrib_FolderPath, Program_EXE_FileName);
        //public static string EXEconfig_FromDistrib_Path = Path.Combine(Program_EXEconfig_Distrib_FolderPath, Program_EXEconfig_FileName);

        //(Path.GetDirectoryName(Application.StartupPath)

        public static string Program_EXE_FilePath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), Program_EXE_Distrib_SubFolderPath);

        public static string Program_EXEconfig_FilePath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), Program_EXEconfig_Distrib_SubFolderPath);
   

        /// <summary>
        /// For instal proccess
        /// </summary>
        /// <returns></returns>
        //public string DestinationPathPrepare()
        //{
        //    DestinationFolder_PathCombined = Path.Combine(DefaultSystemProgramsFolder, DefaultProgramInstallPath_Relative);
        //    return DestinationFolder_PathCombined;
        //}

        public void CopyProgram_Files_To_OS_AndOutputLog()
        {
            //File File_EXE;
            //FileStream File_EXE_str;
            //File_EXE_str;


            /// <summary>
            /// Копирование файлов установки. Copy main application files (FileName, @FolderPath):
            /// </summary>
            //File.Copy();
            File.Copy(Path.Combine(Installer_Folder, Program_EXE_Distrib_SubFolderPath, Program_EXE_FileName), DestinationFolder_PathCombined + "CL-Timemeter.exe", overwrite: true);
            OutputLog_ListBox.Items.Add("Cltimemeter.exe Installed");   
            
            File.Copy(Path.Combine(Installer_Folder, Program_EXEconfig_Distrib_SubFolderPath, Program_EXEconfig_FileName), DestinationFolder_PathCombined + "CL-Timemeter.exe.config", overwrite: true);
            OutputLog_ListBox.Items.Add("CL-Timemeter.exe.config Installed");

            ///Copy Uninstaller:
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, "Uninstaller_CL-Timemeter.exe"), Path.Combine(DestinationFolder_PathCombined + "Uninstaller_CL-Timemeter.exe"), overwrite: true);


            //File.Copy(@"CL-Timemeter.exe.manifest", @DefaultProgramInstallPath_Relative + "CL-Timemeter.exe.manifest");
            //OutputLog_ListBox.Items.Add("CL-Timemeter.exe.manifest Installed");

            //copy controls images:
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Start_Button_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined, @"Start_Button_Image.png"), overwrite: true);
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Start_Button_Transparent_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined, @"Start_Button_Transparent_Image.png"), overwrite: true);
                                  
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Pause_Button_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"Pause_Button_Image.png"), overwrite: true);
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Pause_Button_Transparent_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"Pause_Button_Transparent_Image.png"), overwrite: true);
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\PauseActivated_Button_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"PauseActivated_Button_Image.png"), overwrite: true);
                             
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Stop_Button_Rectangle_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"Stop_Button_Rectangle_Image.png"), overwrite: true);
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\Stop_Button_Rectangle_Transparent_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + "Stop_Button_Rectangle_Transparent_Image.png"), overwrite: true);
                              
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\green_land_light.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"green_land_light.png"), overwrite: true);
                                 
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\info_Button_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"info_Button_Image.png"), overwrite: true);
            File.Copy(Path.Combine(Installer_Folder, Distrib_SubFolder, @"imgControls\info_Button_Transparent_Image.png"), Path.Combine(DestinationFolder_imgControls_PathCombined + @"info_Button_Transparent_Image.png"), overwrite: true);

            
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
            //MessageBox.Show(Path.Combine(Program_EXE_FilePath, Program_EXE_FileName));
            //MessageBox.Show(Path.Combine(EXE_FromDistrib_Path));
            MessageBox.Show(DestinationFolder_PathCombined);
        }
    }
}
