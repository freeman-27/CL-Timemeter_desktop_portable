namespace CL_Timemeter
{
    partial class InstallerForm_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm_End));
            this.Exit_Installer_Button = new System.Windows.Forms.Button();
            this.EndForm_Header_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EndForm_Content_Label = new System.Windows.Forms.Label();
            this.EndForm_InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Installer_Button
            // 
            this.Exit_Installer_Button.Location = new System.Drawing.Point(264, 159);
            this.Exit_Installer_Button.Name = "Exit_Installer_Button";
            this.Exit_Installer_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Installer_Button.TabIndex = 0;
            this.Exit_Installer_Button.Text = "Finish";
            this.Exit_Installer_Button.UseVisualStyleBackColor = true;
            this.Exit_Installer_Button.Click += new System.EventHandler(this.Exit_Installer_Button_Click);
            // 
            // EndForm_Header_Label
            // 
            this.EndForm_Header_Label.AutoSize = true;
            this.EndForm_Header_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndForm_Header_Label.Location = new System.Drawing.Point(40, 35);
            this.EndForm_Header_Label.Name = "EndForm_Header_Label";
            this.EndForm_Header_Label.Size = new System.Drawing.Size(145, 20);
            this.EndForm_Header_Label.TabIndex = 1;
            this.EndForm_Header_Label.Text = "Installation finished";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EndForm_Content_Label
            // 
            this.EndForm_Content_Label.AutoSize = true;
            this.EndForm_Content_Label.Location = new System.Drawing.Point(41, 75);
            this.EndForm_Content_Label.Name = "EndForm_Content_Label";
            this.EndForm_Content_Label.Size = new System.Drawing.Size(201, 13);
            this.EndForm_Content_Label.TabIndex = 3;
            this.EndForm_Content_Label.Text = "CL-Timemeter installed on your computer.";
            // 
            // EndForm_InfoLabel
            // 
            this.EndForm_InfoLabel.AutoSize = true;
            this.EndForm_InfoLabel.Location = new System.Drawing.Point(41, 164);
            this.EndForm_InfoLabel.Name = "EndForm_InfoLabel";
            this.EndForm_InfoLabel.Size = new System.Drawing.Size(190, 13);
            this.EndForm_InfoLabel.TabIndex = 4;
            this.EndForm_InfoLabel.Text = "Press Finish to exit installation program:";
            // 
            // InstallerForm_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.EndForm_InfoLabel);
            this.Controls.Add(this.EndForm_Content_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndForm_Header_Label);
            this.Controls.Add(this.Exit_Installer_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm_End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallerForm_End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Installer_Button;
        private System.Windows.Forms.Label EndForm_Header_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EndForm_Content_Label;
        private System.Windows.Forms.Label EndForm_InfoLabel;
    }
}