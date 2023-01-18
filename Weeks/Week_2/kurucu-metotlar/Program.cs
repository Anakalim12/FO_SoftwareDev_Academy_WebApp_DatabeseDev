namespace kurucu_metotlar;
class Program
{
    static void Main(string[] args)
    {
        //söz dizini
        //class SinifAdi
        //{
        //   [Erişim belirleyici] [veri tipi]   özellikAdı;
        //     [Erişim belirleyici][geri dönüş tipi]MetotAdi([parametre listesi])
            //{
                //Metot komutları
            //}
        //}

        //Erişim belirleyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected

        Calisan calisan1 = new Calisan("Ayşe","Kara",2345634,"İnsan Kaynakları");
        

        calisan1.CalisanBilgileri();

        Console.WriteLine("***************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No =25646789;
        calisan2.Departman = "Satın Alma";

        calisan2.CalisanBilgileri();

        Console.WriteLine("***************");
        Calisan calisan3 = new Calisan("Ayşe","Kara");
        calisan3.CalisanBilgileri();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;


    public Calisan(string ad, string soyad,int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(){}

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0}",Ad);
        Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
        Console.WriteLine("Çalışan Numarası: {0}",No);
        Console.WriteLine("Çalışan Departman: {0}",Departman);
    }
}
