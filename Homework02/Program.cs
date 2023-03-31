namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber, sum = 0;
            Console.Write("Enter starting range: ");
            int.TryParse(Console.ReadLine(), out startNumber);
            Console.Write("Enter ending range: ");
            int.TryParse(Console.ReadLine(), out endNumber);
            for (int i = startNumber; i < endNumber; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
                sum = 0;

            }

        }
    }
}