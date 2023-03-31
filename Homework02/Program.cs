namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the your number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 1 && number <= 100)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.Write($"{i};");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Please enter a number in the range!");
                }
            }
            else
            {
                Console.WriteLine("Please emter the number!");
            }
            Console.WriteLine();
            Main(args);

        }
    }
}