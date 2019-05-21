using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Whitepis : pis
    {
        public Whitepis(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.white;
        }
    }
}
