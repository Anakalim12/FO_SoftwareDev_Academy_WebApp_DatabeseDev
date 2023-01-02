using System;
namespace donguler_for_loop;
class Program
{
    static void Main(string[] args)
    {
        // //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırma
        // Console.WriteLine("Lütfen bir sayı giriniz: ");
        // int sayac = int.Parse(Console.ReadLine());
        // for (int i = 0; i <= sayac; i++)
        // {
        //     //komutlar
        //     if (i%2 == 1)
        //     {
        //         Console.WriteLine(i);
        //     }

        // }

        // //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
        // int tekToplam = 0;
        // int ciftToplam = 0;
        // for (int i = 0; i <= 1000; i++)
        // {
        //     if (i%2 == 1)
        //     {
        //         tekToplam += i; //tekToplam = tekToplam + i;
        //     }
        //     else
        //     {
        //         ciftToplam += i; //ciftToplam = ciftToplam + i;
        //     }
        // }
        // Console.WriteLine("Tek Toplam: "+tekToplam);
        // Console.WriteLine("Çift Toplam: "+ciftToplam);
    
        //break, continue

        for (int i = 0; i < 10; i++)
        {
            if (i ==4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
         for (int i = 0; i < 10; i++)
        {
            if (i ==4)
            {
                break;
            }
            Console.WriteLine(i);
        }
    
    
    }
}
