using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> occurrances = new Dictionary<int, int>();
            int counter = 0;
            int sides;
            int roll;
            int total = 0;
            double average;
            bool finished = false;
            string input;
            bool validInput;

            Console.Write("Enter the number of sides on the die: ");
            sides = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sides; i++)
            {
                occurrances.Add(i, 0);
            }

            Console.Write("Roll the die and input the value rolled followed by pressing the Enter key. \nEnter 'F' "
                + "when you are finished rolling.");
            System.Threading.Thread.Sleep(5000);

            while (!finished)
            {
                Console.Clear();

                Console.Write("Roll #" + (counter + 1) + ": ");
                input = Console.ReadLine();
                if (input == "F") finished = true;

                validInput = int.TryParse(input, out roll);
                if (!validInput || roll < 1 || roll > sides) continue;

                occurrances[roll]++;
                counter++;
            }

            Console.Clear();

            for (int i = 1; i <= sides; i++)
            {
                Console.WriteLine("Number of " + i + "s rolled: " + occurrances[i]);
                total += (occurrances[i] * i);
            }

            average = (double)total / (double)(counter);
            Console.WriteLine("\nAverage Roll: " + average);

            Console.ReadLine();
        }
    }
}
