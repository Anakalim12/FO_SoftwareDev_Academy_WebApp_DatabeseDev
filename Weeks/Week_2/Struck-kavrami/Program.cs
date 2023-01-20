namespace Struck_kavrami;
class Program
{
    static void Main(string[] args)
    {
        Dikdörtgen dikdörtgen = new Dikdörtgen();
        dikdörtgen.KisaKenar = 3;
        dikdörtgen.UzunKenar = 4;
        Console.WriteLine("Class Alan Hesabı    :{0}",dikdörtgen.AlanHesapla());

        Dikdörtgen_Struct dikdörtgen_struct;
        dikdörtgen_struct.KisaKenar = 3;
        dikdörtgen_struct.UzunKenar = 4;

        Console.WriteLine("Struct Alan Hesabı    :{0}",dikdörtgen_struct.AlanHesapla());
    }
}

class Dikdörtgen
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdörtgen(){
        KisaKenar = 3;
        UzunKenar = 4;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

struct Dikdörtgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdörtgen_Struct(){
        KisaKenar = 3;
        UzunKenar = 4;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }  
}
