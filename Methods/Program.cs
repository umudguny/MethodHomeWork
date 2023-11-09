using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product();// Class olduğu için new'lememiz gerekiyo
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[]products = new Product[] {product1,product2};
            //type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-------------");
            }


            Console.WriteLine("--------Methods---------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);//metotu çagırdık.
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 12,8);
            



            Console.ReadLine();
        }

    }
}

// Dont repeat yourself - DRY - Clean Code
