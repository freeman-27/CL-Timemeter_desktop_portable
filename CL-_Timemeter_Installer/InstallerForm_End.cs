using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
