using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Küre
    {
        int r;
        Nokta3d m;

        public Nokta3d M { get => m; set => m = value; }
        public int R { get => r; set => r = value; }

        public Küre()
        {
            M = new Nokta3d();
            R = 0;

        }

        public Küre(Nokta3d m, int r)
        {
            M = m;
            R = r;
        }
    }
}
