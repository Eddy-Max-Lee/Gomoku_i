using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isBlack = true;


        public Form1()
        {
            InitializeComponent();
       
            this.Controls.Add(new Whitepis(50, 50));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isBlack)
            {
                this.Controls.Add(new Blackpis(e.X, e.Y));
                isBlack = false;
            }
            else
            {
                this.Controls.Add(new Whitepis(e.X, e.Y));
                isBlack = true;
            }

           
        }
    }
}
