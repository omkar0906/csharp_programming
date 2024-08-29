using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
namespace csharpIntroduction
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            //string name = "LOL";
            string name = "Test1";      //string data type
            char name1 = 'A';           // character type
            const int a = 1;            // int type with constant keyword
            int b = 2;                  // int type 
            double c = 3.1;             // float type for decimanl
            bool isTrue = false;        // boolean type
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello "+name+name1);       //string concatenation
            Console.WriteLine("your rank is "+ a+ " \n -------  \n" + c);
            Console.WriteLine(isTrue);
            name = "lol";
            Console.WriteLine("Hello " + name);
            Console.Write(a+b);
            Console.WriteLine(6 * 6);
        }
    }
}
