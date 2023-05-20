using System;

class Program
{
    static void Main()
    {
        string password = "1231";
        string a;
        int b = 3;

        for (int i = 0; i< 3; i++)
        {
            Console.WriteLine("Введите пароль для секретного сообщения:");
            a = Console.ReadLine();
            if (a == password) 
            {
                Console.WriteLine("Всё ок");
                break;
            }
            else
            {
                Console.WriteLine("Неверный пароль");
                b -= 1;
                Console.WriteLine($"У вас осталось {b} попыток");
            }
        }
    }
}