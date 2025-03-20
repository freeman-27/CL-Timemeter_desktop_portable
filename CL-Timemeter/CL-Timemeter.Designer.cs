namespace CL_Timemeter
{
    partial class CL_Timemeter_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CL_Timemeter_Form));
            this.main_system_timer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.Small_Timemeter_Label = new System.Windows.Forms.Label();
            this.CloseButton_Custom = new System.Windows.Forms.Button();
            this.TimeMeterFunctions_GroupBox = new System.Windows.Forms.GroupBox();
            this.Default_BG_Button = new System.Windows.Forms.Button();
            this.ChangeBG_Button = new System.Windows.Forms.Button();
            this.ShowCheckGroup_Button = new System.Windows.Forms.Button();
            this.ShowTime_Button = new System.Windows.Forms.Button();
            this.DefaultMode_Button = new System.Windows.Forms.Button();
            this.Switch_Mode_Button = new System.Windows.Forms.Button();
            this.Full_Seconds_Label = new System.Windows.Forms.Label();
            this.Full_Minutes_Label = new System.Windows.Forms.Label();
            this.Full_Hours_Label = new System.Windows.Forms.Label();
            this.Minimise_Button = new System.Windows.Forms.Button();
            this.Full_Day_Over_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimemeterCheckGroupBox = new System.Windows.Forms.GroupBox();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.timer_for_cover = new System.Windows.Forms.Timer(this.components);
            this.Fixated_CheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton_PictureBox = new System.Windows.Forms.PictureBox();
            this.Split_Label_1 = new System.Windows.Forms.Label();
            this.Split_Label_2 = new System.Windows.Forms.Label();
            this.Minutes_Label = new System.Windows.Forms.Label();
            this.Hours_Label = new System.Windows.Forms.Label();
            this.Seconds_Label = new System.Windows.Forms.Label();
            this.Enable_Group_TimemeterFunctions = new System.Windows.Forms.CheckBox();
            this.Align_Button = new System.Windows.Forms.Button();
            this.RealTime_Label = new System.Windows.Forms.Label();
            this.PauseButton_PictureBox = new System.Windows.Forms.PictureBox();
            this.RealTime_TestLabel = new System.Windows.Forms.Label();
            this.Minute_Progress_Label = new System.Windows.Forms.Label();
            this.StopButton_PictureBox = new System.Windows.Forms.PictureBox();
            this.RealDate_Label = new System.Windows.Forms.Label();
            this.Info_Button_PictureBox = new System.Windows.Forms.PictureBox();
            this.TimeMeterFunctions_GroupBox.SuspendLayout();
            this.TimemeterCheckGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info_Button_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // main_system_timer
            // 
            this.main_system_timer.Interval = 1000;
            this.main_system_timer.Tick += new System.EventHandler(this.main_system_timer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(193, 215);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 75);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.Activate_TimemeterElement_Click);
            this.StartButton.MouseEnter += new System.EventHandler(this.Cursor_enters_element_Style);
            this.StartButton.MouseLeave += new System.EventHandler(this.Cursor_leaves_element_Style);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Location = new System.Drawing.Point(193, 182);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 30);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Small_Timemeter_Label
            // 
            this.Small_Timemeter_Label.AutoSize = true;
            this.Small_Timemeter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Small_Timemeter_Label.Location = new System.Drawing.Point(92, 35);
            this.Small_Timemeter_Label.Name = "Small_Timemeter_Label";
            this.Small_Timemeter_Label.Size = new System.Drawing.Size(120, 31);
            this.Small_Timemeter_Label.TabIndex = 2;
            this.Small_Timemeter_Label.Text = "00:00:00";
            this.Small_Timemeter_Label.Visible = false;
            // 
            // CloseButton_Custom
            // 
            this.CloseButton_Custom.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton_Custom.FlatAppearance.BorderSize = 0;
            this.CloseButton_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton_Custom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton_Custom.Location = new System.Drawing.Point(260, -1);
            this.CloseButton_Custom.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_Custom.Name = "CloseButton_Custom";
            this.CloseButton_Custom.Size = new System.Drawing.Size(40, 40);
            this.CloseButton_Custom.TabIndex = 3;
            this.CloseButton_Custom.Text = "X";
            this.CloseButton_Custom.UseVisualStyleBackColor = false;
            this.CloseButton_Custom.Visible = false;
            this.CloseButton_Custom.Click += new System.EventHandler(this.CloseButton_Custom_Click);
            this.CloseButton_Custom.MouseEnter += new System.EventHandler(this.CloseButton_Custom_MouseEnter);
            this.CloseButton_Custom.MouseLeave += new System.EventHandler(this.CloseButton_Custom_MouseLeave);
            // 
            // TimeMeterFunctions_GroupBox
            // 
            this.TimeMeterFunctions_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.Default_BG_Button);
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.ChangeBG_Button);
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.ShowCheckGroup_Button);
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.ShowTime_Button);
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.DefaultMode_Button);
            this.TimeMeterFunctions_GroupBox.Controls.Add(this.Switch_Mode_Button);
            this.TimeMeterFunctions_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TimeMeterFunctions_GroupBox.Location = new System.Drawing.Point(12, 65);
            this.TimeMeterFunctions_GroupBox.Name = "TimeMeterFunctions_GroupBox";
            this.TimeMeterFunctions_GroupBox.Size = new System.Drawing.Size(280, 60);
            this.TimeMeterFunctions_GroupBox.TabIndex = 6;
            this.TimeMeterFunctions_GroupBox.TabStop = false;
            this.TimeMeterFunctions_GroupBox.Text = "CL Timemeter Functions";
            this.TimeMeterFunctions_GroupBox.Visible = false;
            // 
            // Default_BG_Button
            // 
            this.Default_BG_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Default_BG_Button.Enabled = false;
            this.Default_BG_Button.Location = new System.Drawing.Point(142, 15);
            this.Default_BG_Button.Name = "Default_BG_Button";
            this.Default_BG_Button.Size = new System.Drawing.Size(40, 40);
            this.Default_BG_Button.TabIndex = 33;
            this.Default_BG_Button.Text = "DBG";
            this.Default_BG_Button.UseVisualStyleBackColor = true;
            this.Default_BG_Button.Visible = false;
            this.Default_BG_Button.Click += new System.EventHandler(this.Default_BG_Button_Click);
            // 
            // ChangeBG_Button
            // 
            this.ChangeBG_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeBG_Button.Enabled = false;
            this.ChangeBG_Button.Location = new System.Drawing.Point(100, 15);
            this.ChangeBG_Button.Name = "ChangeBG_Button";
            this.ChangeBG_Button.Size = new System.Drawing.Size(40, 40);
            this.ChangeBG_Button.TabIndex = 32;
            this.ChangeBG_Button.Text = "BG";
            this.ChangeBG_Button.UseVisualStyleBackColor = true;
            this.ChangeBG_Button.Visible = false;
            this.ChangeBG_Button.Click += new System.EventHandler(this.ChangeBG_Button_Click);
            // 
            // ShowCheckGroup_Button
            // 
            this.ShowCheckGroup_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowCheckGroup_Button.Location = new System.Drawing.Point(234, 15);
            this.ShowCheckGroup_Button.Name = "ShowCheckGroup_Button";
            this.ShowCheckGroup_Button.Size = new System.Drawing.Size(40, 40);
            this.ShowCheckGroup_Button.TabIndex = 18;
            this.ShowCheckGroup_Button.Text = "chk";
            this.ShowCheckGroup_Button.UseVisualStyleBackColor = true;
            this.ShowCheckGroup_Button.Click += new System.EventHandler(this.ShowCheckGroup_Button_Click);
            // 
            // ShowTime_Button
            // 
            this.ShowTime_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowTime_Button.Location = new System.Drawing.Point(188, 15);
            this.ShowTime_Button.Name = "ShowTime_Button";
            this.ShowTime_Button.Size = new System.Drawing.Size(40, 40);
            this.ShowTime_Button.TabIndex = 19;
            this.ShowTime_Button.Text = "T";
            this.ShowTime_Button.UseVisualStyleBackColor = true;
            this.ShowTime_Button.Click += new System.EventHandler(this.ShowTime_Button_Click);
            // 
            // DefaultMode_Button
            // 
            this.DefaultMode_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultMode_Button.Enabled = false;
            this.DefaultMode_Button.Location = new System.Drawing.Point(52, 15);
            this.DefaultMode_Button.Name = "DefaultMode_Button";
            this.DefaultMode_Button.Size = new System.Drawing.Size(40, 40);
            this.DefaultMode_Button.TabIndex = 31;
            this.DefaultMode_Button.Text = "DM";
            this.DefaultMode_Button.UseVisualStyleBackColor = true;
            this.DefaultMode_Button.Click += new System.EventHandler(this.DefMode_ON);
            // 
            // Switch_Mode_Button
            // 
            this.Switch_Mode_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch_Mode_Button.Location = new System.Drawing.Point(6, 15);
            this.Switch_Mode_Button.Name = "Switch_Mode_Button";
            this.Switch_Mode_Button.Size = new System.Drawing.Size(40, 40);
            this.Switch_Mode_Button.TabIndex = 29;
            this.Switch_Mode_Button.Text = "SW";
            this.Switch_Mode_Button.UseVisualStyleBackColor = true;
            this.Switch_Mode_Button.Click += new System.EventHandler(this.Switch_Mode_Button_Click);
            // 
            // Full_Seconds_Label
            // 
            this.Full_Seconds_Label.AutoSize = true;
            this.Full_Seconds_Label.Location = new System.Drawing.Point(60, 82);
            this.Full_Seconds_Label.Name = "Full_Seconds_Label";
            this.Full_Seconds_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Seconds_Label.TabIndex = 7;
            this.Full_Seconds_Label.Text = "0.00";
            // 
            // Full_Minutes_Label
            // 
            this.Full_Minutes_Label.AutoSize = true;
            this.Full_Minutes_Label.Location = new System.Drawing.Point(45, 67);
            this.Full_Minutes_Label.Name = "Full_Minutes_Label";
            this.Full_Minutes_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Minutes_Label.TabIndex = 8;
            this.Full_Minutes_Label.Text = "0.00";
            // 
            // Full_Hours_Label
            // 
            this.Full_Hours_Label.AutoSize = true;
            this.Full_Hours_Label.Location = new System.Drawing.Point(30, 52);
            this.Full_Hours_Label.Name = "Full_Hours_Label";
            this.Full_Hours_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Hours_Label.TabIndex = 9;
            this.Full_Hours_Label.Text = "0.00";
            // 
            // Minimise_Button
            // 
            this.Minimise_Button.Location = new System.Drawing.Point(221, -1);
            this.Minimise_Button.Name = "Minimise_Button";
            this.Minimise_Button.Size = new System.Drawing.Size(40, 40);
            this.Minimise_Button.TabIndex = 10;
            this.Minimise_Button.Text = "_";
            this.Minimise_Button.UseVisualStyleBackColor = true;
            this.Minimise_Button.Visible = false;
            // 
            // Full_Day_Over_Label
            // 
            this.Full_Day_Over_Label.AutoSize = true;
            this.Full_Day_Over_Label.Location = new System.Drawing.Point(30, 33);
            this.Full_Day_Over_Label.Name = "Full_Day_Over_Label";
            this.Full_Day_Over_Label.Size = new System.Drawing.Size(13, 13);
            this.Full_Day_Over_Label.TabIndex = 11;
            this.Full_Day_Over_Label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "D:";
            // 
            // TimemeterCheckGroupBox
            // 
            this.TimemeterCheckGroupBox.Controls.Add(this.label3);
            this.TimemeterCheckGroupBox.Controls.Add(this.label4);
            this.TimemeterCheckGroupBox.Controls.Add(this.label2);
            this.TimemeterCheckGroupBox.Controls.Add(this.Full_Seconds_Label);
            this.TimemeterCheckGroupBox.Controls.Add(this.Full_Day_Over_Label);
            this.TimemeterCheckGroupBox.Controls.Add(this.label1);
            this.TimemeterCheckGroupBox.Controls.Add(this.Full_Minutes_Label);
            this.TimemeterCheckGroupBox.Controls.Add(this.Full_Hours_Label);
            this.TimemeterCheckGroupBox.Location = new System.Drawing.Point(12, 190);
            this.TimemeterCheckGroupBox.Name = "TimemeterCheckGroupBox";
            this.TimemeterCheckGroupBox.Size = new System.Drawing.Size(90, 100);
            this.TimemeterCheckGroupBox.TabIndex = 16;
            this.TimemeterCheckGroupBox.TabStop = false;
            this.TimemeterCheckGroupBox.Text = "Timemeter check:";
            this.TimemeterCheckGroupBox.Visible = false;
            this.TimemeterCheckGroupBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // Pause_Button
            // 
            this.Pause_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pause_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause_Button.BackgroundImage")));
            this.Pause_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause_Button.FlatAppearance.BorderSize = 0;
            this.Pause_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_Button.Location = new System.Drawing.Point(193, 215);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(75, 75);
            this.Pause_Button.TabIndex = 17;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = false;
            this.Pause_Button.Visible = false;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            this.Pause_Button.MouseEnter += new System.EventHandler(this.Cursor_enters_element_Style);
            this.Pause_Button.MouseLeave += new System.EventHandler(this.Cursor_leaves_element_Style);
            // 
            // timer_for_cover
            // 
            this.timer_for_cover.Interval = 10000;
            this.timer_for_cover.Tick += new System.EventHandler(this.timer_for_cover_Tick);
            // 
            // Fixated_CheckBox
            // 
            this.Fixated_CheckBox.AutoSize = true;
            this.Fixated_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.Fixated_CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fixated_CheckBox.Location = new System.Drawing.Point(120, 8);
            this.Fixated_CheckBox.Name = "Fixated_CheckBox";
            this.Fixated_CheckBox.Size = new System.Drawing.Size(60, 17);
            this.Fixated_CheckBox.TabIndex = 21;
            this.Fixated_CheckBox.Text = "Fixated";
            this.Fixated_CheckBox.UseVisualStyleBackColor = false;
            this.Fixated_CheckBox.CheckedChanged += new System.EventHandler(this.Fixated_CheckBox_CheckedChanged);
            // 
            // StartButton_PictureBox
            // 
            this.StartButton_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StartButton_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton_PictureBox.BackgroundImage")));
            this.StartButton_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton_PictureBox.ErrorImage = null;
            this.StartButton_PictureBox.InitialImage = null;
            this.StartButton_PictureBox.Location = new System.Drawing.Point(112, 215);
            this.StartButton_PictureBox.Name = "StartButton_PictureBox";
            this.StartButton_PictureBox.Size = new System.Drawing.Size(75, 75);
            this.StartButton_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartButton_PictureBox.TabIndex = 22;
            this.StartButton_PictureBox.TabStop = false;
            this.StartButton_PictureBox.Click += new System.EventHandler(this.Activate_TimemeterElement_Click);
            this.StartButton_PictureBox.MouseEnter += new System.EventHandler(this.StartButton_PictureBox_MouseEnter);
            this.StartButton_PictureBox.MouseLeave += new System.EventHandler(this.StartButton_PictureBox_MouseLeave);
            // 
            // Split_Label_1
            // 
            this.Split_Label_1.AutoSize = true;
            this.Split_Label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Split_Label_1.Location = new System.Drawing.Point(78, 119);
            this.Split_Label_1.Name = "Split_Label_1";
            this.Split_Label_1.Size = new System.Drawing.Size(42, 63);
            this.Split_Label_1.TabIndex = 26;
            this.Split_Label_1.Text = ":";
            this.Split_Label_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Split_Label_2
            // 
            this.Split_Label_2.AutoSize = true;
            this.Split_Label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Split_Label_2.Location = new System.Drawing.Point(186, 119);
            this.Split_Label_2.Name = "Split_Label_2";
            this.Split_Label_2.Size = new System.Drawing.Size(42, 63);
            this.Split_Label_2.TabIndex = 27;
            this.Split_Label_2.Text = ":";
            this.Split_Label_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Minutes_Label
            // 
            this.Minutes_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Minutes_Label.Location = new System.Drawing.Point(106, 122);
            this.Minutes_Label.Name = "Minutes_Label";
            this.Minutes_Label.Size = new System.Drawing.Size(90, 60);
            this.Minutes_Label.TabIndex = 23;
            this.Minutes_Label.Text = "00";
            this.Minutes_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Hours_Label
            // 
            this.Hours_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Hours_Label.Location = new System.Drawing.Point(-8, 122);
            this.Hours_Label.Name = "Hours_Label";
            this.Hours_Label.Size = new System.Drawing.Size(100, 60);
            this.Hours_Label.TabIndex = 25;
            this.Hours_Label.Text = "00";
            this.Hours_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Seconds_Label
            // 
            this.Seconds_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Seconds_Label.Location = new System.Drawing.Point(218, 122);
            this.Seconds_Label.Name = "Seconds_Label";
            this.Seconds_Label.Size = new System.Drawing.Size(90, 60);
            this.Seconds_Label.TabIndex = 24;
            this.Seconds_Label.Text = "00";
            this.Seconds_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Enable_Group_TimemeterFunctions
            // 
            this.Enable_Group_TimemeterFunctions.AutoSize = true;
            this.Enable_Group_TimemeterFunctions.BackColor = System.Drawing.Color.Transparent;
            this.Enable_Group_TimemeterFunctions.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enable_Group_TimemeterFunctions.Location = new System.Drawing.Point(14, 8);
            this.Enable_Group_TimemeterFunctions.Name = "Enable_Group_TimemeterFunctions";
            this.Enable_Group_TimemeterFunctions.Size = new System.Drawing.Size(99, 17);
            this.Enable_Group_TimemeterFunctions.TabIndex = 28;
            this.Enable_Group_TimemeterFunctions.Text = "ShowFunctions";
            this.Enable_Group_TimemeterFunctions.UseVisualStyleBackColor = false;
            this.Enable_Group_TimemeterFunctions.CheckedChanged += new System.EventHandler(this.Enable_Group_TimemeterFunctions_CheckedChanged);
            // 
            // Align_Button
            // 
            this.Align_Button.Location = new System.Drawing.Point(260, -1);
            this.Align_Button.Name = "Align_Button";
            this.Align_Button.Size = new System.Drawing.Size(40, 40);
            this.Align_Button.TabIndex = 29;
            this.Align_Button.Text = ">";
            this.Align_Button.UseVisualStyleBackColor = true;
            this.Align_Button.Click += new System.EventHandler(this.Align_Button_Click);
            this.Align_Button.MouseEnter += new System.EventHandler(this.Align_Button_MouseEnter);
            this.Align_Button.MouseLeave += new System.EventHandler(this.Align_Button_MouseLeave);
            // 
            // RealTime_Label
            // 
            this.RealTime_Label.AutoSize = true;
            this.RealTime_Label.BackColor = System.Drawing.Color.Transparent;
            this.RealTime_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.RealTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.RealTime_Label.Location = new System.Drawing.Point(31, 119);
            this.RealTime_Label.Name = "RealTime_Label";
            this.RealTime_Label.Size = new System.Drawing.Size(237, 63);
            this.RealTime_Label.TabIndex = 30;
            this.RealTime_Label.Text = "00:00:00";
            this.RealTime_Label.Visible = false;
            // 
            // PauseButton_PictureBox
            // 
            this.PauseButton_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PauseButton_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton_PictureBox.BackgroundImage")));
            this.PauseButton_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton_PictureBox.InitialImage = null;
            this.PauseButton_PictureBox.Location = new System.Drawing.Point(112, 215);
            this.PauseButton_PictureBox.Name = "PauseButton_PictureBox";
            this.PauseButton_PictureBox.Size = new System.Drawing.Size(75, 75);
            this.PauseButton_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseButton_PictureBox.TabIndex = 31;
            this.PauseButton_PictureBox.TabStop = false;
            this.PauseButton_PictureBox.Visible = false;
            this.PauseButton_PictureBox.Click += new System.EventHandler(this.Pause_Button_Click);
            this.PauseButton_PictureBox.MouseEnter += new System.EventHandler(this.PauseButton_PictureBox_MouseEnter);
            this.PauseButton_PictureBox.MouseLeave += new System.EventHandler(this.PauseButton_PictureBox_MouseLeave);
            // 
            // RealTime_TestLabel
            // 
            this.RealTime_TestLabel.AutoEllipsis = true;
            this.RealTime_TestLabel.AutoSize = true;
            this.RealTime_TestLabel.BackColor = System.Drawing.Color.Transparent;
            this.RealTime_TestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealTime_TestLabel.Location = new System.Drawing.Point(12, 28);
            this.RealTime_TestLabel.Name = "RealTime_TestLabel";
            this.RealTime_TestLabel.Size = new System.Drawing.Size(139, 17);
            this.RealTime_TestLabel.TabIndex = 0;
            this.RealTime_TestLabel.Text = "RealTime_TestLabel";
            this.RealTime_TestLabel.Visible = false;
            // 
            // Minute_Progress_Label
            // 
            this.Minute_Progress_Label.BackColor = System.Drawing.Color.Transparent;
            this.Minute_Progress_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute_Progress_Label.Location = new System.Drawing.Point(0, 260);
            this.Minute_Progress_Label.Name = "Minute_Progress_Label";
            this.Minute_Progress_Label.Size = new System.Drawing.Size(300, 40);
            this.Minute_Progress_Label.TabIndex = 32;
            this.Minute_Progress_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // StopButton_PictureBox
            // 
            this.StopButton_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StopButton_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton_PictureBox.BackgroundImage")));
            this.StopButton_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton_PictureBox.ErrorImage = null;
            this.StopButton_PictureBox.ImageLocation = "Stretch";
            this.StopButton_PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("StopButton_PictureBox.InitialImage")));
            this.StopButton_PictureBox.Location = new System.Drawing.Point(115, 183);
            this.StopButton_PictureBox.Name = "StopButton_PictureBox";
            this.StopButton_PictureBox.Size = new System.Drawing.Size(68, 29);
            this.StopButton_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopButton_PictureBox.TabIndex = 33;
            this.StopButton_PictureBox.TabStop = false;
            this.StopButton_PictureBox.Visible = false;
            this.StopButton_PictureBox.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton_PictureBox.MouseEnter += new System.EventHandler(this.StopButton_PictureBox_MouseEnter);
            this.StopButton_PictureBox.MouseLeave += new System.EventHandler(this.StopButton_PictureBox_MouseLeave);
            // 
            // RealDate_Label
            // 
            this.RealDate_Label.AutoSize = true;
            this.RealDate_Label.BackColor = System.Drawing.Color.Transparent;
            this.RealDate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RealDate_Label.Location = new System.Drawing.Point(206, 272);
            this.RealDate_Label.Name = "RealDate_Label";
            this.RealDate_Label.Size = new System.Drawing.Size(94, 18);
            this.RealDate_Label.TabIndex = 34;
            this.RealDate_Label.Text = "dd:MM:YYYY";
            this.RealDate_Label.Visible = false;
            // 
            // Info_Button_PictureBox
            // 
            this.Info_Button_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Info_Button_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info_Button_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Info_Button_PictureBox.Image")));
            this.Info_Button_PictureBox.Location = new System.Drawing.Point(226, 5);
            this.Info_Button_PictureBox.Name = "Info_Button_PictureBox";
            this.Info_Button_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Info_Button_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Info_Button_PictureBox.TabIndex = 36;
            this.Info_Button_PictureBox.TabStop = false;
            this.Info_Button_PictureBox.Click += new System.EventHandler(this.Info_Button_PictureBox_Click);
            this.Info_Button_PictureBox.MouseEnter += new System.EventHandler(this.Info_Button_PictureBox_MouseEnter);
            this.Info_Button_PictureBox.MouseLeave += new System.EventHandler(this.Info_Button_PictureBox_MouseLeave);
            // 
            // CL_Timemeter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.Info_Button_PictureBox);
            this.Controls.Add(this.StopButton_PictureBox);
            this.Controls.Add(this.RealDate_Label);
            this.Controls.Add(this.TimeMeterFunctions_GroupBox);
            this.Controls.Add(this.Enable_Group_TimemeterFunctions);
            this.Controls.Add(this.Fixated_CheckBox);
            this.Controls.Add(this.Minimise_Button);
            this.Controls.Add(this.Small_Timemeter_Label);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.TimemeterCheckGroupBox);
            this.Controls.Add(this.RealTime_Label);
            this.Controls.Add(this.Split_Label_1);
            this.Controls.Add(this.Minutes_Label);
            this.Controls.Add(this.Hours_Label);
            this.Controls.Add(this.Seconds_Label);
            this.Controls.Add(this.Split_Label_2);
            this.Controls.Add(this.RealTime_TestLabel);
            this.Controls.Add(this.CloseButton_Custom);
            this.Controls.Add(this.Align_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PauseButton_PictureBox);
            this.Controls.Add(this.StartButton_PictureBox);
            this.Controls.Add(this.Minute_Progress_Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CL_Timemeter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CL-Timemeter";
            this.Load += new System.EventHandler(this.CL_Timemeter_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CL_Timemeter_Form_MouseDown);
            this.MouseEnter += new System.EventHandler(this.CL_Timemeter_Form_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CL_Timemeter_Form_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CL_Timemeter_Form_MouseUp);
            this.TimeMeterFunctions_GroupBox.ResumeLayout(false);
            this.TimemeterCheckGroupBox.ResumeLayout(false);
            this.TimemeterCheckGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info_Button_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer main_system_timer;
        public System.Windows.Forms.Label Small_Timemeter_Label;
        private System.Windows.Forms.GroupBox TimeMeterFunctions_GroupBox;
        public System.Windows.Forms.Label Full_Seconds_Label;
        public System.Windows.Forms.Label Full_Minutes_Label;
        public System.Windows.Forms.Label Full_Hours_Label;
        public System.Windows.Forms.Button Minimise_Button;
        private System.Windows.Forms.Label Full_Day_Over_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Button Pause_Button;
        public System.Windows.Forms.GroupBox TimemeterCheckGroupBox;
        private System.Windows.Forms.Button ShowCheckGroup_Button;
        private System.Windows.Forms.Button ShowTime_Button;
        private System.Windows.Forms.Timer timer_for_cover;
        private System.Windows.Forms.CheckBox Fixated_CheckBox;
        private System.Windows.Forms.PictureBox StartButton_PictureBox;
        public System.Windows.Forms.Label Split_Label_1;
        public System.Windows.Forms.Label Split_Label_2;
        public System.Windows.Forms.Label Minutes_Label;
        public System.Windows.Forms.Label Hours_Label;
        public System.Windows.Forms.Label Seconds_Label;
        private System.Windows.Forms.CheckBox Enable_Group_TimemeterFunctions;
        private System.Windows.Forms.Button Switch_Mode_Button;
        private System.Windows.Forms.Button Align_Button;
        public System.Windows.Forms.Button DefaultMode_Button;
        private System.Windows.Forms.Button ChangeBG_Button;
        private System.Windows.Forms.Button Default_BG_Button;
        public System.Windows.Forms.PictureBox PauseButton_PictureBox;
        public System.Windows.Forms.Label RealTime_Label;
        private System.Windows.Forms.Label RealTime_TestLabel;
        public System.Windows.Forms.Label Minute_Progress_Label;
        private System.Windows.Forms.PictureBox StopButton_PictureBox;
        private System.Windows.Forms.Label RealDate_Label;
        public System.Windows.Forms.Button CloseButton_Custom;
        private System.Windows.Forms.PictureBox Info_Button_PictureBox;
    }
}

