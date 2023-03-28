internal class Program
{
    private static void Main(string[] args)
    {
        int age = 10;
        bool dayday = true;
        Console.WriteLine("C# Intro");
        //if (age < 18)
        //{
        //    Console.WriteLine("If");
        //}
        //else
        //{
        //    Console.WriteLine("Else");
        //}
        //string flag = age == 18 ? "If" : "Else";

        //switch (age)
        //{
        //    case 10:
        //    case 18 when dayday == true:
        //        Console.WriteLine("Ise qebul olduz");
        //        break;
        //    case 18 when dayday == false:
        //        Console.WriteLine("Sizle elaqe saxliyaciyiq");
        //        break;
        //    default:
        //        Console.WriteLine("Lab lab");
        //        break;
        //}

        //var operation = 1;

        //var eded = operation switch
        //{
        //    1 => "kscg",
        //    2 => "kscg",
        //    3 => "kscg",
        //    4 => "kscg"
        //};

        //var operation = 100;
        //dynamic operation2 = 10;

        //for (int i=0;i<10;i++)
        //{
        //    Console.WriteLine(i);
        //}
        //int i = 0;
        //for (; ; )
        //{
        //    Console.WriteLine(i);
        //}

        //while (i < 10)
        //{
        //    Console.WriteLine(i);
        //}
        //do
        //{
        //    Console.WriteLine(i);
        //} while (i < 10);
        //string name = "Test 1";
        //foreach (int letter in name)
        //{
        //    Console.WriteLine(letter);
        //} 

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (i == 2) break;
        //        Console.WriteLine(i);
        //    }
        //}

        // *
        // **
        // ***
        // ****
        // *****
        //for (int i = 0; i <= 10; i++)
        //{
        //    for (int j = 0; j <= 10; j++)
        //    {
        //        Console.Write($"{i} * {j} = {i * j} ");
        //    }
        //    Console.WriteLine("");
        //}





        for (int i = 1; i <=5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ( i== 1 || i == 5 || j == 1 || j == 5)
                {
                    Console.Write("*");

                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }

    }
}