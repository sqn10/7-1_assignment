namespace _7_1_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvgNumInLoop();
            HiLowLimitTries();
        }
        public static void AvgNumInLoop()
        {
            int numbers;
            double userInput, total = 0, count = 0;

            Console.WriteLine("Enter any amount of numbers, I will find their average.");
            Console.WriteLine("How many numbers would you like to input?");
            Int32.TryParse(Console.ReadLine(), out numbers);

            while (count < numbers)
            {
                Console.WriteLine("Enter the number: ");
                Double.TryParse(Console.ReadLine(), out userInput);
                count++;
                total += userInput;
            }

            Console.WriteLine();
            Console.WriteLine("The average of the numbers is: " + Math.Round(total / count, 2));
        }
        public static void HiLowLimitTries()
        {
            int number, userInput = 0, count = 0;
            const int maxTries = 7;

            Random generator = new Random();
            number = generator.Next(1, 101);

            Console.WriteLine("I will pick a number, 1-100, and you must guess it.");
            Console.WriteLine("I will tell you if you are higher, or lower than my number.");
            Console.WriteLine();

            while (userInput != number && count < maxTries)
            {
                Console.Write("Enter a guess: ");

                if (Int32.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput < 1 || userInput > 100)
                    {
                        Console.WriteLine("Invalid input. Keep it between 1 and 100!");
                        Console.WriteLine();
                        count++;
                    }
                    else if (userInput > number)
                    {
                        Console.WriteLine("Too high!");
                        Console.WriteLine();
                        count++;
                    }
                    else if (userInput < number)
                    {
                        Console.WriteLine("Too low!");
                        Console.WriteLine();
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("BINGO!");
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. That's not a number!");
                    Console.WriteLine();
                    count++;
                }
            }

            if (userInput != number && count >= maxTries)
            {
                Console.WriteLine("Too many tries... the number was " + number + ".");
            }
            else if (count == 1)
            {
                Console.WriteLine("It took you " + count + " try!");
            }
            else
            {
                Console.WriteLine("It took you " + count + " tries.");
            }
        }

    }
}
