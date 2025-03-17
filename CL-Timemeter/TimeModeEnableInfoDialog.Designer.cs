namespace CL_Timemeter
{
    partial class TimeModeEnableInfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeModeEnableInfoDialog));
            this.TimeModeInfo_MessageLabel = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeModeInfo_MessageLabel
            // 
            this.TimeModeInfo_MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeModeInfo_MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeModeInfo_MessageLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.TimeModeInfo_MessageLabel.Location = new System.Drawing.Point(5, 5);
            this.TimeModeInfo_MessageLabel.Name = "TimeModeInfo_MessageLabel";
            this.TimeModeInfo_MessageLabel.Size = new System.Drawing.Size(190, 190);
            this.TimeModeInfo_MessageLabel.TabIndex = 0;
            this.TimeModeInfo_MessageLabel.Text = "Clocks mode enabled";
            this.TimeModeInfo_MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(62, 133);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 30);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CL Timemeter. Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TimeModeEnableInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.TimeModeInfo_MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "TimeModeEnableInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeModeEnableInfoDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label TimeModeInfo_MessageLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}