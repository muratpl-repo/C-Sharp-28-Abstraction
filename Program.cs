using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72DersAbstractSiniflarveMetotlar
{
    class Program
    {
        //Abstract: Soyut
        abstract class Sekil    // Abstract metotlar sadece abstract siniflarda kullanilabilir
                                // Türev sınıflarının doldurması zorlanır
                                // Virtual'de ise isteğe bağlı override edilebilir..
        {                       // Abstract siniflardan orneklemeler olusturulamaz. Sadece miras alinmasi icin olusturulur...
            public abstract void SekilCiz();
        }

        class Cember : Sekil
        {
            public override void SekilCiz() //Abstract siniflari miras alinca mecburen methotlar, override yapmak gerekir...
            {
                Console.WriteLine("Cember ciziliyor...");
            }
        }

        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.SekilCiz();
        }
    }
}
