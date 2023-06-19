using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Dikdörtgen
    {
       
        int widht, height;
        Nokta m;

        public int Widht {  get => widht; set => widht = value; }
        public int Height { get => height; set =>height = value; }
        public Nokta M { get => m; set => m = value; }

        public Dikdörtgen()
        {
            M = new Nokta();     // Parametresiz kurucu
            Widht = 0;
            Height = 0;
        }

        public  Dikdörtgen(Nokta m,int w,int h)    // Parametreli kurucu
        {
            M = m;
            Widht = w;
            Height = h;
        }
    }
    
}
