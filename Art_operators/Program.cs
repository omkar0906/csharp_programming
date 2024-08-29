using System;

namespace Art_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("arithmetic operators");
            Console.WriteLine(a + b);   //addition
            Console.WriteLine(a - b);   //subtraction
            Console.WriteLine(a * b);   //multiplication
            Console.WriteLine(a / b);   //division
            Console.WriteLine(a % b);   //modulus
            Console.WriteLine(a++);     //increment by 1
            Console.WriteLine(a--);     //decrement by 1

            Console.WriteLine("--------------");

            // assignments operators 
            Console.WriteLine("assignment operator");
            int c = 0;
            Console.WriteLine(c);   //assign
            c += 6;                 //adding 3 on assign
            Console.WriteLine(c);
            c -= 3;                 //subtracting and assign
            Console.WriteLine(c);
            c ^= 3;                 // XOR
            Console.WriteLine(c);

            Console.WriteLine("--------------");

            Console.WriteLine("comparision operator");
            int test1 = 10;
            int test2 = 20;
            Console.WriteLine(test1 == test2);  //comparism checks equal or not
            Console.WriteLine(test2 == test1);  
            Console.WriteLine(test2 != test1);  // not equal to
            Console.WriteLine(test1 > test2);   // greater than
            Console.WriteLine(test1 < test2);   // less than
            Console.WriteLine(test1 >= test2);  // greater than equal to
            Console.WriteLine(test1 <= test2);  // lower than equal to

            Console.WriteLine("--------------");

            Console.WriteLine("logical operator");
            Console.WriteLine(test1 > 10 && test2 < 30);    // logical and
            Console.WriteLine(test1 > 10 || test2 < 30);    // logical or
            Console.WriteLine(!(test2 < 10));               // logical not
        }
    }
}
