using Hello2.myfolder;
using System;
using HelloWorld;


namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET!");
            Console.WriteLine("Cool C@");
            Console.Write("linieeeeee");
            var myclass = new MyClass();
            var emptyClass = new Empty();
            var myClass2 = new Hello2.myfolder.MyClass();
        }
    }
}
