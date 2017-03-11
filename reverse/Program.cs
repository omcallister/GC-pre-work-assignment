using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //console is ouput(welcome/prompt) 
            Console.WriteLine("Hello from c#!");
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;

            // while number is greater than 0
            while (Number > 0)
            {
                // % 10 always give you the last num of an int
                int remainder = Number % 10;               
                Reverse = (Reverse * 10) + remainder;

                //this is the decrement of the string
                Number = Number / 10;
            }
            //output string
            //watch what happens when you input only zeros!
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();

        }
    }
}
