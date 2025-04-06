using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
using System.IO;


namespace CL_Timemeter
{
    public partial class FormForTestingFunctions : Form
    {
        protected Graphics myGraphics;
        private int currentImage = 1;

        public FormForTestingFunctions()
        {
            InitializeComponent();



            ///fOR iMAGE lIST
            imageList1 = new ImageList();
            // The default image size is 16 x 16, which sets up a larger
            // image size. 
            imageList1.ImageSize = new Size(255, 255);
            imageList1.TransparentColor = Color.White;

            // Assigns the graphics object to use in the draw options.
            myGraphics = Graphics.FromHwnd(panel1.Handle);
        }



        InstallationProgramFilesClass installArr = new InstallationProgramFilesClass();

        private void TestFunctions_Buton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            //CL_Timemeter_Form GetVariables = new CL_Timemeter_Form();
            //GetVariables.Hide_All_ControlElement_Labels();
            //CL_Timemeter_Form.Hide_All_ControlElement_Labels();
            //MessageBox.Show(installArr.FullArray);
            //installArr.All_Program_Files.Length;
            
            ShowProgress_With_Installation_Array();
        }


        /// <summary>
        /// Installation Timer
        /// </summary>
        //Timer InstallProgress_Timer = new Timer();
        //ProgressBar TestInst_ProgressBar = new ProgressBar();

        public void ShowProgress_With_Installation_Array()
        {
            InstallProgress_Timer.Interval = 1000;
            InstallProgress_Timer.Enabled = true;
            InstallProgress_Timer.Start();
            TestInst_ProgressBar.Enabled = true;
            //TestInst_ProgressBar.Show();
            //InstallProgress_Timer_Tick(sender, e);
            count_indexes = InstallationProgramFilesClass_1.All_Program_Files.Length;

        }
        int Incr = 10;
        int count_indexes;
        int current_index = 0;
        InstallationProgramFilesClass InstallationProgramFilesClass_1 = new InstallationProgramFilesClass();
        

        public void Installation_Proccess_Core()
        {
            //count_indexes = InstallationProgramFilesClass_1.All_Program_Files.Length;
            //for (int i = 0; i <= 1; i++)
            //{
            //    //index = i;
            //    this.listBox1.Items.Add(installArr.All_Program_Files[i]);
            //    //current_index = i;
            //}
            ClearProgressBar_Button.Enabled = false;

            if (current_index < (installArr.All_Program_Files.Length))
            {
                Repeating_ProgressBar();
                this.listBox1.Items.Add(installArr.All_Program_Files[current_index]);
                current_index += 1;

                //index++;
            }
            else if (current_index == installArr.All_Program_Files.Length)
            {
                InstallProgress_Timer.Enabled = false;
                TestInst_ProgressBar.Style = ProgressBarStyle.Continuous;

                TestInst_ProgressBar.Increment(15);

                TestInst_ProgressBar.Increment(100);

                this.listBox1.Items.Add("Done!");
                ClearProgressBar_Button.Enabled = true;

            }
            ////index++;
            //do
            //{

            //} while (current_index < installArr.All_Program_Files.Length);

            //int i = 0;
            //int Incr = 1;

            //do
            //{
            //    for (i = 0; i < installArr.All_Program_Files.Length; i++)
            //    {
            //        this.listBox1.Items.Add(installArr.All_Program_Files[i]);
            //    }
            //    //this.listBox1.Items.Add(installArr.All_Program_Files[installArr.All_Program_Files.Length]);
            //    //TestInst_ProgressBar.Increment(Incr++);
            //    //i++;
            //    Incr++;
            //} while (Incr < installArr.All_Program_Files.Length);
        }
        public void InstallProgress_Timer_Tick(object sender, EventArgs e)
        {
            Installation_Proccess_Core();            

        }

        private void Test_Button2_Click(object sender, EventArgs e)
        {
            installArr.Show_Installation_Array();

        }

        private void ClearProgressBar_Button_Click(object sender, EventArgs e)
        {
            TestInst_ProgressBar.Increment(-25);
        }
        public void Repeating_ProgressBar()
        {
            TestInst_ProgressBar.Style = ProgressBarStyle.Marquee;
        }


        //ImageList imageList1 = new ImageList();




        public void DisplayImageItems_InList(object sender, EventArgs e)
        {
            //imageList1.Dispose();
            //listView1.Show();
            //listView1.Show();
            this.BackColor = Color.DarkKhaki;
            //listView1 = new ListView();
            //imageList1.Draw(Graphics g, 2, 2, 100, 100, 2);
            //MessageBox.Show(imageList1.Images.ToString());
            //MessageBox.Show(imageList1.Draw(listView1.));
            //listView1.SmallImageList.Draw(Graphics g, 2, 2, 100, 100, 2);
            MessageBox.Show(listView1.SmallImageList.Images.Count.ToString());
            MessageBox.Show(listView1.LargeImageList.ToString());
            //for (int i = 0; i < listView1.LargeImageList.Images.Count; i++)
            //{
            //    listView1.Visible = true;
            //}
            //listView1.Columns.Insert(0, "Header1");

            // Draw the image in the panel.
            //imageList1.Draw(myGraphics, 10, 10, currentImage);
            // Show the image in the PictureBox.


        }

        private void DisplayImageItems_Button_Click(object sender, EventArgs e)
        {
            //DisplayImageItems_InList(sender, e);
            Image Image1 = Bitmap.FromFile(filename: Path.Combine(CL_Timemeter_Form.ImageContolElement_AutoCombinePathFolder, CL_Timemeter_Form.ImageStartButton_FileName));
            pictureBox1.Image = Image1;

            if (imageList1.Images.Empty != true) {
                if (imageList1.Images.Count - 1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }
            panel1.Refresh();
            /// Draw the image in the panel.
            imageList1.Draw(myGraphics, 10, 10, 100, 100, currentImage);
            /// Show the image in the PictureBox.
            pictureBox2.Image = imageList1.Images[currentImage];
                
   
            }

            //listView1.Groups.IndexOf(groop);
            //listView1.BackgroundImage = pictureBox2.Image;
            if (imageList1.Images.Count > 0) { pictureBox1.Image = imageList1.Images[0]; }
            MessageBox.Show(this.imageList1.Images.Count.ToString());
            //imageList1.Images.ContainsKey("Start_Button_Image.png");

            //pictureBox2.Image = imageList1.Images[5];
            MessageBox.Show(this.listView1.Items.ToString());
            MessageBox.Show(this.imageList1.Images.Keys.ToString());

            //pictureBox2.Image = imageList1.Images.Keys.ToString();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
