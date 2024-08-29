using System;
using System.ComponentModel.DataAnnotations;

namespace type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int my_int = 1;
            double b = my_int + 0.5;        // type casting int to float
            Console.WriteLine(b + "---" + my_int);
            Char al = 'A';
            bool isTrue = false;
            string test = al.ToString();
            Console.WriteLine("char al is : "+ al + "\nstring al is :" + test);     //char to string
            Console.WriteLine(Convert.ToString(al));                                // char to string with new method
            Console.WriteLine(Convert.ToInt32(b));                                  // double to int
            Console.WriteLine(Convert.ToDouble(my_int));                            // int to float/double
            Console.WriteLine(Convert.ToString(isTrue));                            // boolean to string
        }
    }
}
