using Sümeyye_Karataş_Soru1_Soru2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    public class Nokta
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Nokta ()    // Parametresi kurucu
        {
            X = 0;
            Y = 0;
        }

        public Nokta(int x,int y)   //Parametreli kurucu
        {
            X = x;
            Y = y;
        }

      

    }
}

//Kalıtım ile 3 boyutlu nokta classı oluşturuldu.
public class Nokta3d:Nokta
{
    private  int z;
    public int Z { get => z; set => z = value; }

    public Nokta3d()    
    {
        Z = 0;
    }
    public Nokta3d(int x,int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}