namespace CL_Timemeter
{
    partial class FormForTestingFunctions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForTestingFunctions));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 7);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 4);
            this.ClearProgressBar_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestInst_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TestFunctions_Buton = new System.Windows.Forms.Button();
            this.Test_button2 = new System.Windows.Forms.Button();
            this.InstallProgress_Timer = new System.Windows.Forms.Timer(this.components);
            this.DisplayImageItems_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearProgressBar_Button
            // 
            this.ClearProgressBar_Button.Location = new System.Drawing.Point(12, 415);
            this.ClearProgressBar_Button.Name = "ClearProgressBar_Button";
            this.ClearProgressBar_Button.Size = new System.Drawing.Size(167, 23);
            this.ClearProgressBar_Button.TabIndex = 0;
            this.ClearProgressBar_Button.Text = "Clear Progress Bar (-25)";
            this.ClearProgressBar_Button.UseVisualStyleBackColor = true;
            this.ClearProgressBar_Button.Click += new System.EventHandler(this.ClearProgressBar_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 308);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(135, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 108);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TestInst_ProgressBar
            // 
            this.TestInst_ProgressBar.Location = new System.Drawing.Point(195, 415);
            this.TestInst_ProgressBar.Name = "TestInst_ProgressBar";
            this.TestInst_ProgressBar.Size = new System.Drawing.Size(593, 23);
            this.TestInst_ProgressBar.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "green_land_light.png");
            this.imageList1.Images.SetKeyName(1, "CL-Timemeter_Main_Hover_Image_R1.png");
            this.imageList1.Images.SetKeyName(2, "CL-Timemeter_Main_Image_R1.png");
            this.imageList1.Images.SetKeyName(3, "Info_Button_Image.png");
            this.imageList1.Images.SetKeyName(4, "Info_Button_Transparent_Image.png");
            this.imageList1.Images.SetKeyName(5, "Pause_Button_Image.png");
            this.imageList1.Images.SetKeyName(6, "Pause_Button_Transparent_Image.png");
            this.imageList1.Images.SetKeyName(7, "PauseActivated_Button_Image.png");
            this.imageList1.Images.SetKeyName(8, "Start_Button_Image.png");
            this.imageList1.Images.SetKeyName(9, "Start_Button_Transparent_Image.png");
            this.imageList1.Images.SetKeyName(10, "Stop_Button_Rectangle_Image.png");
            this.imageList1.Images.SetKeyName(11, "Stop_Button_Rectangle_Transparent_Image.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(478, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 387);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "green_land_light.png");
            this.imageList2.Images.SetKeyName(1, "CL-Timemeter_Main_Hover_Image_R1.png");
            this.imageList2.Images.SetKeyName(2, "CL-Timemeter_Main_Image_R1.png");
            this.imageList2.Images.SetKeyName(3, "Info_Button_Image.png");
            this.imageList2.Images.SetKeyName(4, "Info_Button_Transparent_Image.png");
            this.imageList2.Images.SetKeyName(5, "Pause_Button_Image.png");
            this.imageList2.Images.SetKeyName(6, "Pause_Button_Transparent_Image.png");
            this.imageList2.Images.SetKeyName(7, "PauseActivated_Button_Image.png");
            this.imageList2.Images.SetKeyName(8, "Start_Button_Image.png");
            this.imageList2.Images.SetKeyName(9, "Start_Button_Transparent_Image.png");
            this.imageList2.Images.SetKeyName(10, "Stop_Button_Rectangle_Image.png");
            this.imageList2.Images.SetKeyName(11, "Stop_Button_Rectangle_Transparent_Image.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Testing Elements and functions";
            // 
            // TestFunctions_Buton
            // 
            this.TestFunctions_Buton.BackColor = System.Drawing.Color.LemonChiffon;
            this.TestFunctions_Buton.Location = new System.Drawing.Point(335, 68);
            this.TestFunctions_Buton.Name = "TestFunctions_Buton";
            this.TestFunctions_Buton.Size = new System.Drawing.Size(137, 47);
            this.TestFunctions_Buton.TabIndex = 5;
            this.TestFunctions_Buton.Text = "Test New Functions Array Output and Progrees";
            this.TestFunctions_Buton.UseVisualStyleBackColor = false;
            this.TestFunctions_Buton.Click += new System.EventHandler(this.TestFunctions_Buton_Click);
            // 
            // Test_button2
            // 
            this.Test_button2.Location = new System.Drawing.Point(335, 132);
            this.Test_button2.Name = "Test_button2";
            this.Test_button2.Size = new System.Drawing.Size(137, 59);
            this.Test_button2.TabIndex = 6;
            this.Test_button2.Text = "Test Progress With Cycles";
            this.Test_button2.UseVisualStyleBackColor = true;
            this.Test_button2.Click += new System.EventHandler(this.Test_Button2_Click);
            // 
            // InstallProgress_Timer
            // 
            this.InstallProgress_Timer.Interval = 1000;
            this.InstallProgress_Timer.Tick += new System.EventHandler(this.InstallProgress_Timer_Tick);
            // 
            // DisplayImageItems_Button
            // 
            this.DisplayImageItems_Button.Location = new System.Drawing.Point(335, 213);
            this.DisplayImageItems_Button.Name = "DisplayImageItems_Button";
            this.DisplayImageItems_Button.Size = new System.Drawing.Size(137, 23);
            this.DisplayImageItems_Button.TabIndex = 7;
            this.DisplayImageItems_Button.Text = "Show Images";
            this.DisplayImageItems_Button.UseVisualStyleBackColor = true;
            this.DisplayImageItems_Button.Click += new System.EventHandler(this.DisplayImageItems_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(335, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(499, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 87);
            this.label3.TabIndex = 9;
            this.label3.Text = "Small ImagesList and Large ImagesList must be with the same Items for correct dis" +
    "plaing";
            // 
            // FormForTestingFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DisplayImageItems_Button);
            this.Controls.Add(this.Test_button2);
            this.Controls.Add(this.TestFunctions_Buton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TestInst_ProgressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearProgressBar_Button);
            this.Name = "FormForTestingFunctions";
            this.Text = "FormForTestingFunctions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer InstallProgress_Timer;
        private System.Windows.Forms.Button ClearProgressBar_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar TestInst_ProgressBar;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TestFunctions_Buton;
        private System.Windows.Forms.Button Test_button2;
        private System.Windows.Forms.Button DisplayImageItems_Button;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
    }
}