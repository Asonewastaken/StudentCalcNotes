﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Not Ortalamasını Öğrenmek İstediğiniz Öğrencinin Numarasını Giriniz: ");
            string studentNumber = Console.ReadLine();

            Ogrenci ogr1 = new Ogrenci(studentNumber);

            Console.Write("Vize notunu giriniz: ");


            ogr1.vize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final notunu giriniz: ");
            ogr1.final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(string.Format("{0} nolu öğrencinin ortalaması: {1} Harf notu: {2}",
                                             ogr1.OgrenciNumarasi(),
                                             ogr1.OrtalamaBul(),
                                             ogr1.HarfNotuBul()));



            Console.ReadLine();
        }
    }
}
