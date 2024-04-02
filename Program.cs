using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Musteri>musteriler = new List<Musteri>();
            Musteri musteri1 = new Musteri {MusteriAd="Enes",MusteriSoyad="Sarıhan",MusteriId=1 };
            Musteri musteri2 = new Musteri {MusteriAd="Engin",MusteriSoyad="Demiroğ",MusteriId=2 };
            Musteri musteri3 = new Musteri {MusteriAd="Johnny",MusteriSoyad="Depp",MusteriId=3 };

            musteriler.Add(musteri1);
            musteriler.Add(musteri2);
            musteriler.Add(musteri3);

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteriler);

            musteriManager.List(musteriler);

            musteriManager.Delete(musteri3);
            
            

            Console.ReadKey();
        }
    }
}
