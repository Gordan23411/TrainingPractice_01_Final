using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array = { "a", "b", "c", "d", "e" };
        while (true)
        {
            Console.WriteLine("1. Перемешать массив");
            Console.WriteLine("2. Вывести массив");
            Console.WriteLine("3. Exite");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Shuffle(array);
                    Console.WriteLine("Перемешиваем массив.");
                    break;
                case "2":
                    Console.WriteLine("Массив:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {array[i]}");
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Выбор не действителен.");
                    break;
            }

            Console.WriteLine();
        }
    }
    static void Shuffle<T>(T[] array)
    {
        Random rnd = new Random();
        for (int i = array.Length - 1; i >= 1; i--)
        {
            int j = rnd.Next(i + 1);
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
