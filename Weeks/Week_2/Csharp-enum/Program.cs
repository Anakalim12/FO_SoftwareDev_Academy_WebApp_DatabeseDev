namespace Csharp_enum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);

        int sicaklik = 32;

        if(sicaklik <= (int)HavaDurumu.Normal)
        {
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
        }
        else if(sicaklik>= (int)HavaDurumu.Sıcak)
        {
            Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
        }
        else if(sicaklik >=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak)
        {
            Console.WriteLine("Hadi dışarıya çıkalım");
        }
    }
}

enum Gunler
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soğuk = 5,

    Normal = 20,

    Sıcak = 25,

    CokSıcak = 30
}
