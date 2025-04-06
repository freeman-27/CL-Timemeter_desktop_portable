namespace CL_Timemeter
{
    partial class About_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Form));
            this.Header_Label = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Open_Local_AboutTXT_Button = new System.Windows.Forms.Button();
            this.Open_Local_Help_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_Label.Location = new System.Drawing.Point(12, 9);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(195, 25);
            this.Header_Label.TabIndex = 0;
            this.Header_Label.Text = "About CL-Timemeter";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(926, 440);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://wmit.online/_Projects/CL-Timemeter/WindowsDesktopApp/1.0/about/about_cl-t" +
        "imemeter_v1.0.html", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Open_Local_AboutTXT_Button
            // 
            this.Open_Local_AboutTXT_Button.Location = new System.Drawing.Point(700, 11);
            this.Open_Local_AboutTXT_Button.Name = "Open_Local_AboutTXT_Button";
            this.Open_Local_AboutTXT_Button.Size = new System.Drawing.Size(150, 23);
            this.Open_Local_AboutTXT_Button.TabIndex = 2;
            this.Open_Local_AboutTXT_Button.Text = "Открыть about.txt";
            this.Open_Local_AboutTXT_Button.UseVisualStyleBackColor = true;
            this.Open_Local_AboutTXT_Button.Click += new System.EventHandler(this.Open_Local_AboutTXT_Button_Click);
            // 
            // Open_Local_Help_Button
            // 
            this.Open_Local_Help_Button.Location = new System.Drawing.Point(450, 11);
            this.Open_Local_Help_Button.Name = "Open_Local_Help_Button";
            this.Open_Local_Help_Button.Size = new System.Drawing.Size(200, 23);
            this.Open_Local_Help_Button.TabIndex = 3;
            this.Open_Local_Help_Button.Text = "Открыть локальную справку";
            this.Open_Local_Help_Button.UseVisualStyleBackColor = true;
            this.Open_Local_Help_Button.Click += new System.EventHandler(this.Open_Local_Help_Button_Click);
            // 
            // About_Form
            // 
            this.ClientSize = new System.Drawing.Size(926, 496);
            this.Controls.Add(this.Open_Local_Help_Button);
            this.Controls.Add(this.Open_Local_AboutTXT_Button);
            this.Controls.Add(this.Header_Label);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Label;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Open_Local_AboutTXT_Button;
        private System.Windows.Forms.Button Open_Local_Help_Button;
    }
}
