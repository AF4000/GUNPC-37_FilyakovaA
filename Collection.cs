using System;

namespace HomeWork
{
    class Program
    {
        
            static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название задания или напишите EXIT для выхода");
                string value = Console.ReadLine();

                if (value.Equals("EXIT"))
                {
                    break; // Выход из программы
                }

                switch (value())
                {
                    case "задание1":
                        var listTask = new ListTask();
                        listTask.TaskLoop();
                        break;
                    case "задание2":
                        var studentTask = new StudentName();
                        studentName.TaskLoop();
                        break;
                    case "задание3":
                        var listElements = new ListElements();
                        listElements.TaskLoop();
                        break;
                    default:
                        Console.WriteLine("Нет такого задания");
                        break;
                }
            }

            Console.WriteLine("Выход.");
        }
    }
    
        
        private class ListTask // задание 1
        {
            public void TaskLoop()
            {
                List<string> list = new List<string>();
                list.Add("1");
                list.Add("2");
                list.Add("3");
                list.Add("4");
                list.Add("5");

                Console.WriteLine("Введите новое значение");
                string number1 = Console.ReadLine();
                list.Add(number1);

                Console.WriteLine();
                Console.WriteLine("Содержимое списка:");
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
                Console.WriteLine("Введите еще одно значение");
                string number2 = Console.ReadLine();

                int index = list.Count / 2;
                list.Insert(index, number2);

                Console.WriteLine();
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
            }
         }
   
        
        

            //Задание 2
private class StudentName
{
            public void TaskLoop()
            { 
              Dictionary <string, int> students = new Dictionary<string, int>();
              Console.WriteLine("Введите имя студента");
              string studentName = Console.ReadLine();

                int grade;
                while (true)
                {
                    Console.WriteLine("Введите оценку (от 2 до 5):");
                    string inputGrade = Console.ReadLine();
                    if (int.TryParse(inputGrade, out grade))
                    {
                        if (grade >= 2 && grade <= 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректная оценка.Введите число от 2 до 5");
                        }
                    }
                }
                students[studentName] = grade;
                Console.WriteLine("Введите имя студента для получения оценки:");
                string queryName = Console.ReadLine();
                if (students.ContainsKey(queryName))
                {
                    Console.WriteLine($"Оценка студента {queryName}: {students[queryName]}");
                }
                else
                {
                    Console.WriteLine("Студента с таким именем не существует.");
                }
            }
  
}
    
            // задание 3
private class ListElements
 {
            public void TaskLoop()
            {
                LinkedList<string> list = new LinkedList<string>();
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine($"Введите значение {i}:");
                    string value = Console.ReadLine();
                    list.AddLast(value);
                }

                Console.WriteLine("\nСписок в прямом порядке:");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nСписок в обратном порядке:");
                var currentNode = list.Last;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Previous;
                }
             }
   
    }
}
              




