using System;
using System.Linq;

namespace CodeTest_i2Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check if the applcation arguments is empty.
            if (args.Length != 0)
            {
                //Application arguments have provided vaues A & X.
                MultiplyNumber(int.Parse(args[0]), int.Parse(args[1])); //Cant run Asyn as its called from Main, with more time I could work around this.
            }
            else Start();
        }

        static async void Start()
        {
            //Get Value 1
            Console.WriteLine("Please enter Value 1");
            int value1 = 0; //Hold Value 1
            while (!int.TryParse(Console.ReadLine(), out value1))
            {
                //Couldn't parse input to a int
                Console.WriteLine("Sorry this was not a valid number, was it too long? Or did it include letter/symbols? Please try again.");
            }

            //Get Value 2
            Console.WriteLine("Please enter Value 2");
            int value2 = 0; //Hold Value 2
            while (!int.TryParse(Console.ReadLine(), out value2))
            {
                //Couldn't parse input to a int
                Console.WriteLine("Sorry this was not a valid number, was it too long? Or did it include letter/symbols? Please try again.");
            }

            await MultiplyNumber(value1, value2); //To ensure the program displays our output correctly we will await this method.

            Console.WriteLine("Work completed, press any key to close...");
            Console.ReadKey();
        }

        static async Task MultiplyNumber(int value1, int value2)
        {
            #region Loop 1
            //Original values (1)
            var initialValue1 = value1;
            var maxValue1 = value2;
            var power1 = initialValue1;

            Console.WriteLine("Values: InitValue=" + initialValue1 + "MaxValue=" + maxValue1);

            //Iterate original values
            for (int iteration = 0; initialValue1 < maxValue1; iteration++)
            {
                initialValue1 *= power1;
                Console.WriteLine(initialValue1);
            }

            Console.WriteLine("Moving on to A + 1 until 2X");
            #endregion
            #region Loop 2
            //Values with modifiers (2)
            var initialValue2 = value1 + 1;
            var maxValue2 = 2 * 10 + value2;
            var power2 = initialValue2;

            Console.WriteLine("Values: InitValue=" + initialValue2 + "MaxValue=" + maxValue2);


            //Iterate original values but + 1 to inital value until 2 followed by 
            for (int iteration = 0; initialValue2 < maxValue2; iteration++)
            {
                initialValue2 *= power2;
                Console.WriteLine(initialValue2);
            }

            Console.WriteLine("Moving on to A + 2 until 3X");
            #endregion
            #region Loop 3
            //Values with modifiers (3)
            var initialValue3 = value1 + 2;
            var maxValue3 = 3 * 10 + value2;
            var power3 = initialValue3;

            Console.WriteLine("Values: InitValue=" + initialValue3 + "MaxValue=" + maxValue3);


            //Iterate original values but + 1 to inital value until 2 followed by 
            for (int iteration = 0; initialValue3 < maxValue3; iteration++)
            {
                initialValue3 *= power3;
                Console.WriteLine(initialValue3);
            }

            Console.WriteLine("All work completed!");
            #endregion
        }
    }
}