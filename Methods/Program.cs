internal class Program
{
    private static void Main(string[] args)
    {
        //Print(10);
        //Console.WriteLine(Sum(20, 30));
        //Console.WriteLine(Compare(10, 20)); 
        //Console.WriteLine(Compare(10, 20)); 
        //Print(20);
        //Console.WriteLine("6 " + SumOdd(6));
        //Console.WriteLine("10  " + SumOdd(10));
        //Console.WriteLine("1000  " + SumOdd(1000));
        //Console.WriteLine("10201 " + SumOdd(10201));
        //PrintStart(10);
        //PrintStart(10);
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Console.WriteLine(Sum("Name","Name 2",32,1020,20,320));
        //PrintStart(10, 2);
        //method signature - method name, parametr sayi, parametr type
        //InterviewQuestion();
        //PrintStart(10, 20);
    }
    static void InterviewQuestion(int number)
    {
        Console.WriteLine(number);
    }
    static void InterviewQuestion(params int[] names)
    {
        Console.WriteLine(names.Length);
    }
    static void PrintStart(string name)
    {
        Console.WriteLine(name);
    }
    static void PrintStart(int width, int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void PrintStart(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static int Sum(string name, string str = "", int number2 = 10, params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int Compare(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        //else
        //{
        //    return y;
        //}
        return y;
    }

    static void Print(int number)
    {
        Console.WriteLine($"Void method parametr- {number}");
    }
    static int SumOdd(int number)
    {
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}