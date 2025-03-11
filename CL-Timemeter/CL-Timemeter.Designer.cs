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
            this.TimeValuesLabels_GroupBox.SuspendLayout();
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
            this.StartButton.Location = new System.Drawing.Point(103, 213);
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
            this.StopButton.Location = new System.Drawing.Point(184, 213);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 75);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Timemeter_Label
            // 
            this.Timemeter_Label.AutoSize = true;
            this.Timemeter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Timemeter_Label.Location = new System.Drawing.Point(97, 33);
            this.Timemeter_Label.Name = "Timemeter_Label";
            this.Timemeter_Label.Size = new System.Drawing.Size(120, 31);
            this.Timemeter_Label.TabIndex = 2;
            this.Timemeter_Label.Text = "00:00:00";
            // 
            // CloseButton_Custom
            // 
            this.CloseButton_Custom.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton_Custom.ForeColor = System.Drawing.SystemColors.Control;
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
            this.TimeValuesLabels_GroupBox.Location = new System.Drawing.Point(12, 82);
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
            // CL_Timemeter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.Timemeter_Label);
            this.Controls.Add(this.CloseButton_Custom);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeValuesLabels_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CL_Timemeter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CL-Timemeter";
            this.TimeValuesLabels_GroupBox.ResumeLayout(false);
            this.TimeValuesLabels_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button CloseButton_Custom;
        public System.Windows.Forms.Label Timemeter_Label;
        private System.Windows.Forms.Label Seconds_Label;
        private System.Windows.Forms.GroupBox TimeValuesLabels_GroupBox;
        private System.Windows.Forms.Label Hours_Label;
        private System.Windows.Forms.Label Minutes_Label;
        private System.Windows.Forms.Label Split_Label_1;
        private System.Windows.Forms.Label Split_Label_2;
    }
}

