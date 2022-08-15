using System;
using System.Linq;

namespace CodeTest_2iTesting
{
    internal class Program
    {
        #region Misc
        /// <summary>
        /// Writes a message in the console all user friendly-like. <3
        /// </summary>
        /// <param name="txt">The text you would like to write in the console</param>
        /// <returns></returns>
        static async Task Log(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[" + DateTime.Now +" (" + DateTime.Now.Millisecond.ToString().Substring(0, 2) +"ms)" + "] Machine: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(txt);
        }
        #endregion

        /// <summary>
        /// Entry point for the application.
        /// </summary>
        /// <param name="args">Arguments passed at application launch</param>
        static void Main(string[] args)
        {
            Start(args);
        }

        /// <summary>
        /// The logical starting Task used to asynchronously manage the gathering of the values along with running and repeating the multiplications.
        /// </summary>
        /// <param name="args">Arguments passed at application launch</param>
        /// <returns></returns>
        static async Task Start(string[] args)
        {
            //Get Value 1
            await Log("Please enter Value 1");
            int value1 = 0; //Hold Value 1
            while (!int.TryParse(Console.ReadLine(), out value1))
            {
                //Couldn't parse input to a int
                await Log("Sorry this was not a valid number, was it too long? Or did it include letter/symbols? Please try again.");
            }

            //Get Value 2
            await Log("Please enter Value 2");
            int value2 = 0; //Hold Value 2
            while (!int.TryParse(Console.ReadLine(), out value2))
            {
                //Couldn't parse input to a int
                await Log("Sorry this was not a valid number, was it too long? Or did it include letter/symbols? Please try again.");
            }

            await MultiplyNumber(value1, value2); //To ensure the program displays our output correctly we will await this method.

            await Log("Work completed, press any key to close or press the \"R\" key to retry...");
            ConsoleKey input = Console.ReadKey().Key;
            Console.WriteLine();
            if (input == ConsoleKey.R) await Start(args);
        }

        /// <summary>
        /// Multiply value1 in iterations until it reaches value2.
        /// </summary>
        /// <param name="value1">Initial Value to also be used as a multiplier</param>
        /// <param name="value2">The max value that the iterations can reach</param>
        /// <returns></returns>
        static async Task MultiplyNumber(int value1, int value2)
        {
            #region Loop 1
            //Original values (1)
            int initialValue1 = value1;
            int maxValue1 = value2;
            int power1 = initialValue1;

            await Log("Values: InitValue=" + initialValue1 + " MaxValue=" + maxValue1);

            //Iterate original values
            for (int iteration = 1; initialValue1 <= maxValue1; iteration++)
            {
                string sum = initialValue1 + " X " + power1;
                initialValue1 *= power1;
                if (initialValue1 >= maxValue1) break;
                await Log(iteration + " (" + sum + "): " + initialValue1);
            }

            await Log("Moving on to A + 1 until 2X");
            #endregion

            #region Loop 2
            //Values with modifiers (2)
            var initialValue2 = value1 + 1;
            var maxValue2 = int.Parse("2" + value2.ToString());
            int power2 = initialValue2;


            await Log("Values: InitValue=" + initialValue2 + " MaxValue=" + maxValue2);


            //Iterate original values but + 1 to inital value until 2 followed by Value 2
            for (int iteration = 1; initialValue2 <= maxValue2; iteration++)
            {
                string sum = initialValue2 + " X " + power2;
                initialValue2 *= power2;
                if (initialValue2 >= maxValue2) break;
                await Log(iteration + " (" + sum + "): " + initialValue2);
            }

            await Log("Moving on to A + 2 until 3X");
            #endregion

            #region Loop 3
            //Values with modifiers (3)
            var initialValue3 = value1 + 2;
            var maxValue3 = int.Parse("3" + value2.ToString());
            int power3 = initialValue3;


            await Log("Values: InitValue=" + initialValue3 + " MaxValue=" + maxValue3);


            //Iterate original values but + 2 to inital value until 3 followed by Value 2
            for (int iteration = 1; initialValue3 <= maxValue3; iteration++)
            {
                string sum = initialValue3 + " X " + power3;
                initialValue3 *= power3;
                if (initialValue3 >= maxValue3) break;
                await Log(iteration + " (" + sum + "): " + initialValue3);
            }

            await Log("All work completed!");
            #endregion
        }
    }
}