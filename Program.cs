
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...:  Soru 3
** ÖĞRENCİ ADI...............:  Sümeyye Karataş
** ÖĞRENCİ NUMARASI.:  B221210005
** DERS GRUBU…………:    1. Öğretim A Grubu

                 
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sümeyye_Karataş_Soru1_Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nÇarpışma denetimi için istediğiniz seçimin başındaki numarayı yaznınız.\n");

            Console.WriteLine("*****ÇARPIŞMA DENETİM İŞLEMLERİ*****");
            Console.WriteLine("1. Nokta-dikdörtgen çarpışma denetimi");
            Console.WriteLine("2. Nokta-çember çarpışma denetimi");
            Console.WriteLine("3. Dikdörtgen-dikdörtgen çarpışma denetimi");
            Console.WriteLine("4. Dikdörtgen-çember çarpışma denetimi");
            Console.WriteLine("5. Çember-çember çarpışma denetimi");
            Console.WriteLine("6. Nokta-küre çarpışma denetimi");
            Console.WriteLine("7. Nokta-silindir çarpışma denetimi");
            Console.WriteLine("8. Silindir-silindir çarpışma denetimi");
            Console.WriteLine("9. Küre-küre çarpışma denetimi");
            Console.WriteLine("10. Küre-silindir çarpışma denetimi");
            Console.WriteLine("11. Küre-dikdörtgen prizma çarpışma denetimi");
            Console.WriteLine("12. Dikdörtgen prizma-dikdörtgen prizma çarpışma denetimi");



            Console.WriteLine("\nSeçiminiz :");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            if(secim==1)
            {
                Nokta p1 = Veri_Alma.Nokta_Veri();
                Dikdörtgen di1 = Veri_Alma.Dikdörtgen_Veri();
                Console.Clear();
                if (Carpisma.Nokta_Dikdörtgen(p1, di1))
                    Console.WriteLine("Nokta ve dikdörtgen çapışıyor.");
                else
                    Console.WriteLine("Nokta dikdörtgen çarpışmıyor");
            }

            else if (secim==2)
            {
                Nokta p1 = Veri_Alma.Nokta_Veri();
                Cember c1 = Veri_Alma.Cember_Veri();
                Console.Clear();
                if (Carpisma.Nokta_Cember(p1, c1))
                    Console.WriteLine("Nokta ve çember çarpışıyor.");
                else
                    Console.WriteLine("Nokta ve çember çarpışmıyor.");
            }

            else if(secim ==3)
            {
                Dikdörtgen di1 = Veri_Alma.Dikdörtgen_Veri();
                Dikdörtgen di2 = Veri_Alma.Dikdörtgen_Veri();
                Console.Clear();

                if (Carpisma.Dikdörtgen_Dikdörtgen(di1, di2))
                    Console.WriteLine("Dikdörtgenler çarpışıyor");
                else
                    Console.WriteLine("Dikdörtgenler çarpışmıyor");
            }

            else if(secim ==4)
            {
                Dikdörtgen di1 = Veri_Alma.Dikdörtgen_Veri();
                Cember c1 = Veri_Alma.Cember_Veri();
                Console.Clear();
                if (Carpisma.Dikdörtgen_Cember(di1, c1))
                    Console.WriteLine("Dikdörtgen ve çember çarpışıyor");
                else
                    Console.WriteLine("Dikdörtgen ve çember çarpışmıyor");
            }

            else if(secim==5)
            {
                Cember c1 = Veri_Alma.Cember_Veri();
                Cember c2 = Veri_Alma.Cember_Veri();
                Console.Clear();
                if (Carpisma.Cember_Cember(c1, c2))
                    Console.WriteLine("Çemberler çarpışıyor");
                else
                    Console.WriteLine("Çemberler çarpışmıyor");
            }
            else if(secim ==6)
            {
                Nokta3d n1 = Veri_Alma.nokta3D_Veri();
                Küre da1 = Veri_Alma.Küre_Veri();
                Console.Clear();
                if (Carpisma.Nokta_Küre(n1, da1))
                    Console.WriteLine("Nokta ve küre çarpışıyor.");
                else
                    Console.WriteLine("Nokta ve küre çarpışıyor.");
            }
            else if (secim==7)
            {
                Nokta3d n1 = Veri_Alma.nokta3D_Veri();
                Silindir s1 = Veri_Alma.Silindir_Veri();
                Console.Clear();
                if (Carpisma.Nokta_Silindir(n1, s1)) 
                Console.WriteLine("Nokta ve silindir çarpışıyor");
                else
                    Console.WriteLine("Nokta ve silindir çarpışmıyor");
            }
            else if(secim==8)
            {
                Silindir s1 = Veri_Alma.Silindir_Veri();
                Silindir s2 = Veri_Alma.Silindir_Veri();
                Console.Clear();
                if (Carpisma.Silindir_Silindir(s1, s2))
                    Console.WriteLine("Silindirler çarpışıyor");
                else
                    Console.WriteLine("Silindirler çarpışmıyor");
            }
            else if(secim==9)
            {
                Küre da1 = Veri_Alma.Küre_Veri();
                Küre da2 = Veri_Alma.Küre_Veri();
                Console.Clear();
                if (Carpisma.Küre_Küre(da1, da2))
                    Console.WriteLine("Daireler çarpışıyor");
                else
                    Console.WriteLine("Daireler çarpışmıyor");
            }
            else if(secim==10)
            {
                Küre da1 = Veri_Alma.Küre_Veri();
                Silindir s1 = Veri_Alma.Silindir_Veri();
                Console.Clear();
                if (Carpisma.Küre_Silindir(da1, s1))
                    Console.WriteLine("Küre ve silinidr çarpışıyor.");
                else
                    Console.WriteLine("Küre ve silinidr çarpışmıyor.");

            }
            else if(secim==11)
            {
                Küre da1 = Veri_Alma.Küre_Veri();
                Dikdörtgen__Prizma p1 = Veri_Alma.Prizma_Veri();
                Console.Clear();
                if (Carpisma.Küre_Prizma(da1, p1))
                    Console.WriteLine("Küre ve prizma çarpışıyor");
                else
                    Console.WriteLine("Küre ve prizma çarpışmıyor");
            }
            else if(secim==12)
            {
                Dikdörtgen__Prizma p1 = Veri_Alma.Prizma_Veri();
                Dikdörtgen__Prizma p2 = Veri_Alma.Prizma_Veri();
                Console.Clear();
                if(Carpisma.Prizma_Prizma(p1,p2))
                  Console.WriteLine("Prizmalar çarpışıyor");
                else
                    Console.WriteLine("Prizmalar çarpışmıyor");



            }


            Console.ReadLine();

        }


        public static class Carpisma
        {
            public static bool Nokta_Dikdörtgen(Nokta p1, Dikdörtgen di1)
            {
                float diLeft = di1.M.X - di1.Widht / 2;                 // Dikdörtgenin sol,sağ,üst ve alt köşelerinin koordinatları hesaplanır.
                float diRight = di1.M.X + di1.Widht / 2;
                float diTop = di1.M.Y + di1.Height / 2;
                float diBottom = di1.M.Y - di1.Height / 2;
                bool result1 = diBottom <= p1.X && p1.X <= diTop;        // Noktanın bu koordinatlar içinde olup olmadığı kontrol edilir.
                bool result2 = diLeft <= p1.Y && p1.Y <= diRight;
                if (result1 && result2)
                    return true;
                else
                    return false;


            }

            public static bool Nokta_Cember(Nokta p1, Cember c1)
            {
                float d = (float)Math.Sqrt(Math.Pow((p1.X - c1.M.X), 2) + Math.Pow((p1.Y - c1.M.Y), 2));        //Nokta ve  çember merkezlerinin arasındaki uzaklık hesaplanır.
                if (d <= c1.R)
                    return true;
                else
                    return false;
            }

            public static bool Dikdörtgen_Dikdörtgen(Dikdörtgen di1, Dikdörtgen di2)
            {

                float di1Left = di1.M.X - di1.Widht / 2;                 // Dikdörtgenin sol,sağ,üst ve alt köşelerinin koordinatları hesaplanır.
                float di1Right = di1.M.X + di1.Widht / 2;
                float di1Top = di1.M.Y + di1.Height / 2;
                float di1Bottom = di1.M.Y - di1.Height / 2;


                float di2Left = di2.M.X - di2.Widht / 2;                 // Dikdörtgenin sol,sağ,üst ve alt köşelerinin koordinatları hesaplanır.
                float di2Right = di2.M.X + di2.Widht / 2;
                float di2Top = di2.M.Y + di2.Height / 2;
                float di2Bottom = di2.M.Y - di2.Height / 2;

                bool result1 = (di1Bottom <= di2Top && di1Bottom >= di2Bottom) || (di2Bottom <= di1Top && di2Bottom >= di1Bottom);
                bool result2 = (di1Left <= di2Right && di1Left >= di2Left) || (di2Left <= di1Right && di2Left >= di1Left);

                if (result1 && result2)
                    return true;
                else
                    return false;
            }

            public static bool Dikdörtgen_Cember(Dikdörtgen di1, Cember c1)
            {
                float distx = Math.Abs(c1.M.X - di1.M.X);          // Çemberin merkezi ile dikdörtgenin merkezi arasındaki x ve y farkının mutlak değerleri hesaplanır.
                float disty = Math.Abs(c1.M.Y - di1.M.Y);

                if (distx > (di1.Widht / 2 + c1.R))
                    return false;
                if (disty > (di1.Height / 2 + c1.R))
                    return false;
                if (distx <= (di1.Widht / 2))
                    return true;
                if (disty <= di1.Height / 2)
                    return true;

                var hypot = Math.Sqrt(Math.Pow((distx - di1.Widht / 2), 2) + Math.Pow((disty - di1.Height / 2), 2));    // Dik merkezden bir çizginin çember yarıçapı kadar uzatılmasıyla, çemberin merkezinin çizgi üzerinde olup olmadığı hesaplanır.
                return ((hypot <= c1.R));

            }

            public static bool Cember_Cember(Cember c1, Cember c2)
            {
                float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));       //Çemberlerin merkezleri arasındaki uzaklık hesaplanır

                if ((c1.R + c2.R) > d)
                    return true;
                else
                    return false;
            }

            public static bool Nokta_Küre(Nokta3d p1, Küre da1)
            {
                float d = (float)Math.Sqrt(Math.Pow((p1.X - da1.M.X), 2) + Math.Pow((p1.Y - da1.M.Y), 2) + Math.Pow((p1.Z - da1.M.Z), 2));    // Nokta ve kürenin merkezleri arasındaki mesafe hesaplanır.

                if (d <= da1.R)
                    return true;
                else
                    return false;
            }

            public static bool Nokta_Silindir(Nokta3d p1, Silindir s1)
            {
                float d = (float)Math.Sqrt(Math.Pow((p1.X - s1.M.X), 2) + Math.Pow((p1.Y - s1.M.Y), 2) + Math.Pow((p1.Z - s1.M.Z), 2));   // Nokta ve silindirin merkezleri arasındaki mesafe hasaplanır

                if (d <= s1.R)
                    return true;


                // Noktanın silindir üst veya alt diskinde olup olmadığı kontrol edilir.
                var d1 = Math.Abs(p1.Y - s1.M.Y);
                if (d1 <= s1.R && d1 <= s1.H / 2)
                    return true;
                else
                    return false;

            }
            public static bool Silindir_Silindir(Silindir s1, Silindir s2)
            {
                var d = Math.Sqrt(Math.Pow((s1.M.X - s2.M.X), 2) + Math.Pow((s1.M.Y - s2.M.Y), 2) + Math.Pow((s1.M.Z - s2.M.Z), 2));      //Merkezleri arasındaki mesafe hesaplanır

                if (d > s1.R + s2.R)
                    return false;
                else
                {
                    if (Math.Abs(s2.M.Z - s1.M.Z) > s1.H / 2)
                        return false;
                    else
                        return true;
                }
            }

            public static bool Küre_Küre(Küre da1, Küre da2)
            {
                var d = Math.Sqrt(Math.Pow((da1.M.X - da2.M.X), 2) + Math.Pow((da1.M.Y - da2.M.Y), 2) + Math.Pow((da1.M.Z - da2.M.Z), 2));

                if (da1.R + da2.R >= d)
                    return true;
                else
                    return false;

            }

            public static bool Küre_Silindir(Küre da1, Silindir s1)
            {
                float distX = Math.Abs(s1.M.X - da1.M.X);
                float distY = Math.Abs(s1.M.Y - da1.M.Y);
                float distZ = Math.Abs(s1.M.Z - da1.M.Z);

                if (distX > (s1.R + da1.R) || distZ > (s1.R + da1.R) || distY > (s1.H / 2 + da1.R))
                    return false;
                else if (distX <= s1.R || distZ <= s1.R)
                    return true;
                else
                {
                    var d = Math.Pow((distX - s1.R), 2) + Math.Pow((distZ - s1.R), 2);
                    if (d <= (da1.R * da1.R - distY * distY))
                        return true;
                    else
                        return false;

                }
            }
            public static bool Küre_Prizma(Küre da1, Dikdörtgen__Prizma pr1)
            {
                // Kürenin merkezi ile prizmanın kenarları arasındaki uzaklıklar hesaplanır ve kürenin prizmaya en yakın noktası bulunur.
                if (da1.M.X + da1.R < pr1.M.X - pr1.W / 2 ||
                    da1.M.X - da1.R > pr1.M.X + pr1.W / 2 ||
                    da1.M.Y + da1.R < pr1.M.Y - pr1.H / 2 ||
                    da1.M.Y - da1.R > pr1.M.Y + pr1.H / 2 ||
                    da1.M.Z + da1.R < pr1.M.Z - pr1.D / 2 ||
                    da1.M.Z - da1.R > pr1.M.Y + pr1.D / 2)
                    return false;      // Küre dikdörtgen prizmanın sınırları dışındadır,çarpışma yok
                else
                    return true;
            }

            public static bool Prizma_Prizma(Dikdörtgen__Prizma pr1, Dikdörtgen__Prizma pr2)
            {
                // x,y,z koordinatlarının min ve max değerleri hesaplaanır

                float p1_xmin = pr1.M.X - pr1.W / 2;
                float p1_xmax = pr1.M.X + pr1.W / 2;
                float p1_ymin = pr1.M.Y - pr1.H / 2;
                float p1_ymax = pr1.M.Y + pr1.H / 2;
                float p1_zmin = pr1.M.Z - pr1.D / 2;
                float p1_zmax = pr1.M.Z + pr1.D / 2;

                float p2_xmin = pr2.M.X - pr2.W / 2;
                float p2_xmax = pr2.M.X + pr2.W / 2;
                float p2_ymin = pr2.M.Y - pr2.H / 2;
                float p2_ymax = pr2.M.Y + pr2.H / 2;
                float p2_zmin = pr2.M.Z - pr2.D / 2;
                float p2_zmax = pr2.M.Z + pr2.D / 2;

                //Koordinatların sınırlar içinde olup olmadığı denetlenir

                if (p1_xmin <= p2_xmax && p1_xmax >= p2_xmin &&
                    p1_ymin <= p2_ymax && p1_ymax >= p2_ymin &&
                    p1_zmin <= p2_zmax && p1_zmax >= p2_zmin)
                    return true;
                else
                    return false;

            }
        }



        public static class Veri_Alma
        {
            public static Nokta Nokta_Veri()
            {
                Console.WriteLine("Noktanın x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Noktanın y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());

                return new Nokta(x, y);
            }

            public static Nokta3d nokta3D_Veri()
            {
                Console.WriteLine("Noktanın x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Noktanın y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Noktanın z koordinatını giriniz.");
                int z = int.Parse(Console.ReadLine());
                return new Nokta3d(x, y, z);
            }


            public static Dikdörtgen Dikdörtgen_Veri()
            {
                Console.WriteLine("Dikdörtgenin x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin yükseklik değerini giriniz.");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin genişlik değerini giriniz");
                int h = int.Parse(Console.ReadLine());

                return new Dikdörtgen(new Nokta(x, y), w, h);
            }

            public static Cember Cember_Veri()
            {
                Console.WriteLine("Çemberin x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Çemberin y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Çemberin yarıçap değerini giriniz.");
                int r = int.Parse(Console.ReadLine());

                return new Cember(new Nokta(x, y), r);
            }

            public static Silindir Silindir_Veri()
            {
                Console.WriteLine("silindirin x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("silindirin y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("silindirin z koordinatını giriniz.");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("silindirin yarıçap değerini giriniz.");
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine("Silindirin yükseklil değerini giriniz.");
                int h = int.Parse(Console.ReadLine());
                return new Silindir(new Nokta3d(x, y, z), r, h);
            }

            public static Dikdörtgen__Prizma Prizma_Veri()
            {
                Console.WriteLine("Prizmanın x koordinatını giriniz.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın y koordinatını giriniz.");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın z koordinatını giriniz.");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın yükseklik değerini giriniz.");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın genişlik değerini giriniz.");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın derinlik değerini giriniz.");
                int d = int.Parse(Console.ReadLine());

                return new Dikdörtgen__Prizma(new Nokta3d(x, y, z), w, h, d);

            }

            public static Küre Küre_Veri()
            {
                Console.WriteLine("Kürenin merkezinin x koordinatını giriniz:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Kürenin merkezinin  y koordinatını giriniz:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Kürenin merkezinin z koordinatını giriniiz:");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("Kürenin yarıçap değerini giriniz:");
                int r = int.Parse(Console.ReadLine());

                return new Küre(new Nokta3d(x, y, z), r);
            }
        }  



        }
    }

