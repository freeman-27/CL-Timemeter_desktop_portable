using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace CL_Timemeter
{
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
        }


        //public HtmlDocument About_LocalPage;


        //public static string AboutPage_local_str = "E:\\_Мои файлы\\Разработка\\_ПроектыWMit\\_CL-TimeMeter\\CL-TimemeterDesktop (WinForms)\\CL-Timemeter\\CL-Timemeter\\about\\about_cl-timemeter.html";
        //public static string testUrl = "https://wmit.online";
        //public Url About = new Url(AboutPage_local_str);



        public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //fileName: Path.Combine(Path.GetDirectoryName(Application.StartupPath), @"about\", @"about_cl-timemeter.html"));
            //webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            //webBrowser1.Document = HtmlDocument;
            //webBrowser1.Html
            //About_LocalPage.ExecCommand(command: InitializeComponent());
            //About_LocalPage.Body.InsertAdjacentElement();

            //            HtmlDocument About_LocalPage = new HtmlDocument.;
            //webBrowser1.Document = "About/about_cl-timemeter.html";

            //Uri AboutPage_local;
            //Uri AboutPage_local;


           

            //About.ToString();
            //Url About_Local_Url = new System.Security.Policy.Url(AboutPage_local_str);


            //UriBuilder UriBuild_About = new UriBuilder();
            //UriBuild_About.Path = AboutPage_local_str;

            //UriBuilder OpenWebPage = new UriBuilder();
            //OpenWebPage.Path = testUrl;
            


            //webBrowser1.Url = OpenWebPage.Uri;
            //webBrowser1.Url = UriBuild_About.Uri;

            //MessageBox.Show(About_Local_Url.ToString());
            //MessageBox.Show(UriBuild_About.ToString());
            //MessageBox.Show(webBrowser1.Url.ToString());
            //MessageBox.Show(webBrowser1.Url.ToString());


        }
    }
}
