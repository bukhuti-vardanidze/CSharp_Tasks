namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number {0}= ", i + 1);
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
                if (numbers[i] % 2 == 0)
                    Console.Write("Even numbers : ", numbers[i]);
        }
    }
}