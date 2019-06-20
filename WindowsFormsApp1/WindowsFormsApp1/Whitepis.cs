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
        public override PisType_Enum GetPisType() //改寫
        {
            return PisType_Enum.WHITE;
        }
    }
}
