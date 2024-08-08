using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Constructor
{
    public class Bebek
    {
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;

        //Default constructor. Parametre almayan bir metot.
        public Bebek()
        {
            Console.WriteLine("Ingaa!");
            DogumTarihi = DateTime.Now;
        }
        // Ad ve Soyad parametreli constructor
        public Bebek(string _ad, string _soyad)
        {
            Ad = _ad;
            Soyad = _soyad;
            Console.WriteLine("\nIngaa!");
            DogumTarihi = DateTime.Now;
        }

        //Bebeğin bilgilerini yazdıram metot.
        public void Bilgiler()
        {
            Console.WriteLine("Doğum tarihi: " + DogumTarihi);
            Console.WriteLine("Adı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
        }
    }
}
