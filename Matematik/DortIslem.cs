using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam=sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cıkar(int sayi1,int sayi2)
        {
            int cıkarma=sayi1 - sayi2;
            Console.WriteLine(cıkarma);
        }
        public void Carp(int sayi1,int sayi2)
        {
            int carp = sayi1 - sayi2;
            Console.WriteLine(carp);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bolum = sayi1 - sayi2;
            Console.WriteLine(bolum);
        }

    }
}
