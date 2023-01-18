
using System.Collections;

namespace Koleksiyonlar_2;
class Program
{
    static void Main(string[] args)
    {
        // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        ArrayList inputNumbers = new ArrayList();
        ArrayList enBuyuk = new ArrayList();
        ArrayList enKucuk = new ArrayList();

        Console.WriteLine("20 adet pozitif sayı girişi yapınız: ");
        for(int i=0; i<20; i++){
            Console.WriteLine("Sayı "+(i+1)+":");
            try
            {
                int a = (Int32.Parse(Console.ReadLine()));
                if(a <0){
                    throw new ArgumentException();
                    
                }
                else{
                    inputNumbers.Add(a);
                }                 
            }
            catch (System.Exception){
                Console.WriteLine("Girilen değer sayı değil / Girilen değer pozitif değil");
                i--;
            }             
        }
        inputNumbers.Sort();
        for (int i = 0; i < 3; i++)
        {
            enKucuk.Add(inputNumbers[i]);
        }
        for (int i = inputNumbers.Count-1; i > inputNumbers.Count-4; i--)
        {
            enBuyuk.Add(inputNumbers[i]);
        }
        int enBuyukToplam = 0;
        int enKucukToplam = 0;
        Console.WriteLine("************** Girilen sayıların en büyük 3 tanesi ");
        foreach (int item in enBuyuk)
        {
            enBuyukToplam+=item;
            Console.WriteLine(item);
        }
        Console.WriteLine("En büyük 3 sayının ortalaması: "+(enBuyukToplam/3));



        Console.WriteLine("************** Girilen sayıların en küçük 3 tanesi ");
        foreach (int item in enKucuk)
        {
            enKucukToplam+=item;
            Console.WriteLine(item);
        }
        Console.WriteLine("En küçük 3 sayının ortalaması: "+(enKucukToplam/3));

        Console.WriteLine("Ortalamalar toplamı: "+((enKucukToplam/3)+(enBuyukToplam/3)));

    }
}
