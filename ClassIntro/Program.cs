﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emre";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Emre";
            kurs1.IzlenmeOrani = 35;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Eda";
            kurs2.IzlenmeOrani = 44;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Merve";
            kurs3.IzlenmeOrani = 33;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani + " ");


            //Liste oluşturma

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani  { get; set; }
    }
}
