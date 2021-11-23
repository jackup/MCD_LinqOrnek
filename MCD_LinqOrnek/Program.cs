﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LinqOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq --> Language Integrated Query (Dil Entegre Edilmiş Sorgu)

            int[] sayilar = new int[] { 0, -2, 1, 3, 33, 44, 50, 101 };

            var tekler = from s in sayilar where s % 2 != 0 select s;
            Console.WriteLine("Sayılar dizisindeki tek sayılar aşağıdaki gibidir.");
            foreach (var item in tekler)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("\n");

            //2. Yöntem = Tek Satırda Linq
            var ciftler = sayilar.Where(x => x % 2 == 0);
            Console.WriteLine("Sayılar dizisindeki çift sayılar aşağıdaki gibidir.");
            foreach (var item in ciftler)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("\n");
            //Sıfırdan büyük olan çift sayıları getirsin.

            ciftler.ToList().ForEach(x =>
            {
                if (x > 0)
                {
                    Console.Write(x + "\t");
                }
            });
        }
    }
}
