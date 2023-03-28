internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(SumDivide(10, 30));
        Console.WriteLine(IsPrime(2));
    }
    static bool IsPrime(int number)
    {
        //int count = 0;
        if (number == 2)
        {
            return true;
        }
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int SumDivide(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 21 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}