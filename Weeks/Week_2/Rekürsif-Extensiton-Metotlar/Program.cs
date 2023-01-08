namespace Rekürsif_Extensiton_Metotlar;
class Program
{
    static void Main(string[] args)
    {
        //Rekürsif - öz yinelemeli 
        //3^4 = 3*3*3*3
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));

        //Extension metotlar
        string ifade = "Mesut SARA";
        bool sonuc = ifade.CheckSpace();
        Console.WriteLine(sonuc);
        if(sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi ={9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter());

    }
}
public class Islemler
{
    public int Expo(int number, int power)
    {
        if(power<2){
            return number;
        }
        return Expo(number,power-1) * number;
    }
    //Expo(3,4)
    //Expo(3,3) *3;
    //Expo(3,2) *3 *3;
    //Expo(3,1) *3*3*3;
    // 3 *3*3*3 = 3^4;
}

//Extension metotlar static olmalı
public static class Extension
{
    public static bool CheckSpace(this string Param)
    {
        return Param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string Param)
    {
        string[] dizi = Param.Split(" ");
        return string.Join("*",dizi);
    }

    public static string MakeUpperCase(this string Param){
        return Param.ToUpper();
    }
    public static string MakeLowerCase(this string Param){
        return Param.ToLower();
    }
    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param){
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param){
        return param/2 == 0;
    }

    public static string GetFirstCharacter(this string param){
        return param.Substring(0,1);
    }
}
