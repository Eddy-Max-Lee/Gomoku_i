using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Blackpis : pis
    {
        public Blackpis(int x, int y) : base(x,y)
        {
          this.Image = Properties.Resources.black ;
         }
        public override PisType_Enum GetPisType() //改寫
        {
            return PisType_Enum.BLACK;
        }
}
}
