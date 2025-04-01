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
using CL__Timemeter_Installer;

//using IWshRuntimeLibrary;
using Microsoft.Win32;

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
        /// BackToStart Form
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
            Install_Progress_Label.Visible = true;
            instalation_program_timer.Enabled = true;
            Installation_Info_Label.Visible = false;

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
            //CreateShortcut();
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
            CreateShortcut("C:\\Program Files\\WMit\\CL-Timemeter\\CL-Timemeter.exe", "CL-Timemeter"); //test for link create
            //Create_Registy_Keys_for_Installation_CL_Timemeter(); //test for reg key creation
        }


        /// <summary>
        /// Create desktop link
        /// </summary>
        /// <param name="targetFile"></param>
        /// <param name="shortcutName"></param>
        
        //public void CreateShortcut(string targetFile = "C:\\Program Files\\WMit\\CL-Timemeter\\CL-Timemeter.exe", string shortcutName = "CL-Timemeter")
        public void CreateShortcut(string targetFile, string shortcutName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //Program_EXE_FilePath, Program_EXE_FileName
            string shortcutPath = Path.Combine(desktopPath, shortcutName + ".lnk");

            using (StreamWriter writer = new StreamWriter(shortcutPath))
            {
                writer.Write("[InternetShortcut]");
                //writer.Write("URL=file:///" + targetFile);
                writer.WriteLine("URL=file:///" + targetFile);
                writer.WriteLine("IconIndex=0");
                writer.WriteLine("IconFile=" + targetFile);
                writer.Flush();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetFile"></param>
        /// <param name="shortcutName"></param>
        public void Create_Registy_Keys_for_Installation_CL_Timemeter()
        {
            //using (RegistryKey registry = Microsoft.Win32.RegistryKey.FromHandle(handle: ))
            //using (RegistryKey registry = Microsoft.Win32.RegistryKey.OpenBaseKey(hKey: Registry.LocalMachine.OpenSubKey(), view: RegistryHive.LocalMachine.ToString())
            //using (RegistryKey registry = Microsoft.Win32.RegistryKey.OpenBaseKey(hKey: Registry.LocalMachine.OpenSubKey(string Software, ), view: RegistryHive.LocalMachine.ToString())


            //RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Tomcat7", true);
            //key.SetValue("Start", 2, RegistryValueKind.DWord);

            using (RegistryKey registryView = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software"))
            using (RegistryKey registryAdd = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Uninstall"))
            //using (RegistryKey registryAdd_2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Uninstall").CreateSubKey(subkey: "CL-Timemeter").CreateSubKey("CL-Timemeter-test", true))
            //using (RegistryKey registryAdd_2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").CreateSubKey(subkey: "CL-Timemeter").CreateSubKey("CL-Timemeter-test", true))
            //using (RegistryKey registryAdd_2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").CreateSubKey(subkey: "CL-Timemeter").CreateSubKey("CL-Timemeter-test", true))
            //!!!!!!!!!!!!! using (RegistryKey registryAdd_2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall"))//.CreateSubKey(subkey: "CL-Timemeter").CreateSubKey("CL-Timemeter-test", true))
            using (RegistryKey registryAdd_2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft"))//.CreateSubKey(subkey: "CL-Timemeter").CreateSubKey("CL-Timemeter-test", true))

            //using (RegistryKey registry = Microsoft.Win32.RegistryKey.FromHandle
            {
                //registryAdd_2.SetValue(name: "testValue", value: "TestVAlueContent", valueKind: RegistryValueKind.String);
                registryAdd_2.OpenSubKey("\\Windows");

                registryAdd_2.GetValue(name: "testValue");
                registryAdd_2.Close();


                MessageBox.Show(registryAdd_2.Name);
                MessageBox.Show(registryAdd_2.GetValue(name: "testValue").ToString());
            }


            //System.Environment.SetEnvironmentVariable();
            //System.Environment.GetEnvironmentVariable();
        }

        private void Test_RegistryParameters_Button_Click(object sender, EventArgs e)
        {
            Installer_CL_Timemeter.Program_Edit_RegKeys.Install_To_Reg();

        }

        private void testApplist_Btn_Click(object sender, EventArgs e)
        {
            //Get_Installed_AppsList.SetFilePath();
            Get_Installed_AppsList.GetAppsList();
        }
        //Microsoft.Win32.SystemEvents // for autodelete uninstaller todo

        //registry = new Microsoft.Win32.RegistryKey;

    }
}