namespace Uninstaller_CL_Timemeter
{
    partial class Uninstaller_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uninstaller_Form));
            this.Uninstall_Process_ListBox = new System.Windows.Forms.ListBox();
            this.Uninstall_Button = new System.Windows.Forms.Button();
            this.Uninstall_Process_Description_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Uninstall_Form_Header = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Uninstall_Process_Finished_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Un_Install_timer = new System.Windows.Forms.Timer(this.components);
            this.Test_Array_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Uninstall_Process_ListBox
            // 
            this.Uninstall_Process_ListBox.FormattingEnabled = true;
            this.Uninstall_Process_ListBox.Location = new System.Drawing.Point(12, 49);
            this.Uninstall_Process_ListBox.Name = "Uninstall_Process_ListBox";
            this.Uninstall_Process_ListBox.Size = new System.Drawing.Size(460, 95);
            this.Uninstall_Process_ListBox.TabIndex = 0;
            this.Uninstall_Process_ListBox.Visible = false;
            // 
            // Uninstall_Button
            // 
            this.Uninstall_Button.Location = new System.Drawing.Point(397, 226);
            this.Uninstall_Button.Name = "Uninstall_Button";
            this.Uninstall_Button.Size = new System.Drawing.Size(75, 23);
            this.Uninstall_Button.TabIndex = 1;
            this.Uninstall_Button.Text = "Uninstall";
            this.Uninstall_Button.UseVisualStyleBackColor = true;
            this.Uninstall_Button.Click += new System.EventHandler(this.Uninstall_Button_Click);
            // 
            // Uninstall_Process_Description_Label
            // 
            this.Uninstall_Process_Description_Label.AutoSize = true;
            this.Uninstall_Process_Description_Label.Location = new System.Drawing.Point(12, 96);
            this.Uninstall_Process_Description_Label.Name = "Uninstall_Process_Description_Label";
            this.Uninstall_Process_Description_Label.Size = new System.Drawing.Size(371, 13);
            this.Uninstall_Process_Description_Label.TabIndex = 2;
            this.Uninstall_Process_Description_Label.Text = "To delete application CL-Timemeter from your computer press Uninstall button";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Uninstall_Form_Header
            // 
            this.Uninstall_Form_Header.AutoSize = true;
            this.Uninstall_Form_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uninstall_Form_Header.Location = new System.Drawing.Point(12, 21);
            this.Uninstall_Form_Header.Name = "Uninstall_Form_Header";
            this.Uninstall_Form_Header.Size = new System.Drawing.Size(164, 20);
            this.Uninstall_Form_Header.TabIndex = 4;
            this.Uninstall_Form_Header.Text = "Delete CL-Timemeter ";
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(296, 226);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.Text = "Done";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Visible = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Uninstall_Process_Finished_Label
            // 
            this.Uninstall_Process_Finished_Label.AutoSize = true;
            this.Uninstall_Process_Finished_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uninstall_Process_Finished_Label.Location = new System.Drawing.Point(12, 191);
            this.Uninstall_Process_Finished_Label.Name = "Uninstall_Process_Finished_Label";
            this.Uninstall_Process_Finished_Label.Size = new System.Drawing.Size(454, 20);
            this.Uninstall_Process_Finished_Label.TabIndex = 6;
            this.Uninstall_Process_Finished_Label.Text = "Apllication CL-Timemeter Removed from your computer!";
            this.Uninstall_Process_Finished_Label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Press Done to exit uninstallation program:";
            this.label1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // Un_Install_timer
            // 
            this.Un_Install_timer.Interval = 5000;
            this.Un_Install_timer.Tick += new System.EventHandler(this.Un_Install_timer_Tick);
            // 
            // Test_Array_Button
            // 
            this.Test_Array_Button.Location = new System.Drawing.Point(11, 226);
            this.Test_Array_Button.Name = "Test_Array_Button";
            this.Test_Array_Button.Size = new System.Drawing.Size(75, 23);
            this.Test_Array_Button.TabIndex = 9;
            this.Test_Array_Button.Text = "TestArray";
            this.Test_Array_Button.UseVisualStyleBackColor = true;
            this.Test_Array_Button.Click += new System.EventHandler(this.Test_Array_Button_Click);
            // 
            // Uninstaller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Test_Array_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uninstall_Process_Finished_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Uninstall_Form_Header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Uninstall_Process_Description_Label);
            this.Controls.Add(this.Uninstall_Button);
            this.Controls.Add(this.Uninstall_Process_ListBox);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Uninstaller_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uninstaller_CL-Timemeter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Uninstaller_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Uninstall_Process_ListBox;
        private System.Windows.Forms.Button Uninstall_Button;
        private System.Windows.Forms.Label Uninstall_Process_Description_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Uninstall_Form_Header;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Uninstall_Process_Finished_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer Un_Install_timer;
        private System.Windows.Forms.Button Test_Array_Button;
    }
}