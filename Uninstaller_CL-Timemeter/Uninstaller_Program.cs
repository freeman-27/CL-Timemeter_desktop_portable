using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Uninstaller_CL_Timemeter
{
    internal static class Uninstaller_Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Uninstaller_Form());
        }

        public class Program_Edit_RegKeys
        {
            public static void Delete_Params_From_Reg()
            {

                // Delete the example key if it exists.
                try
                {
                    Registry.CurrentUser.DeleteSubKey("RegistryRightsExample");
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

            }
        }
    }
}
