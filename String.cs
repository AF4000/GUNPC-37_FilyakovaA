
using System.Text;

internal class Program
{
    public static void Main()  //если сразу указываю метод ConcatenateStrings без метода Main, пишет ошибку что "нет метода Main подходящего для входа" , подскажите почему? 
    { }
    public static void ConcatenateStrings()
        {
            Console.WriteLine("Введите 2 строки");
            var tecst1 = Console.ReadLine();
            var tecst2 = Console.ReadLine();
            Console.WriteLine($"{tecst1} {tecst2}");
        }

    public static void GreetUser(string[] args)
    {
        Console.WriteLine("Введите Имя и возраст");
        var Name = Console.ReadLine();
        var Ears = Console.ReadLine();
        Console.WriteLine($"Hello, {Name}!\nYou are {Ears} years old.");
    }
    public static void MetodString(string[] args)
    {
        Console.WriteLine("Введите любую строку");
        var tecst = Console.ReadLine();
        Console.WriteLine($"Длина строки: {tecst.Length}");
        Console.WriteLine(tecst.ToUpper());
        Console.WriteLine(tecst.ToLower());
    }
    public static void MetodChars(string[] args)
    {
        Console.WriteLine("Введите любую строку");
        var tecst = Console.ReadLine();
        Console.WriteLine(tecst.Substring(0, 4));
    }

    static StringBuilder ArrayToSentence(string[] words)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var word in words)
        {
            sb.Append(word).Append(' ');
        }
        return sb;
    }
    public static void ArrayWord()
    {
        string[] inputArray = { "Шла", "Саша", "по", "шоссе", "и" };
        StringBuilder sentence = ArrayToSentence(inputArray);
        Console.WriteLine(sentence.ToString());
    }



    static string ReplaceWords(string input, string wordToFind, string wordToReplace)
    {
        if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(wordToFind))
        {
            return input;
        }
        return input.Replace(wordToFind, wordToReplace);
    }
    public static void Words()
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();

            Console.WriteLine("Введите слово для поиска:");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Введите слово для замены:");
            string replaceWord = Console.ReadLine();

            string result = ReplaceWords(line, searchWord, replaceWord);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
   


}
