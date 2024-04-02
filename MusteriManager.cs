using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        List<Musteri> _musteriList;

        public MusteriManager(List<Musteri> musteriList)
        {
            _musteriList=musteriList;
        }

        public MusteriManager()
        {
        }

        public void Add(List<Musteri>musteriler)
        { 
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine(m.MusteriAd+": İsimli Müşteri Başarılı Bir Şekilde Eklenmiştir.");
            }
        }
        public void List(List<Musteri> musteriler)
        {
            foreach (Musteri m in musteriler)
            {                
                Console.WriteLine("Id : "+m.MusteriId);
                Console.WriteLine("İsim :"+m.MusteriAd);
                Console.WriteLine("Soyisim : "+m.MusteriSoyad);
            }
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silinmiştir!");
            //Musteri musteriToDelete = _musteriList.SingleOrDefault(md => md.MusteriId==musteri.MusteriId);
            //_musteriList.Remove(musteriToDelete);

        }


    }
}
