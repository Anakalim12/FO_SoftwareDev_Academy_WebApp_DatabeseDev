namespace Case_1;
class Program
{
    static void Main(string[] args)
    {
        //Case_1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        Console.WriteLine("Lütfen dizi boyutu için bir sayı giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[n];
        Console.WriteLine("Lütfen " + n + " adet sayı girişi yapınız:");
        Console.WriteLine("Girilen sayılar 0'dan büyük olmalıdır!");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]= Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girdiğiniz sayılardan çift olanlar:");
        foreach (int sayi in dizi)
        {
            if (sayi %2 == 0){
                
                Console.WriteLine(sayi);
            }
        }


        //Case_2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (k, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        Console.WriteLine("İki adet sayı girişi yapınız");
        Console.Write("k:");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[] sayilar = new int[k];
        Console.WriteLine(k+" adet sayı girişi yapınız");
        Console.WriteLine("Girilen sayılar pozitif sayı olmalıdır!");
        for (int i = 0; i < k; i++)
        {
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girilen sayılardan " +m + "'e eşit yada tam bölünen sayılar:");
        foreach (int sayi in sayilar)
        {
            if(sayi == m || sayi%m==0){
                Console.WriteLine(sayi);
            }
        }


        //Case_3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (p). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("Lütfen bir sayı giriniz p:");
        int p = Convert.ToInt32(Console.ReadLine());
        string[] kelimeler = new string[p];
        Console.WriteLine(p +" adet kelime girişi yapınız:");
        for (int i = 0; i < p; i++)
        {
            Console.Write("Kelime "+(i+1)+":");
            kelimeler[i] = Console.ReadLine();
            Console.WriteLine();
        }
        Console.WriteLine("Girilen kelimeler sondan başa doğru:");
        Array.Reverse(kelimeler);
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        } 


        //Case_4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.WriteLine("Lütfen bir cümle yazınız:");
        string sentence = Console.ReadLine();
        
            
        string s1 = sentence.Replace(","," ");
        string s2 = s1.Replace("."," ");
        string s3 = s2.Replace(";"," ");
        string s4 = s3.Replace("*"," ");
        string s5 = s4.Replace("-"," ");
        string s6 = s5.Replace("_"," ");
        string s7 = s6.Replace("?"," ");    
        string s8 = s7.Replace("!"," ");
        string s9 = s8.Replace(" ","");    

        string[] words = s8.Split(" ");

        words = words.Where(val => val != " ").ToArray();
        
        foreach (var item in words)
        {
            Console.WriteLine(item);        
        }
        Console.WriteLine("Girilen cümledeki kelime sayısı: "+words.Length);
        Console.WriteLine("Girilen cümledeki harf sayısı: "+s9.Length);
    }
}
