using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//test:
using static System.Configuration.Install.Installer;

namespace CL_Timemeter
{
    public partial class InstallerForm_Start : Form
    {
        public InstallerForm_Start()
        {
            InitializeComponent();
        }
        
        public Form Inst_MainForm = new InstallerMainForm();

        public void CloseStartForm()
        {
            this.Hide();
        }

        public void NextToMainForm_Button_Click(object sender, EventArgs e)
        {
            Inst_MainForm.Show();
            CloseStartForm();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //System.Configuration.Install.Installer InstObj = new System.Configuration.Install.Installer();


        //void DoInstallApp()
        //{
        //    this.button1 = new System.Windows.Forms.Button();
        //    InstObj.Install();
        //}
    }
}
