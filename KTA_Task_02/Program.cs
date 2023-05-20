using System;

class Program
{
    static void Main()
    {
        string input = "";
        while (input.ToLower() != "exit")
        {
            Console.WriteLine("Введите слово (для выхода введите \"exit\"):");
            input = Console.ReadLine();
        }
        Console.WriteLine("Программа завершена.");
    }
}
