using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1
{
    abstract class pis: PictureBox
    {
        private static readonly int IMAGE_WIDTH = 50;

        public pis(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x- IMAGE_WIDTH/2, y- IMAGE_WIDTH/2);
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);
        }



    }
}
