using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CL__Timemeter_Installer
{
    internal class Get_Installed_AppsList
    //public class CreateProgramsList
    {
        /// <summary>
        /// Для вывода списка установленных проргамм в консоль и текстовый файл
        /// </summary>
        //public CreateProgramsList() { 
        // InitializeComponent();
        //}

        //using Microsoft.Win32;
        //using System.IO;
        //public 
        //public string getPath;
        //public static string D1 = null;
        //DirectoryInfo Dir1;
        public static string Dir1;
        
        public static string SetFilePath()
        {

            //FileDialog fileDialogGetPath = new OpenFileDialog(); // Open file
            FileDialog fileDialogGetPath = new SaveFileDialog(); // Save file
            fileDialogGetPath.Title = "SAVING TO TXT:";
            fileDialogGetPath.DefaultExt = ".txt";
            fileDialogGetPath.AddExtension = true;
            fileDialogGetPath.CheckPathExists = true;
            fileDialogGetPath.Filter = "Текстовые файлы (*.txt)|*.txt|Текстовые файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
;
            //fileDialogGetPath.Filter = "text, rtf";
            fileDialogGetPath.ShowDialog(); 

            return fileDialogGetPath.FileName.ToString();
        }

        public static void GetAppsList()
        {

            string SetPath = Path.GetFullPath(SetFilePath());


            string uninstallKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(uninstallKey);
            string[] subKey = regKey.GetSubKeyNames().Select((c) =>
            {
                RegistryKey rk = regKey.OpenSubKey(c);
                string displayName = (string)rk.GetValue("DisplayName");
                if (string.IsNullOrEmpty(displayName)) return "";
                return displayName + string.Format(" => [{0}]", c);
            }).ToArray<string>();
            string filename = SetPath + ".txt"; //saving to TXT file + "ProgramList.txt";
            if (File.Exists(filename)) File.Delete(filename);
            StreamWriter sw = File.CreateText(filename);
            foreach (string appName in subKey.OrderBy(c => c))
            {
                if (appName != "" && !appName.StartsWith("{"))
                {
                    Console.WriteLine(appName);
                    sw.WriteLine(appName);
                }
            }
            sw.Close();
        }

    }

}
