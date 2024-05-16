using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DeclaringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring integers

            int a = 12;
            int b = 13;
            Console.WriteLine(a + b);

            //declaring Double

            double x = 90.78;
            double y = 34.45;
            Console.WriteLine(x - y);

            //declaring strings

            string firstName = "Wambo ";
            string lastName = "Muiruri";
            Console.WriteLine(firstName + lastName);

            //converting integers to strings using ToString() method

            int s = 15;
            //string t = "Hello ";
            string t = "87";
            string myFirstTry = s.ToString() + t;

            Console.WriteLine(myFirstTry);

            //int mySecondTry = s + t;
            //returning the converted number back to integer
            int mySecondTry = s + int.Parse(t);

            Console.WriteLine(mySecondTry);

            //declaring characters

            char myChar1 ;
            char myChar2 ;
            myChar1 = 'A';
            myChar2 = 'D';
            Console.WriteLine('A' + 'D');
            Console.ReadLine();
            
        }

        


    }
}
