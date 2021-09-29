using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("sisesta oma kasutajatunnus");
                string kasutajatunnus = Console.ReadLine();
                Console.WriteLine("sisesta oma parool");
                string parool = Console.ReadLine();

                if (kasutajatunnus != "admin" || parool != "admin1234")
                {
                    Console.WriteLine("Vale kasutajatunnus või parool. proovi uuesti");
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("tere tulemast!");
                }
            }


        }
    }
}
