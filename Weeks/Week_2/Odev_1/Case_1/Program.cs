namespace Case_1;
class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
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


        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (k, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
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
    }
}
