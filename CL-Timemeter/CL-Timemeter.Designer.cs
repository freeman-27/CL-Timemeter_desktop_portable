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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.Timemeter_Label = new System.Windows.Forms.Label();
            this.CloseButton_Custom = new System.Windows.Forms.Button();
            this.Seconds_Label = new System.Windows.Forms.Label();
            this.TimeValuesLabels_GroupBox = new System.Windows.Forms.GroupBox();
            this.Split_Label_1 = new System.Windows.Forms.Label();
            this.Split_Label_2 = new System.Windows.Forms.Label();
            this.Minutes_Label = new System.Windows.Forms.Label();
            this.Hours_Label = new System.Windows.Forms.Label();
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
            this.ShowCheckGroup_Button = new System.Windows.Forms.Button();
            this.ShowTime_Button = new System.Windows.Forms.Button();
            this.TimeValuesLabels_GroupBox.SuspendLayout();
            this.TimemeterCheckGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Location = new System.Drawing.Point(112, 219);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 75);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Location = new System.Drawing.Point(112, 190);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 30);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Timemeter_Label
            // 
            this.Timemeter_Label.AutoSize = true;
            this.Timemeter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Timemeter_Label.Location = new System.Drawing.Point(92, 41);
            this.Timemeter_Label.Name = "Timemeter_Label";
            this.Timemeter_Label.Size = new System.Drawing.Size(120, 31);
            this.Timemeter_Label.TabIndex = 2;
            this.Timemeter_Label.Text = "00:00:00";
            this.Timemeter_Label.Visible = false;
            // 
            // CloseButton_Custom
            // 
            this.CloseButton_Custom.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton_Custom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton_Custom.Location = new System.Drawing.Point(265, -5);
            this.CloseButton_Custom.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_Custom.Name = "CloseButton_Custom";
            this.CloseButton_Custom.Size = new System.Drawing.Size(40, 40);
            this.CloseButton_Custom.TabIndex = 3;
            this.CloseButton_Custom.Text = "X";
            this.CloseButton_Custom.UseVisualStyleBackColor = false;
            this.CloseButton_Custom.Click += new System.EventHandler(this.CloseButton_Custom_Click);
            // 
            // Seconds_Label
            // 
            this.Seconds_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Seconds_Label.Location = new System.Drawing.Point(205, 30);
            this.Seconds_Label.Name = "Seconds_Label";
            this.Seconds_Label.Size = new System.Drawing.Size(90, 60);
            this.Seconds_Label.TabIndex = 5;
            this.Seconds_Label.Text = "00";
            this.Seconds_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeValuesLabels_GroupBox
            // 
            this.TimeValuesLabels_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TimeValuesLabels_GroupBox.Controls.Add(this.Split_Label_1);
            this.TimeValuesLabels_GroupBox.Controls.Add(this.Split_Label_2);
            this.TimeValuesLabels_GroupBox.Controls.Add(this.Minutes_Label);
            this.TimeValuesLabels_GroupBox.Controls.Add(this.Hours_Label);
            this.TimeValuesLabels_GroupBox.Controls.Add(this.Seconds_Label);
            this.TimeValuesLabels_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeValuesLabels_GroupBox.Location = new System.Drawing.Point(12, 75);
            this.TimeValuesLabels_GroupBox.Name = "TimeValuesLabels_GroupBox";
            this.TimeValuesLabels_GroupBox.Size = new System.Drawing.Size(280, 115);
            this.TimeValuesLabels_GroupBox.TabIndex = 6;
            this.TimeValuesLabels_GroupBox.TabStop = false;
            this.TimeValuesLabels_GroupBox.Text = "CL Timemeter";
            // 
            // Split_Label_1
            // 
            this.Split_Label_1.AutoSize = true;
            this.Split_Label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Split_Label_1.Location = new System.Drawing.Point(65, 30);
            this.Split_Label_1.Name = "Split_Label_1";
            this.Split_Label_1.Size = new System.Drawing.Size(42, 63);
            this.Split_Label_1.TabIndex = 7;
            this.Split_Label_1.Text = ":";
            // 
            // Split_Label_2
            // 
            this.Split_Label_2.AutoSize = true;
            this.Split_Label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Split_Label_2.Location = new System.Drawing.Point(173, 30);
            this.Split_Label_2.Name = "Split_Label_2";
            this.Split_Label_2.Size = new System.Drawing.Size(42, 63);
            this.Split_Label_2.TabIndex = 8;
            this.Split_Label_2.Text = ":";
            // 
            // Minutes_Label
            // 
            this.Minutes_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Minutes_Label.Location = new System.Drawing.Point(97, 30);
            this.Minutes_Label.Name = "Minutes_Label";
            this.Minutes_Label.Size = new System.Drawing.Size(90, 60);
            this.Minutes_Label.TabIndex = 4;
            this.Minutes_Label.Text = "00";
            this.Minutes_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hours_Label
            // 
            this.Hours_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Hours_Label.Location = new System.Drawing.Point(-21, 30);
            this.Hours_Label.Name = "Hours_Label";
            this.Hours_Label.Size = new System.Drawing.Size(100, 60);
            this.Hours_Label.TabIndex = 6;
            this.Hours_Label.Text = "00";
            this.Hours_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Full_Seconds_Label
            // 
            this.Full_Seconds_Label.AutoSize = true;
            this.Full_Seconds_Label.Location = new System.Drawing.Point(64, 69);
            this.Full_Seconds_Label.Name = "Full_Seconds_Label";
            this.Full_Seconds_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Seconds_Label.TabIndex = 7;
            this.Full_Seconds_Label.Text = "0.00";
            // 
            // Full_Minutes_Label
            // 
            this.Full_Minutes_Label.AutoSize = true;
            this.Full_Minutes_Label.Location = new System.Drawing.Point(46, 55);
            this.Full_Minutes_Label.Name = "Full_Minutes_Label";
            this.Full_Minutes_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Minutes_Label.TabIndex = 8;
            this.Full_Minutes_Label.Text = "0.00";
            // 
            // Full_Hours_Label
            // 
            this.Full_Hours_Label.AutoSize = true;
            this.Full_Hours_Label.Location = new System.Drawing.Point(31, 38);
            this.Full_Hours_Label.Name = "Full_Hours_Label";
            this.Full_Hours_Label.Size = new System.Drawing.Size(28, 13);
            this.Full_Hours_Label.TabIndex = 9;
            this.Full_Hours_Label.Text = "0.00";
            // 
            // Minimise_Button
            // 
            this.Minimise_Button.Location = new System.Drawing.Point(228, -5);
            this.Minimise_Button.Name = "Minimise_Button";
            this.Minimise_Button.Size = new System.Drawing.Size(40, 40);
            this.Minimise_Button.TabIndex = 10;
            this.Minimise_Button.Text = "_";
            this.Minimise_Button.UseVisualStyleBackColor = true;
            this.Minimise_Button.Click += new System.EventHandler(this.Minimise_Button_Click);
            // 
            // Full_Day_Over_Label
            // 
            this.Full_Day_Over_Label.AutoSize = true;
            this.Full_Day_Over_Label.Location = new System.Drawing.Point(27, 16);
            this.Full_Day_Over_Label.Name = "Full_Day_Over_Label";
            this.Full_Day_Over_Label.Size = new System.Drawing.Size(13, 13);
            this.Full_Day_Over_Label.TabIndex = 11;
            this.Full_Day_Over_Label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
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
            this.TimemeterCheckGroupBox.Location = new System.Drawing.Point(2, 209);
            this.TimemeterCheckGroupBox.Name = "TimemeterCheckGroupBox";
            this.TimemeterCheckGroupBox.Size = new System.Drawing.Size(107, 85);
            this.TimemeterCheckGroupBox.TabIndex = 16;
            this.TimemeterCheckGroupBox.TabStop = false;
            this.TimemeterCheckGroupBox.Text = "TimemeterCheck";
            this.TimemeterCheckGroupBox.Visible = false;
            this.TimemeterCheckGroupBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Location = new System.Drawing.Point(112, 219);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(75, 75);
            this.Pause_Button.TabIndex = 17;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Visible = false;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // ShowCheckGroup_Button
            // 
            this.ShowCheckGroup_Button.Location = new System.Drawing.Point(2, -5);
            this.ShowCheckGroup_Button.Name = "ShowCheckGroup_Button";
            this.ShowCheckGroup_Button.Size = new System.Drawing.Size(40, 40);
            this.ShowCheckGroup_Button.TabIndex = 18;
            this.ShowCheckGroup_Button.Text = "chk";
            this.ShowCheckGroup_Button.UseVisualStyleBackColor = true;
            this.ShowCheckGroup_Button.Click += new System.EventHandler(this.ShowCheckGroup_Button_Click);
            // 
            // ShowTime_Button
            // 
            this.ShowTime_Button.Location = new System.Drawing.Point(48, -5);
            this.ShowTime_Button.Name = "ShowTime_Button";
            this.ShowTime_Button.Size = new System.Drawing.Size(40, 40);
            this.ShowTime_Button.TabIndex = 19;
            this.ShowTime_Button.Text = "T";
            this.ShowTime_Button.UseVisualStyleBackColor = true;
            this.ShowTime_Button.Click += new System.EventHandler(this.ShowTime_Button_Click);
            // 
            // CL_Timemeter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.ShowTime_Button);
            this.Controls.Add(this.ShowCheckGroup_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Minimise_Button);
            this.Controls.Add(this.Timemeter_Label);
            this.Controls.Add(this.CloseButton_Custom);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeValuesLabels_GroupBox);
            this.Controls.Add(this.TimemeterCheckGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CL_Timemeter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CL-Timemeter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CL_Timemeter_Form_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CL_Timemeter_Form_MouseUp);
            this.TimeValuesLabels_GroupBox.ResumeLayout(false);
            this.TimeValuesLabels_GroupBox.PerformLayout();
            this.TimemeterCheckGroupBox.ResumeLayout(false);
            this.TimemeterCheckGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton_Custom;
        public System.Windows.Forms.Label Timemeter_Label;
        private System.Windows.Forms.GroupBox TimeValuesLabels_GroupBox;
        public System.Windows.Forms.Label Seconds_Label;
        public System.Windows.Forms.Label Hours_Label;
        public System.Windows.Forms.Label Minutes_Label;
        public System.Windows.Forms.Label Split_Label_1;
        public System.Windows.Forms.Label Split_Label_2;
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
    }
}

