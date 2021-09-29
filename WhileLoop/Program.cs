using System;

namespace WhileLoop
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
            //*katstete arv on piiramatu

            //boolean --> true/false
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN: ");
                int UserPin = Convert.ToInt32(Console.ReadLine());

                if(UserPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("vale pin, proovi uuesti");
                }
            }

            Console.WriteLine("Kena päeva jätku");




        }
    }
}
