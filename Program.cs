using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelirliŞekillerinAlanları
{
    public class Program
    {
        static void Main(string[] args)
        {
            int secim1;
            int secim2;
            Console.WriteLine("Hesaplama Sistemine Hoşgeldiniz :)");
            Console.Write("Ne hesaplamak istiyorsunuz? (Alan için 1 Hacim için 2 yazınız.)");
            
            secim1 = Convert.ToInt32(Console.ReadLine());

            if (secim1 == 1) 
            {
                Console.Write("Hangi cismin alanını hesaplamak istiyorsunuz? (Dikdörtgen için 1 Daire için 2 Üçgen için 3 ü seçiniz.)");
                secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 1)
                {
                    double dikdortgenAlani = HesaplaDikdortgenAlani();
                    Console.WriteLine("Dikdörtgen Alanı = " + dikdortgenAlani);
                }
                else if (secim2 == 2)
                {
                    double daireAlani = HesaplaDaireAlani();
                    Console.WriteLine("Daire Alanı = " + daireAlani);
                }
                else if (secim2 == 3)
                {
                    double ucgenAlani = HesaplaUcgenAlani();
                    Console.WriteLine("Üçgen Alanı = " +  ucgenAlani);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim");
                }
            }
            else if (secim1 == 2)
            {
                Console.Write("Hangi cismin hacmini hesaplamak istiyorsunuz? (Dikdörtgen için 1 Daire için 2 Üçgen için 3 ü seçiniz.)");
                secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 1)
                {
                    double hacim = HesaplaDikdortgenHacmi();
                    Console.WriteLine("Dikdörtgenin Hacmi = " + hacim);
                }
                else if (secim2 == 2)
                {
                    double hacim = HesaplaDaireHacmi();
                    Console.WriteLine("Dairenin Hacmi = " + hacim);
                }
                else if (secim2 == 3)
                {
                    double hacim = HesaplaUcgenHacim();
                    Console.WriteLine("Üçgenin hacmi = " + hacim);
                }

            }
        }

        private static double HesaplaDikdortgenAlani()
        {
            Console.Write("Dikdörtgenin Uzunluğunu giriniz = ");
            double uzunluk = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin Genişliğini giriniz = ");
            double genislik = Convert.ToDouble(Console.ReadLine());

            double alan = uzunluk * genislik;
            return alan;   
        }
        private static double HesaplaDaireAlani()
        {
            Console.Write("Dairenin yarıçapını giriniz = ");
            double yariCap = Convert.ToDouble(Console.ReadLine());

            double alan = Math.PI * Math.Pow(yariCap, 2);
            return alan;
        }
        private static double HesaplaUcgenAlani()
        {
            Console.Write("Üçgenin taban uzunluğunu giriniz = ");
            double taban = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin yüksekliğini giriniz = ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * taban * height;
            return area;
        }
        private static double HesaplaDikdortgenHacmi()
        {
           
            Console.Write("A değerini söyleyiniz = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B değerini söyleyiniz = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("C değerini söyleyiniz = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double V = a * b * c;
            return V;
        }

        private static double HesaplaDaireHacmi()
        {
            Console.Write("Yarıçap giriniz = ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            double hacim = (4.0/3.0)*Math.PI*Math.Pow(yaricap, 3);
            return hacim;
        }
        private static double HesaplaUcgenHacim()
        {
            Console.Write("Taban uzunluğunu giriniz = ");
            double tabanUzunluğu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yükseklik giriniz = ");
            double height = Convert.ToInt32(Console.ReadLine());

            double v = (1.0 / 2.0) * tabanUzunluğu * height;
            return v;
        }
    }
}
