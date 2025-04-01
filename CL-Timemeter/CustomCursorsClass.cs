using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Timemeter
{
    internal class CustomCursorsClass
    {



        public CustomCursorsClass() { }


        public static Image CR1_Image;
        static Cursor CR1;
        FileStream FSTR_CR1;

        void Display_Cursor()
        {
            //FSTR_CR1.
            //CR1_Image.
            //CR1.Draw(g: Cursors.WaitCursor, Rectangle.Ceiling);
            //CR1.Draw(Graphics.FromHdc(IntPtr.Zero), CR1_Image);
            //CR1.Draw(g: Graphics, CR1_Image);


            //CR1.Draw(g, new Rectangle(0, 0, c.Size.Width, c.Size.Height));
        }

        //example
        public Bitmap ConvertToBitmap(Cursor c)
        {
            //it seems there is no easy way to write cursor to file
            Bitmap bmp = new Bitmap(c.Size.Width, c.Size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                c.Draw(g, new Rectangle(0, 0, c.Size.Width, c.Size.Height));
            }
            return bmp;
        }
    }
    
}
