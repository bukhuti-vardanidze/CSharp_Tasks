
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many Numbers Want to enter :");
            int enterNumb = Convert.ToInt32(Console.ReadLine());

            float[] numbs = new float[enterNumb];

            for(int i=0; i<enterNumb; i++)
            {
                Console.Write("Numbers Enterd - ", i);
                numbs[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("How Many Numbers Want to enter :");
            var number = Convert.ToSingle(Console.ReadLine());

            while(Console.ReadLine() != "End")
            {
                for (int i =0; i <= enterNumb; i++)
                {
                    if (numbs[i] == null)
                    {
                        Console.WriteLine("There is ", number);
                    }
                }
            }
        }
    }
}