 using System;

namespace WCA_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                byte sayi1 = 56;
                sbyte sayi2 = 12;
                short sayi3 = 134;
                ushort sayi4 = 123;
                int sayi5 = 324;
                uint sayi6 = 21432432;
                long sayi7 = 324234;
                ulong sayi8 = 23424;
                float sayi9 = 12.0F;
                double sayi10 = 12.0;
                decimal sayi11 = 12.0M;
                char karakter = 'A';
                string metin = "Bilge Adam Beşiktaş Yazılım Dersler";
                string tekKarakter = "A";

                Console.WriteLine(metin);
                string tabBosluk = "Bilge\tAdam";
                Console.WriteLine(tabBosluk);

                String metin2 = "Bilge Adam Beşiktaş \"Yazılım\" Dersleri ";
                Console.WriteLine(metin2);
                bool result = 10 > 2;
                Console.WriteLine(result);


                Console.ReadKey();






            }
        }
    }
}
