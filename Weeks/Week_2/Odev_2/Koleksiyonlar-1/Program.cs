using System.Collections;


namespace Koleksiyonlar_1;
class Program
{
    static void Main(string[] args)
    {
        //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

        ArrayList inputNumbers = new ArrayList();
        ArrayList asal = new ArrayList();
        ArrayList nonAsal = new ArrayList();

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
        foreach (int item in inputNumbers)
        {
            if(item.asalMi()){
                asal.Add(item);         

            }
            else
            {
                nonAsal.Add(item);
            }
        }
        asal.Sort();
        asal.Reverse();
        nonAsal.Sort();
        nonAsal.Reverse();
        int asalToplam = 0;
        int nonAsalToplam = 0;
        Console.WriteLine("***************** Asal Sayılar ********************");
        
        foreach (int item in asal)
        {
            asalToplam += item;
            Console.WriteLine(item);
        }
        Console.WriteLine("Toplam girilen asal sayılar:" + asal.Count);
        Console.WriteLine("Asal Sayı ortalaması:" + (asalToplam/asal.Count));
        Console.WriteLine("***************** Asal Olmayan Sayılar ********************");
        foreach (int item in nonAsal)
        {
            nonAsalToplam += item;
            Console.WriteLine(item); 
        }
        Console.WriteLine("Toplam girilen asal olmayan sayılar:" + nonAsal.Count);
        Console.WriteLine("NonAsal Sayı ortalaması:" + (nonAsalToplam/nonAsal.Count));

    }
}

public static class Extensions{
    public static bool asalMi(this int a){
        int i =2;
        bool sonuc = true;
        while(i<a){
            if(a ==1 || a == 2){
                return sonuc;
            }
            else if(a%i == 0){
                sonuc = false;
                return sonuc;
            }
            i++;
        }
        return sonuc;          
    }
}

