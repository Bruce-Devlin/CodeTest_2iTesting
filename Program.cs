using System;
using System.Linq;

namespace CodeTest_2iTesting
{
    internal class Program
    {
        #region Misc
        static async Task Log(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[" + DateTime.Now +" (" + DateTime.Now.Millisecond.ToString().Substring(0, 3) +"ms)" + "] Machine: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(txt);
        }
        #endregion

        static void Main(string[] args)
        {
            Start(args);
        }

    static async void Start(string[] args)
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

            await Log("Work completed, press any key to close...");
            Console.ReadKey();
        }

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


            //Iterate original values but + 1 to inital value until 2 followed by 
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


            //Iterate original values but + 1 to inital value until 2 followed by 
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