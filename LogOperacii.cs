using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program // сделать проверку ввода. Вместо Parse использовать TryParse. В случае ошибки - предупреждать пользователя и делать выход из программы (return) 
{
    static void Main(string[] args)
    {
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number");
            return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out var b))

        {
            Console.WriteLine("Not a number");
            return;
        }

        var meaning = Console.ReadLine();
        int result = 0;

        if (meaning.Length == 0 || meaning.Length > 1)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        switch (meaning[0])
        {
            case '+':
                result = a + b;
                Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                break;
            case '-':
                result = a - b;
                Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                result = a * b;
                Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                break;
            case '/':
                result = a / b;
                Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                break;
            default:
                Console.WriteLine("Wrong sign");
                return;
               
        }
        Console.WriteLine("Enter one of the symbols: & - calculation in binary system, | - calculation in hexadecimal system, ^ - in decimal system");
        var simvol = Convert.ToChar(Console.ReadLine());

        switch (simvol)
        {
            case '&':
                Console.WriteLine(Convert.ToString(result, 2));
                break;
            case '|':
                Console.WriteLine(Convert.ToString(result, 16));
                break;
            case '^':
                Console.WriteLine(Convert.ToString(result, 10));
                break;
            default:
                Console.WriteLine("Wrong sign");
                return;
        }
    }
}