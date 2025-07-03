
using System.Text;

internal class Program
{
    public static void Main()
{
    Console.WriteLine("Введите 2 строки");
    string tecst1 = Console.ReadLine();
    string tecst2 = Console.ReadLine();
    string result = ConcatenateStrings(tecst1, tecst2);
    Console.WriteLine(tecst1 + tecst2);
}
public static string ConcatenateStrings(string tecst1, string tecst2)
{
return tecst1 + tecst2;
}


    
 public static void Main()
 {
     Console.WriteLine("Введите Имя и возраст");
     var Name = Console.ReadLine();
     var _ears = Console.ReadLine();
     int Ears;
     if (!int.TryParse(_ears, out Ears))
     {
         Console.WriteLine("Некорректный возраст");
         return;
     }
     string result = GreetUser(Name, Ears);
     Console.WriteLine(result);

 }
 public static string GreetUser(string Name, int Ears)
 {
     return $"Hello, {Name}!\nYou are {Ears} years old.";
 }



    
    public static void Main()
{
    Console.WriteLine("Введите любую строку");
    var tecst = Console.ReadLine();
    Console.WriteLine(MetodString(tecst));

}
public static string MetodString(string str)
{
    Console.WriteLine($"Длина строки: {str.Length}");
    Console.WriteLine(str.ToUpper());
    return str.ToLower();
}


    

public static void Main()
{
    Console.WriteLine("Введите любую строку");
    var tecst = Console.ReadLine();
    Console.WriteLine(MetodChars(tecst));
}
 public static string MetodChars(string Tecst)
{
    return Tecst.Substring(0, 4);
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
    public static void Main()
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
