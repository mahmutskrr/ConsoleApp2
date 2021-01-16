using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class sepetmanager
    {
        //naming convention
        //synyax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi"+urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("tebrikler. sepete eklendi : " + urunAdi);

        }
    }
}
