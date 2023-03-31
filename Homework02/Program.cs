namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1;
            Console.Write("Enter the your number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"Number is factorial: {fact}");
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