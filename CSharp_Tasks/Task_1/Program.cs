namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = new int[5];
            
            for( int i=0; i<5; i++)
            {
                Console.Write("Number = ", i+1);
                numbs[i] = Convert.ToInt32(Console.ReadLine());

            } 

            for(int j=4; j>=0; j--)
            {
                Console.WriteLine("Reverse Number :" + numbs[j]);
            }

            

        }
    }
}