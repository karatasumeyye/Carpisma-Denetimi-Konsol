using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Silindir
    {
        Nokta3d m;
        int r, h;   // yarıçap ve yükseklik 

      
        public int H { get => h; set => h = value; }
        public Nokta3d M { get => M; set => M = value; }
        public int R { get => r; set => r = value; }



        // Parametreli ve parametresiz kurucular
        public Silindir()
        {
            M = new Nokta3d();
            R = 0;
            H = 0;
        }

        public Silindir(Nokta3d m,int r,int h)
        {
            M = m;
            R = r;
            H = h;
        }
    }
}
