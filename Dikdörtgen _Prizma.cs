using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Dikdörtgen__Prizma
    {
        Nokta3d m;
        int w, h, d;

        public Nokta3d M { get => m; set => m = value; }
        public int W { get => w; set => w = value; }
        public int H { get => h; set => h = value; }
        public int D { get => d; set => d = value; }


        public Dikdörtgen__Prizma()
        {
            M = new Nokta3d();
            W = 0;
            H = 0;
            d = 0;
        }
        public Dikdörtgen__Prizma(Nokta3d m,int w,int h,int d)
        {
            M = m;
            W = w;
            H = h;
            D = d;
        }

    }
}
