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
    }
}
