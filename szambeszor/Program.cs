using System;

namespace szambeszor
{
    class Program
    {
        static void Main(string[] args)
        {
            string megint;
            bool nemjo = false;
            int a=0, b=0;
            do
            {
                do
                {
                    nemjo = false;
                    Console.WriteLine("Kérlek add meg a szorzat első számát:!");
                    try
                    {
                        
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nem számot adtál meg!");
                        nemjo = true;
                    }
                }
                while (nemjo);
                do
                {
                    nemjo = false;
                    Console.WriteLine("Kérlek add meg a szorzat második számát:!");
                    try
                    {

                        b = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nem számot adtál meg!");
                        nemjo = true;
                    }
                }
                while (nemjo);
                Console.WriteLine("A két szám összeszorozva: {0}", a * b);
                Console.WriteLine("Mégegyszer? (i/n):");
                megint = Console.ReadLine();
            }
            while (megint == "i");
            
        }
    }
}
