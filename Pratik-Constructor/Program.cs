using Pratik_Constructor;

public class Program
{
    public static void Main()
    {
        // Parametresiz constructor ile bebek oluşturma
        Bebek bebek1 = new Bebek();
        bebek1.Ad = "Sabri";
        bebek1.Soyad = "Sarıoğlu";
        Console.WriteLine("-----Bebek 1-----");
        bebek1.Bilgiler();

        // Parametreli constructor ile bebek oluşturma
        Bebek baby2 = new Bebek("Rıdvan", "Dilmen");
        Console.WriteLine("-----Bebek 2-----");
        baby2.Bilgiler();
    }
}

