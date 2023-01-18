using System.Collections;

namespace Koleksiyonlar_3;
class Program
{
    static void Main(string[] args)
    {
        // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

        ArrayList sesliHarfler = new ArrayList();
        Console.WriteLine("Lütfen bir metin/cümle yazınız");
        string sentence = Console.ReadLine();
        

        foreach (char item in sentence.ToLower())
        {
            if (item == 'a' || item == 'e' || item == 'ı' || item == 'o' || item == 'u' || item == 'i' || item == 'ö' || item == 'ü')
            {
                sesliHarfler.Add(item);
            }
        }
        sesliHarfler.Sort();
        foreach (var item in sesliHarfler)
        {
            Console.WriteLine(item);
        }
        
        
        
    }
}
