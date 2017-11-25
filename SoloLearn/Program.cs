using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display text
            Console.WriteLine("Display text:");
            Console.WriteLine("Hello World!");

            //Display variable value
            Console.WriteLine("Display variable value:");
            int x=89;
            Console.WriteLine(x);
            //Outputs 89

            //Display formatted string
            Console.WriteLine("Display formatted string:");
            int y=12;
            double z=24;
            Console.WriteLine("y={0}; z={1}", y, z);
            //Output: x = 12; z= 24

            //User input
            Console.WriteLine("User input:");
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);

            //Convert user input
            Console.WriteLine("Convert user input:");
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}
