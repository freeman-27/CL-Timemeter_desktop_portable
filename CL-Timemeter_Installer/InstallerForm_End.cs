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
using static System.IO.FileInfo;

namespace CL_Timemeter
{
    public partial class InstallerForm_End : Form
    {
        public InstallerForm_End()
        {
            InitializeComponent();
        }

        private void Exit_Installer_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InstallerForm_End_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //if form closed by default close button on form
            //Hyperlinks.
        }

        public string path;
        //public static System.IO.FileSystemInfo CreateSymbolicLink(string path, string pathToTarget)
        public static System.IO.FileSystemInfo CreateSymbolicLink(string path = "soruce", string pathToTarget = "target")
        {
            //path = "";
           //pathToTarget = "";
            return null;
        }
    }
}
