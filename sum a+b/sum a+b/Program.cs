using System;
using System.Collections.Generic;

class Demo
{
    static void Main()
        {
        Console.WriteLine("Welcome to the calculator...");
        int x = ReadNumber("first");
        int y = ReadNumber("second");
        Console.WriteLine("Please enter the number that corresponds with the action you would like to be performed...");
        Console.WriteLine("Press 1 for addition");
        Console.WriteLine("Press 2 for subtraction");
        Console.WriteLine("Press 3 for multiplication");
        Console.WriteLine("Press 4 for division");
        int operation = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (operation)
            {
            case 1:
                {
                    result = Addition(x, y);
                    break;
                }
            case 2:
                {
                    result = Subtraction(x, y);
                    break;
                }
            case 3:
                {
                    result = Multiplication(x, y);
                    break;
                }
            case 4:
                {
                    result = Division(x, y);
                    break;
                }
            default:
                Console.WriteLine("try again");
                break;
        }
        Console.WriteLine("The result is {0}", result);
    }

        static int ReadNumber(string numOrdinal){
        while (true)
        {
            Console.WriteLine("Please enter the " + numOrdinal + " number you would like to use...");
                string number;
                number = Console.ReadLine();
                int a = Convert.ToInt32(number);
                Console.WriteLine("You wrote... {0}, is this correct? Please use 0 to signify yes.", a);
                string confirmation;
                confirmation = Console.ReadLine();
                int x = Convert.ToInt32(confirmation);
            if (x == 0)
            {
            Console.WriteLine("{1} number... {0}", a , numOrdinal);
            return a;
            }
        }
    }
    static int Addition(int x, int y)
        {
        int result = x + y;
        return result;
        }

    static int Subtraction(int x, int y)
        {
        int result = x - y;
        return result;
        }
    static int Multiplication(int x, int y)
        {
        int result = x * y;
        return result;
        }
    static int Division(int x, int y)
        {
        int result = x / y;
        return result;
        }
    }
