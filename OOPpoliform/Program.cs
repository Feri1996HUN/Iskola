﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace OOPpoliform
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feladat alapeset:
            // Ház, vannak lakók: nők és férfiak, ha becsenget valaki nő v férfi nyit ajtót
            // polimorfizmus példa: mindegy hogy nő v férfi megy kinyitni ugyanazt a metódust használjuk

            // Felépítjük a házat (A ház példányosítása)
            Haz otthon = new Haz();

            // Példányosítjuk a szereplőket
            // Hölgyek
            Woman eva = new Woman("Éva", "zöld");
            Woman kati = new Woman("Kati", "barna");
            Woman sari = new Woman("Sári", "kék");
            Woman zsuzsi = new Woman("Zsuzsi", "zöld");

            // Férfiak
            Ferfi adam = new Ferfi("Ádám", 26);
            Ferfi dani = new Ferfi("Dani", 26);
            Ferfi gergo = new Ferfi("Gergő", 26);
            Ferfi atti = new Ferfi("Attila", 26);

            // Beköltöznek a szereplők a házba
            if (eva is Ember) otthon.hazajon(eva as Ember);
            otthon.hazajon((Ember)kati);
            otthon.hazajon((Ember)sari);
            otthon.hazajon((Ember)zsuzsi);
            otthon.hazajon((Ember)adam);
            otthon.hazajon((Ember)dani);
            otthon.hazajon((Ember)gergo);
            otthon.hazajon((Ember)atti);

            // Jönnek idegenek és csengetnek
            bool tovabb = true;
            do
            {
                otthon.csenget();
                tovabb = (Console.ReadLine() == String.Empty) ? false : true;
            } while (tovabb);

        }
    }

    class Ember
    {
        public string Nev { set; get; }

        private string bemut = "Üdvözlöm, a nevem: ";

        public Ember(string nev)
        {
            Nev = nev;
        }

        public string beszel()
        {
            return(bemut + Nev);
        }
    }

    class Ferfi : Ember
    {
        public int Kor { set; get; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
    }

    class Woman : Ember
    {
        public string SzemSzin { set; get; }
        public Woman(string nev, string szemszin) : base(nev)
        {
            SzemSzin = szemszin;
        }
    }

    class Haz
    {
        private List<Ember> lakok = new List<Ember>();

        public void hazajon(Ember obj)
        {
            this.lakok.Add(obj);
        }

        public void csenget()
        {
            int i;
            Random rd = new Random();
            // Ha vannak a házban, akkor véletlen szerűen kijön valaki és beszél
            if (lakok.Count > 0)
            {
                i = rd.Next(0, lakok.Count - 1);
                Console.WriteLine(lakok[i].beszel());
            }
        }
    }
}
