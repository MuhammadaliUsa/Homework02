namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, max, min, difference;
            Console.Write("Enter the first number: ");
            int.TryParse(Console.ReadLine(), out number1);
            Console.Write("Enter the second number: ");
            int.TryParse(Console.ReadLine(), out number2);
            Console.Write("Enter the three number: ");
            int.TryParse(Console.ReadLine(), out number3);
            Console.Write("Enter the four  number: ");
            int.TryParse(Console.ReadLine(), out number4);
            max = Math.Max(number1, Math.Max(number2, Math.Max(number3, number4)));
            min = Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
            difference = max - min;
            Console.WriteLine($"Diffirence Max and Min: {max - min}");
            Console.WriteLine();
            Main(args);


        }
    }
}