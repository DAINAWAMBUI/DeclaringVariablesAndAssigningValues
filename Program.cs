using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
namespace conditionalstatement

    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is how you will be ranked  in you end of semester exams A , B , C or FAIL");
            string userValue = Console.ReadLine();

            string message = " ";

            if (userValue == "A")

                message = "Excellent! Keep it up!";


            else if (userValue == "B")
            {
                message = "Good Work";
            }
            else if (userValue == "C")

                message = "Average";
            else 
            {
                message = " sorry! you failed";
            }
            
            Console.WriteLine(message);
            Console.ReadLine();


            
        }
    }
}