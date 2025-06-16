using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Дана строка string password = “qwerty”; Напишите программу для ввода пароля, которая считывает пользовательский ввод Console.ReadLine. Подсказка: используйте do-while
            string password = "qwerty";
            int count = 0;
            Console.WriteLine("Введите пароль");
            {
                do
                {
                    string checkPassword = Console.ReadLine();
                    {
                        if (password == checkPassword)
                        {
                            Console.WriteLine("Верный пароль");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверно введён пароль");
                            ++count;
                        }

                    }
                } while (count < 3);
            }
        }
    }
}

using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. С помощью вложенных циклов for выведите таблицу умножения от 1 до 5. Каждая строка таблицы должна быть выведена в отдельной строке.
            for (int mnochitel = 1; mnochitel < 6; mnochitel++)
            {
                for (int mnochitel2 = 1; mnochitel2 <= 10; mnochitel2++)
                {
                    Console.WriteLine("{0} * {1} = {2}", mnochitel, mnochitel2, mnochitel * mnochitel2);
                }
                Console.WriteLine();
            }
        }
    }
}

using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Используя цикл for, выведите все чётные числа от 2 до 20
            for (int i = 2; i <= 20; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i); // Выведет числа от 0 до 20
                }
        }
    }
}

using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Fibonaccy С помощью цикла for (или while) выведите первые 10 чисел Фиббоначи. Чи́сла Фибона́ччи - элементы числовой последовательности в которой первые два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел, т.е. 0, 1, 1, 2, 3, 5 и т.д. Создайте массив, сожержащий первые 8 чисел данной последовательности

            int i = 0, Next, First = 0, Second = 1;  // Инициализация переменных

            // Запрос числа от пользователя:  
            Console.WriteLine("Введите положительное число, обозначающие какое кол-во чисел последовательности вы хотите увидеть");
            var Number = Convert.ToInt32(Console.ReadLine());

            // Цикл для вывода последовательности:  
            while (i < Number)
            {
                if (i <= 1)
                    Next = i;
                else
                    Next = First + Second;
                First = Second;
                Second = Next;
                Console.WriteLine("{0} ", Next);
                i++;
            }

        }
    }
}




