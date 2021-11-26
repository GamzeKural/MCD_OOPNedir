using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYıl;
        public decimal Km;
        public int YakitTip;
        public int VitesTip;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;


        public Arac()
        {}

        public Arac(string _marka,string _model)
        {
            Marka = _marka;
            Model = _model;

        }

        public Arac(string _marka,string _model,int _modelYil)
        {
            Marka = _marka;
            Model = _model;
            ModelYıl = _modelYil;
        }

        public Arac(string _marka, string _model, int _modelYil,decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYıl = _modelYil;
            Km = _km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yil {2}",Marka,Model,ModelYıl);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi.");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi.");
            }

        }
    }
}
