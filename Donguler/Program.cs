﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya","Java","Pyhton" };
            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
