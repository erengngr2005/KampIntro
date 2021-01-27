using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int dolarDun = 7;
            int dolarBugun = 6;
            string artis = (dolarDun < dolarBugun)? "Dolar Yükselmiş" : "Dolar Düşmüş";
            Console.WriteLine(artis);
        }
    }
}
