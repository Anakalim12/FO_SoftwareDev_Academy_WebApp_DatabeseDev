namespace metotlar;
class Program
{
    static void Main(string[] args)
    {
        // erişim_belirteci geri_dönüştipi metot_adi(oarametreListesi/arguman)
        //{
            //komutlar;
            //return;
        //}
        int a = 2;
        int b = 3;

        Console.WriteLine(a+b);

        int sonuc = Topla(a,b);
        Console.WriteLine(sonuc);

        Metot1 ornek = new Metot1();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
        ornek.EkranaYazdir(Convert.ToString(a+b));
    }

    static int Topla(int deger1, int deger2){

        return (deger1+deger2);
    }
    

}

class Metot1{

    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1 ,ref int deger2){
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}
