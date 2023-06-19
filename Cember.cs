using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Cember
    {
        int r;
        Nokta m;

        public Nokta M { get => m; set => m = value; }
        public int R { get => r; set => r = value; }

        //Parametresiz ve parametreli kurucular
        public Cember()
        {
            M = new Nokta();
            R = 0;
        }
        public Cember(Nokta m,int r)
        {
            M = m;
            R = r;
        }

    }
}
