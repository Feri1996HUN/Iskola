using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace beolvasasfeladat1
{
    public class Barat
    {
        private string nev;
        private DateTime szuldat;
        private string nem;
        private int bulihajl;

        public Barat() {

        }
        public void setnev(string nev)
        {
            this.nev = nev; 
        }
        public void setszuldat(DateTime szuldat)
        {
            this.szuldat = szuldat;
        }
        public void setnem(string nem)
        {
            this.nem = nem;
        }
        public void setbulihajl(int bulihajl)
        {
            this.bulihajl = bulihajl;
        }
        public string getnev()
        {
            return nev;
        }
        public DateTime getszuldat()
        {
            return szuldat;
        }
        public string getnem()
        {
            return nem;
        }
        public int getbulihajl()
        {
            return bulihajl;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool ertek = true;
            string adat="";
            int i;
            ArrayList lista = new ArrayList();
            List < Barat > baratlista = new List<Barat>();
            //Olvasás
            StreamWriter iras = new StreamWriter("adat.txt", true, Encoding.UTF8);


            do
            {

                adat = "";
                for (i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Add meg a neved: ");
                            break;
                        case 1:
                            Console.WriteLine("Add meg a születési dátumod: ");
                            break;
                        case 2:
                            Console.WriteLine("Add meg a nemed: ");
                            break;
                        case 3:
                            Console.WriteLine("Add meg  a bulizási hajlamod: ");
                            break;
                        default:
                            break;
                    }
                    adat = Console.ReadLine();
                    if (adat == "")
                    {
                        ertek = false;
                        break;
                    }
                    else
                    {
                        iras.Write(adat + ";");
                        if(i == 0)
                        {
                            Barat barat = new Barat();
                            barat.setnev(adat);
                        }
                        if (i == 1)
                        {
                            barat.setszuldat(adat);
                        }


                    }
                }
                iras.WriteLine(" ");
            } while (ertek);

            iras.Close();

            //Beolvasás

            StreamReader olvas = new StreamReader("adat.txt");
            
            while(adat != null)
            {
                adat = olvas.ReadLine();
                lista.Add(adat);
            }
            olvas.Close();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
