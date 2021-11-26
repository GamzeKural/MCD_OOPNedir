using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Musteri
    {
        /*
         * TCKimlik numarası
         * İsim
         * Soyisim
         * Cinsiyet
         */

        //Property - Özellikler

        public string TcKimlikNo;
        public string Isim;
        public string Soyisim;
        public int Cinsiyet; //717770001 : Bay - 717770002 : Bayan

        //Yapıcı Metot Constructor

        public Musteri()
        {
            //TcKimlikNo = "1234567890";

        }

        public Musteri(string _tckimlikno)
        {
            TcKimlikNo = _tckimlikno;
        }

        public Musteri(string _tckimlikno,string _isim)
        {
            TcKimlikNo = _tckimlikno;
            Isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TcKimlikNo = _tckimlikno;
            Isim = _isim;
            Soyisim = _soyisim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim,int _cinsiyet)
        {
            TcKimlikNo = _tckimlikno;
            Isim = _isim;
            Soyisim = _soyisim;
            Cinsiyet = _cinsiyet;
        }

        public Musteri(int _cinsiyet)
        {
            Cinsiyet = _cinsiyet;
        }

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDataBase(TcKimlikNo);
            return true;
        }

        private bool MusteriKontrolDataBase(string tckimlikNumarasi)
        {
            //database gidilir müşterinin tckimliknumarasına göre daha önce kayıt edilip
            //edilmediği bilgisi sorgulanır...
            return true;
        }
    }
}
