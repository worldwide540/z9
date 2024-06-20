using System;

class Program
{
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        string testString = "Hello, world!";
        Console.WriteLine($"Обратная строка: {ReverseString(testString)}");
    }
}
