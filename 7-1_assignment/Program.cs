namespace _7_1_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvgNumInLoop();
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
            int number, userInput, count;

            Random generator = new Random();
            number = generator.Next(1, 101);

            Console.WriteLine("I will pick a number, 1-100, and you must guess it.");
            Console.WriteLine("I will tell you if you are higher, or lower than my number.");
            Console.WriteLine();
            Console.WriteLine("Guess your first number");

            while(userInput != number)
            {
                Console.WriteLine("Guess again: ")
            }
        }
    }
}
