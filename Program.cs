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

        var i = Console.ReadLine();
        var boolVar = true;
        var simvol = Console.ReadLine();
        var simvol_1 = Convert.ToChar(simvol);

        if (i.Length == 0 || i.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        switch (i[0])
        {
            case '+':
                {
                    switch (simvol_1)
                    {
                        case '&':
                            var Number_1 = Convert.ToString(a + b, 2);
                            Console.WriteLine("Result of {0} + {1} = {2}", a, b, Number_1);
                            break;
                        case '|':
                            var Number_2 = Convert.ToString(a + b, 16);
                            Console.WriteLine("Result of {0} + {1} = {2}", a, b, Number_2);
                            break;
                        case '^':
                            var Number_3 = Convert.ToString(a + b, 10);
                            Console.WriteLine("Result of {0} + {1} = {2}", a, b, Number_3);
                            break;

                        default:
                            Console.WriteLine("Wrong sign");
                            return;
                    }
                }

                break;

            case '-':
                {
                    switch (simvol_1)
                    {
                        case '&':
                            var Number_1 = Convert.ToString(a - b, 2);
                            Console.WriteLine("Result of {0} - {1} = {2}", a, b, Number_1);
                            break;
                        case '|':
                            var Number_2 = Convert.ToString(a - b, 16);
                            Console.WriteLine("Result of {0} - {1} = {2}", a, b, Number_2);
                            break;
                        case '^':
                            var Number_3 = Convert.ToString(a - b, 10);
                            Console.WriteLine("Result of {0} - {1} = {2}", a, b, Number_3);
                            break;

                        default:
                            Console.WriteLine("Wrong sign");
                            return;
                    }
                }
                break;
            case '*':
                {
                    switch (simvol_1)
                    {
                        case '&':
                            var Number_1 = Convert.ToString(a * b, 2);
                            Console.WriteLine("Result of {0} * {1} = {2}", a, b, Number_1);
                            break;
                        case '|':
                            var Number_2 = Convert.ToString(a * b, 16);
                            Console.WriteLine("Result of {0} * {1} = {2}", a, b, Number_2);
                            break;
                        case '^':
                            var Number_3 = Convert.ToString(a * b, 10);
                            Console.WriteLine("Result of {0} * {1} = {2}", a, b, Number_3);
                            break;

                        default:
                            Console.WriteLine("Wrong sign");
                            return;
                    }
                }
                break;
            case '/':
                {
                    switch (simvol_1)
                    {
                        case '&':
                            var Number_1 = Convert.ToString(a / b, 2);
                            Console.WriteLine("Result of {0} / {1} = {2}", a, b, Number_1);
                            break;
                        case '|':
                            var Number_2 = Convert.ToString(a / b, 16);
                            Console.WriteLine("Result of {0} / {1} = {2}", a, b, Number_2);
                            break;
                        case '^':
                            var Number_3 = Convert.ToString(a / b, 10);
                            Console.WriteLine("Result of {0} / {1} = {2}", a, b, Number_3);
                            break;

                        default:
                            Console.WriteLine("Wrong sign");
                            return;
                    }
                }
                break;
            default:
                Console.WriteLine("Wrong sign");
                return;
               
        }
    }
}