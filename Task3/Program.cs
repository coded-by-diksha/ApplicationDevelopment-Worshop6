namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 11, 14, 8, 3 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\nNumbers Greater Than 10:");
            ProcessNumbers(numbers, n => n > 10);

            Console.ReadLine();
        }

        // Method that accepts array + used built-in Func delegate  
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int n in numbers)
            {
                if (condition(n))   // apply the condition
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
