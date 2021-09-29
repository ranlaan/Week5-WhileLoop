using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-kood
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN on 1234
            //programm kuvab "tere tulemast"
            //kui sisestatud PIN on vale kuvab programm "PIN on vale, proovi uuesti"
            //*kasutajal on kolm katset

            int i = 0;
            
            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN: ");
                int UserPin = Convert.ToInt32(Console.ReadLine());

                if (UserPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"vale pin. {3 - i} katset on jäänud");
                }
            }

            Console.WriteLine("Kena päeva jätku");





        }
    }
}
