using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Timemeter
{
    internal class InstallationProgramFilesClass
    {
        public InstallationProgramFilesClass() { }

        public void Install() { } //TO DO

        ///Array for // for installer program
        //string[] All_Files;
        //string[] All_Files = new string[5];  
        //string[] All_Files = new string[2] { "1","2"};
        public string[] All_Program_Files = new string[] {
            "CL-Timemeter_Main_Image_R1.png",
            "CL-Timemeter_Main_Hover_Image_R1.png",

            "CL-Timemeter_Main_Image.ico",

            //Controls img:
            "Start_Button_Image.png",
            "Start_Button_Transparent_Image.png",

            "Pause_Button_Image.png",
            "Pause_Button_Transparent_Image.png",
            "PauseActivated_Button_Image.png",

            "Stop_Button_Rectangle__Image.png",
            "Stop_Button_Rectangle_Transparent_Image.png",

            "Info_Button_Image.png",
            "Info_Button_Transparent_Image.png",

            //BG:
            "green_land_light.png",
        };
        public string FullArray = ""; // для вывода всего массива All_Program_Files

        public void Show_Installation_Array() {
            for (int i = 0; i < All_Program_Files.Length; i++)
            {
                //MessageBox.Show(All_Files[i].ToString());
                FullArray = FullArray + All_Program_Files[i] + "\n";
            }
            MessageBox.Show(FullArray);
        }

    }
}
