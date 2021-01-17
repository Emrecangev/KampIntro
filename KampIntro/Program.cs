using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Katagori ";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;

            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu ");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
