using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Fruit
    {
        /*
         * Class: Sınıf demektir. Nesneyi ifade eder.Csharpta classlar bir namespace içinde
         * olmalıdır.Herhangi bir erişim belirleyicisi almazsa class default olarak INTERNAL
         * seviyededir.
         * Private: özel
         * Public: genel
         * Internal: sadece bulunduğu projede yani bulunduğu namespace ulaşılabilir. 
         * classlar içinde metotlar barındırabilir.
         * classlar içinde özellikler barındırabilir.
         * 
         * Özellik Property-->ingiliz anahtarı
         * Property nasıl yazılır?
         * Erişim belirleyicisi tip propertyadı {get;set;}
         * 
         */

        public string fruitname { get; set; }
        public string meyverengi { get; set; }
        public DateTime olusturulmatarihi { get; set; } = DateTime.Now;


        

    }
}
