using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç sınıfı inceleme

            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            //A1.Fiyat=Kapsülleme konusu
            A1.FiyatAta(31000);
            A1.Fiyat = 35000;
            A1.BilgileriGoruntule();

            #endregion

            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("18893437830", "Gamze");
            M1.TcKimlikNo = "18893437831";
            M1.Isim = "Cengiz";
            M1.Soyisim = "Atilla";
            M1.Cinsiyet = 717770001;


            Musteri M2 = M1;
            M2.Isim = "Murat";
            M2.TcKimlikNo = "18893437832";
            bool musteriKontrol = M2.MusteriKontrol();
            Console.WriteLine(musteriKontrol);

            //M2 = null;
            //M1 = null;

            string isim = M2.Isim;
            //Customer M3 = new Customer();

            //classlardan nesne bu şekilde new kelimesi ile türetilir. 

            //so, a class is a template for object, and an object is an instance of a class.

            Fruit meyve1 = new Fruit();
            meyve1.fruitname = "Bu bir Elmadır.";
            meyve1.meyverengi = "kırmızı";
            meyve1.olusturulmatarihi = DateTime.Now;

            Console.WriteLine(meyve1.fruitname);
            Console.WriteLine(meyve1.meyverengi);
            Console.WriteLine(meyve1.olusturulmatarihi);

            Fruit meyve2 = new Fruit();
            meyve2.fruitname = "Bu bir Çilektir.";
            meyve2.meyverengi = "pembe";
            meyve2.olusturulmatarihi = DateTime.Now;

            Console.WriteLine(meyve2.fruitname);
            Console.WriteLine(meyve2.meyverengi);
            Console.WriteLine(meyve2.olusturulmatarihi);

            Fruit meyve3 = new Fruit();
            Console.WriteLine(meyve3.fruitname);
            Console.WriteLine(meyve3.meyverengi);

            Console.ReadLine();
        }
    }

    //class Customer
    //{

    //}
}
