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
    public partial class CL_Timemeter_Form : Form
    {
        public CL_Timemeter_Form()
        {
            InitializeComponent();
        }

        //System.Drawing.Color

        object BGState = CL_Timemeter_Form.DefaultBackColor;



        //void BGState = System.Drawing.Color.FromArgb(((int)(((byte)(01)



        private void CloseButton_Custom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
