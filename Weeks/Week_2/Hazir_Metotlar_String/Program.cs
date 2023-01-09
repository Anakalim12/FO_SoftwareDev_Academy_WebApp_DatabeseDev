namespace Hazir_Metotlar_String;
class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";
        //Lenght
        Console.WriteLine(degisken.Length);

        //ToUpper , ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(String.Concat(degisken," Merhaba"));

        //Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2));

        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine(degisken.EndsWith("Merhaba!"));

        //IndexOf - Bulamazsa -1 dönüyor
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("Mesut"));
        
        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba! "));
        //LastIndexOf
        Console.WriteLine(degisken.LastIndexOf("i"));

        //PadLeft, PadRight;
        Console.WriteLine(degisken + degisken2.PadLeft(50)); //Soluna parametre olarak verilen karakter sayısına kadar boşluk tanımlar
        Console.WriteLine(degisken + degisken2.PadLeft(50,'*'));
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2.PadLeft(50,'*'));
        Console.WriteLine(degisken.PadRight(50,'*') + degisken2.PadLeft(50,'*'));

        //Remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));
        

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));
    }
}
