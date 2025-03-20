namespace CL_Timemeter
{
    partial class InstallerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerMainForm));
            this.BackToStart_Button = new System.Windows.Forms.Button();
            this.Install_Button = new System.Windows.Forms.Button();
            this.Installation_Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.Install_Progress_Label = new System.Windows.Forms.Label();
            this.Install_Form_Header_Label = new System.Windows.Forms.Label();
            this.instalation_program_timer = new System.Windows.Forms.Timer(this.components);
            this.OutputLog_ListBox = new System.Windows.Forms.ListBox();
            this.Installation_Done_Button = new System.Windows.Forms.Button();
            this.Test_PathFolder_Button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BackToStart_Button
            // 
            this.BackToStart_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToStart_Button.Location = new System.Drawing.Point(40, 161);
            this.BackToStart_Button.Name = "BackToStart_Button";
            this.BackToStart_Button.Size = new System.Drawing.Size(75, 23);
            this.BackToStart_Button.TabIndex = 10;
            this.BackToStart_Button.Text = "Back";
            this.BackToStart_Button.UseVisualStyleBackColor = true;
            this.BackToStart_Button.Click += new System.EventHandler(this.BackToStart_Button_Click);
            // 
            // Install_Button
            // 
            this.Install_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Install_Button.Location = new System.Drawing.Point(265, 161);
            this.Install_Button.Name = "Install_Button";
            this.Install_Button.Size = new System.Drawing.Size(75, 23);
            this.Install_Button.TabIndex = 0;
            this.Install_Button.Text = "Install";
            this.Install_Button.UseVisualStyleBackColor = true;
            this.Install_Button.Click += new System.EventHandler(this.Install_Button_Click);
            // 
            // Installation_Progress_Bar
            // 
            this.Installation_Progress_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Installation_Progress_Bar.BackColor = System.Drawing.SystemColors.Control;
            this.Installation_Progress_Bar.Location = new System.Drawing.Point(40, 130);
            this.Installation_Progress_Bar.Name = "Installation_Progress_Bar";
            this.Installation_Progress_Bar.Size = new System.Drawing.Size(300, 23);
            this.Installation_Progress_Bar.TabIndex = 2;
            this.Installation_Progress_Bar.Visible = false;
            // 
            // Install_Progress_Label
            // 
            this.Install_Progress_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Install_Progress_Label.AutoSize = true;
            this.Install_Progress_Label.Location = new System.Drawing.Point(37, 111);
            this.Install_Progress_Label.Name = "Install_Progress_Label";
            this.Install_Progress_Label.Size = new System.Drawing.Size(84, 13);
            this.Install_Progress_Label.TabIndex = 3;
            this.Install_Progress_Label.Text = "Install_Progress:";
            // 
            // Install_Form_Header_Label
            // 
            this.Install_Form_Header_Label.AutoSize = true;
            this.Install_Form_Header_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Install_Form_Header_Label.Location = new System.Drawing.Point(36, 30);
            this.Install_Form_Header_Label.Name = "Install_Form_Header_Label";
            this.Install_Form_Header_Label.Size = new System.Drawing.Size(133, 20);
            this.Install_Form_Header_Label.TabIndex = 4;
            this.Install_Form_Header_Label.Text = "Installation Stage";
            // 
            // instalation_program_timer
            // 
            this.instalation_program_timer.Interval = 8000;
            this.instalation_program_timer.Tick += new System.EventHandler(this.Instalation_program_timer_Tick);
            // 
            // OutputLog_ListBox
            // 
            this.OutputLog_ListBox.FormattingEnabled = true;
            this.OutputLog_ListBox.Location = new System.Drawing.Point(40, 29);
            this.OutputLog_ListBox.Name = "OutputLog_ListBox";
            this.OutputLog_ListBox.Size = new System.Drawing.Size(300, 82);
            this.OutputLog_ListBox.TabIndex = 5;
            this.OutputLog_ListBox.Visible = false;
            // 
            // Installation_Done_Button
            // 
            this.Installation_Done_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Installation_Done_Button.Location = new System.Drawing.Point(184, 161);
            this.Installation_Done_Button.Name = "Installation_Done_Button";
            this.Installation_Done_Button.Size = new System.Drawing.Size(75, 23);
            this.Installation_Done_Button.TabIndex = 6;
            this.Installation_Done_Button.Text = "Done";
            this.Installation_Done_Button.UseVisualStyleBackColor = true;
            this.Installation_Done_Button.Visible = false;
            this.Installation_Done_Button.Click += new System.EventHandler(this.Installation_Done_Button_Click);
            // 
            // Test_PathFolder_Button
            // 
            this.Test_PathFolder_Button.Location = new System.Drawing.Point(122, 160);
            this.Test_PathFolder_Button.Name = "Test_PathFolder_Button";
            this.Test_PathFolder_Button.Size = new System.Drawing.Size(56, 23);
            this.Test_PathFolder_Button.TabIndex = 7;
            this.Test_PathFolder_Button.Text = "testPath";
            this.Test_PathFolder_Button.UseVisualStyleBackColor = true;
            this.Test_PathFolder_Button.Click += new System.EventHandler(this.Test_PathFolder_Button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(216, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "install YandexBrowser(test)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // InstallerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Test_PathFolder_Button);
            this.Controls.Add(this.Installation_Done_Button);
            this.Controls.Add(this.Install_Form_Header_Label);
            this.Controls.Add(this.Install_Progress_Label);
            this.Controls.Add(this.Installation_Progress_Bar);
            this.Controls.Add(this.Install_Button);
            this.Controls.Add(this.BackToStart_Button);
            this.Controls.Add(this.OutputLog_ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InstallerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallerMainForm";
            this.Load += new System.EventHandler(this.InstallerMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToStart_Button;
        private System.Windows.Forms.Button Install_Button;
        private System.Windows.Forms.Label Install_Progress_Label;
        private System.Windows.Forms.Label Install_Form_Header_Label;
        private System.Windows.Forms.Timer instalation_program_timer;
        private System.Windows.Forms.ProgressBar Installation_Progress_Bar;
        private System.Windows.Forms.ListBox OutputLog_ListBox;
        private System.Windows.Forms.Button Installation_Done_Button;
        private System.Windows.Forms.Button Test_PathFolder_Button;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}