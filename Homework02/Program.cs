namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome the Multiplication table !");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine();
            }

            / 06 Factorial

            int number, fact = 1;
            Console.Write("Enter the your number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"{number} is factorial: {fact}");
            }
            else
            {
                Console.WriteLine("Please enter the number!");
            }
            Console.WriteLine();
            Main(args);
        }
    }
}