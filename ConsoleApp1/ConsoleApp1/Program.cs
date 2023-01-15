namespace ConsoleApp1
{ 
    class Program 
    {
        public static void Main()
        {
            Console.WriteLine(Sum(-50, 100));
        }
        public static int Sum(int start, int end)
        {
            int sum = 0;
            for (int i=start; i<=end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
