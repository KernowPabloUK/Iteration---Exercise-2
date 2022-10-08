using System;

namespace Iteration___Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.



            // CWL "user enter number or type ok to exit
            // read string  and add in ToUpper for user entry 
            // convert to integer
            // count sum of all numbers entered
            //when ok is entered, 'break' and then display sum of numbers entered


            //int numberEntries = 0;
            //bool bStayInWhileLoop = true;

            //while (bStayInWhileLoop)
            //{
            //    Console.WriteLine($"Please enter a number, alternatively type OK to exit");
            //    string UserInput = Console.ReadLine();

            //    if (UserInput.ToUpper() == "OK")
            //    {
            //        bStayInWhileLoop = false;
            //    }


            //    numberEntries += Convert.ToInt32(UserInput);
            //}


            // sum all elements of array - only where previous element = even

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ForExample(numbers);
            ForEachExample(numbers);
            WhileExample(numbers);
        }

        private static void ForEachExample(int[] numbers)
        {
            int result = 0;
            int previusNumber = 1;
            foreach (int currentNumber in numbers)
            {
                int reminderOfDivisonByTwo = previusNumber % 2;
                if (reminderOfDivisonByTwo == 0)
                {
                    result = result + currentNumber;
                }
                previusNumber = currentNumber;
            }
            Console.WriteLine($"{result}");
        }

        private static void ForExample(int[] numbers)
        {
            int result = 0;
            for (int currentArrayIndex = 1; currentArrayIndex < numbers.Length; currentArrayIndex = currentArrayIndex + 1)
            {
                int previusNumber = numbers[currentArrayIndex - 1];
                int currentNumber = numbers[currentArrayIndex];

                int reminderOfDivisonByTwo = previusNumber % 2;
                if (reminderOfDivisonByTwo == 0)
                {
                    result = result + currentNumber;
                }
            }
            Console.WriteLine($"{result}");
        }

        private static void WhileExample(int[] numbers)
        {
            int result = 0;
            int currentArrayIndex = 1;
            while (currentArrayIndex < numbers.Length)
            {
                int currentNumber = numbers[currentArrayIndex];
                int previousNumber = numbers[currentArrayIndex - 1];
                int reminderOfDivisonByTwo = GetReminderOfDivisonByTwo(previousNumber);

                if (reminderOfDivisonByTwo == 0)
                {
                    result = result + currentNumber;
                }

                currentArrayIndex++;
            }

            Console.WriteLine($"{result}");
        }

        private static int GetReminderOfDivisonByTwo(int previousNumber)
        {
            return previousNumber % 2;
        }
    }
}
