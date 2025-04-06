using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
//custom namespase
using CL_Timemeter;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using CL__Timemeter_Installer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing;

namespace Installer_CL_Timemeter
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Task task1 = Task.Run(() => Run_MainForm());
        //    //Task task2 = Task.Run(() => runConsole());

        //    // Wait for both tasks to complete
        //    Task.WaitAll(task1);
            
        //    //Program_Edit_RegKeys.Install_To_Reg();
        //}

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form());
            //Application.Run(new InstallerForm_Start());
            Task task1 = Task.Run(() => ShowMainForm());
            Task task2 = Task.Run(() => Run2nd_Form());
            //Task task2 = Task.Run(() => runConsole());
            Task.WaitAll(task1, task2);
        }
        static void ShowMainForm()
        {
            Application.Run(new InstallerForm_Start());
        }
        static void Run2nd_Form()
        {
            Application.Run(new Form1());
        }
    }
    /// End main program 

    /// <summary>
    /// MS Template For Adding Regystry keys 
    /// </summary>
    public class Program_Edit_RegKeys
    {
        public static void Install_To_Reg()
        {
            
            // Delete the example key if it exists.
            try
            {
                Registry.LocalMachine.DeleteSubKey("RegistryRightsExample");
                Console.WriteLine("Example key has been deleted.");
                MessageBox.Show("Example key has been deleted.");
            }
            catch (ArgumentException)
            {
                // ArgumentException is thrown if the key does not exist. In
                // this case, there is no reason to display a message.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete the example key: {0}", ex);
                MessageBox.Show("Unable to delete the example key: {0}");
                return;
            }

            string user = Environment.UserDomainName + "\\" + Environment.UserName;

            RegistrySecurity rs = new RegistrySecurity();

            // Allow the current user to read and delete the key.
            //
            rs.AddAccessRule(new RegistryAccessRule(user,
                RegistryRights.ReadKey | RegistryRights.Delete,
                InheritanceFlags.None,
                PropagationFlags.None,
                AccessControlType.Allow));

            // Prevent the current user from writing or changing the
            // permission set of the key. Note that if Delete permission
            // were not allowed in the previous access rule, denying
            // WriteKey permission would prevent the user from deleting the
            // key.
            rs.AddAccessRule(new RegistryAccessRule(user,
                RegistryRights.WriteKey | RegistryRights.ChangePermissions,
                InheritanceFlags.None,
                PropagationFlags.None,
                AccessControlType.Deny));

            // Create the example key with registry security.
            //RegistryKey rk = null;
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            //RegistryKey rk_01 = null; //custom
            //RegistryKey rk_02 = null; //custom
            //RegistryKey rk_03 = null; //customt
            string Uninstaller_Path = "C:\\Program Files\\WMit\\CL - Timemeter\\Uninstaller_CL-Timemeter.exe";
            string IconImagePath = "C:\\Program Files\\WMit\\CL - Timemeter\\CL-Timemeter.exe";
            string URLInfoAbout = "http://www.wmit.online/CL-Timemeter/about/about_cl-timemeter.html";

            try
            {
                //rk = Registry.LocalMachine.CreateSubKey("RegistryRightsExample",
                //    RegistryKeyPermissionCheck.Default, rs);                
                rk = Registry.LocalMachine
                //rk = Registry.LocalMachine
                    .OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\")
                    //.OpenSubKey("\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").OpenSubKey("")

                    //.OpenSubKey("SOFTWARE")
                    //.OpenSubKey("WOW6432Node")
                    //.OpenSubKey("Microsoft")
                    //.OpenSubKey("Windows")
                    //.OpenSubKey("CurrentVersion")
                    //.OpenSubKey("Uninstall")
                    .CreateSubKey("CL-Timemeter", RegistryKeyPermissionCheck.ReadWriteSubTree, rs);

                ///CL-timemeter registry keys(System Registry path):
                ///
                /// HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\
                /// HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall
                /// \SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall 
                rk.SetValue("DisplayName", "CL-Timemeter");
                rk.SetValue("DisplayIcon", IconImagePath);
                rk.SetValue("Version", "1.0.0.0");
                rk.SetValue("Developer", "wmit.online");
                rk.SetValue("UninstallString", Uninstaller_Path);
                rk.SetValue("URLInfoAbout", URLInfoAbout);

                Console.WriteLine("\r\nExample key created.");
                MessageBox.Show("\r\nExample key created.");

                //rk_01 = Registry.CurrentUser.CreateSubKey("DisplayNameTest", RegistryKeyPermissionCheck.Default, rs);

                rk.SetValue("ValueName", "StringValue");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\r\nUnable to create the example key: {0}", ex);
            }
            if (rk != null) rk.Close();

            rk = Registry.CurrentUser;



            ///Registry Write/Read Access Check without Premissions Settings (for testing access for changing values) 
            //RegistryKey rk2;

            //// Open the key with read access.
            //rk2 = rk.OpenSubKey("RegistryRightsExample", false);
            //Console.WriteLine("\r\nRetrieved value: {0}", rk2.GetValue("ValueName"));
            //MessageBox.Show("\r\nRetrieved value: {0}", rk2.GetValue("ValueName").ToString());

            //rk2.Close();

            /////summary
            ///// Methods For making changes in created regystry keys (try catch cycle) 
            /////summary
            //// Attempt to open the key with write access.
            //try
            //{
            //    rk2 = rk.OpenSubKey("RegistryRightsExample", true);
            //}
            //catch (SecurityException ex)
            //{
            //    Console.WriteLine("\nUnable to write to the example key." +
            //        " Caught SecurityException: {0}", ex.Message);

            //    MessageBox.Show("\nUnable to write to the example key." +
            //        " Caught SecurityException: {0}", ex.Message);
            //}
            //if (rk2 != null) rk2.Close();

            //// Attempt to change permissions for the key.
            //try
            //{
            //    rs = new RegistrySecurity();
            //    rs.AddAccessRule(new RegistryAccessRule(user,
            //        RegistryRights.WriteKey,
            //        InheritanceFlags.None,
            //        PropagationFlags.None,
            //        AccessControlType.Allow));
            //    rk2 = rk.OpenSubKey("RegistryRightsExample", false);
            //    rk2.SetAccessControl(rs);
            //    Console.WriteLine("\r\nExample key permissions were changed.");
            //    MessageBox.Show("\r\nExample key permissions were changed.");
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine("\nUnable to change permissions for the example key." +
            //        " Caught UnauthorizedAccessException: {0}", ex.Message);

            //    MessageBox.Show("\nUnable to change permissions for the example key." +
            //        " Caught UnauthorizedAccessException: {0}", ex.Message);
            //}
            //if (rk2 != null) rk2.Close();

            //Console.WriteLine("\r\nPress Enter to delete the example key.");
            //Console.ReadLine();

            //MessageBox.Show("\r\nPress Ok to delete the example key.");
            ////Read Input
            //Console.ReadLine();

            //try
            //{
            //    rk.DeleteSubKey("RegistryRightsExample");
            //    Console.WriteLine("Example key was deleted.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Unable to delete the example key: {0}", ex);
            //    MessageBox.Show("Unable to delete the example key: {0}");
            //}

            //rk.Close();
        }
    }


    /* This code example produces the following output:

    Example key created.

    Retrieved value: StringValue

    Unable to write to the example key. Caught SecurityException: Requested registry access is not allowed.

    Unable to change permissions for the example key. Caught UnauthorizedAccessException: Cannot write to the registry key.

    Press Enter to delete the example key.

    Example key was deleted.
     */



}
