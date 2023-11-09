using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + product.Adi);
        }
        public void Ekle2(string productName,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + productName);
        }
    }
}
