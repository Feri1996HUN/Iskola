using System;
using System.Collections;
using System.IO;
using System.Text;

namespace beolvasasfeladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ertek = false;
            string adat="";
            int i;
            ArrayList lista = new ArrayList();
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
            
        }
    }
}
