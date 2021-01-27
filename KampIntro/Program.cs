using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.46;
            double dolarBugun = 7.45;
            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Düşüş oku");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }







            bool sistemeGirisYapmismi = false;
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
