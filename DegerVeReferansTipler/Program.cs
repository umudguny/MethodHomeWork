using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            // değer tip oldugu için sayi1 30dur

            int[] sayi1lar1=new int[] {10,20,30};
            int[] sayi1lar2=new int[] {100,200,300};
            sayi1lar1 = sayi1lar2;
            sayi1lar2[0] = 999;
            Console.WriteLine(sayi1lar1[0]);
            //referans tip oldugu için sayilar1 999dur
        }
    }
}
