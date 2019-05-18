using System;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Srie ceva aici :");
            string readed= Console.ReadLine();

            Console.WriteLine($"Esti : {readed}");
            string myString = @"\new";
            Console.WriteLine(myString);
            bool? specified = true;
            if(specified.HasValue && specified.Value)
            {
                Console.WriteLine("specified");
            }
            var a = specified;
            long large = 23232333;
                int small = (int)large;
            Console.WriteLine(a);


        }
    }
}
