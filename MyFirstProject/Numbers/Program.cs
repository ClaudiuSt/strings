using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float piFloat = 3.141592653589793238F;
            Console.WriteLine(piFloat);

            double piDouble = 3.141592653589793238;
            Console.WriteLine(piDouble);
            Console.WriteLine("Hello World!");
            decimal piDecimal = 33.141592653589793238M;
            float piFloat = (float)piDeimal;
            Console.WriteLine(piFloat);

            bool isCool = false;
            Console.WriteLine("isCool has the value : {0}, and piDecimal is : {1}", isCool, piDecimal);
            Console.WriteLine($"isCool has the value : {isCool}, and piDecimal is : {piDecimal}");


            Console.WriteLine(isCool);
            int grade = 7;
            if (grade > 5)
            {
                Console.WriteLine("Bravo");
            }
            else
            {
                Console.WriteLine("LA VARA BAIETEL");
            }
        }
    }
}
