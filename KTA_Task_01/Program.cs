using System;
using System.Security.Cryptography;

class Program
{
    static void Main()

    {
        ////////////////
        a:
        try
        {
            
            Console.Write("Сколько у вас золота?: ");
            int gold = int.Parse(Console.ReadLine());

            Console.Write("Введите рыночную стоимость одного кристалла: ");
            int CenaCrystal = int.Parse(Console.ReadLine());

            int crystal = gold / CenaCrystal;
            gold -= crystal * CenaCrystal;

            Console.WriteLine($"Количество купленных кристаллов: {crystal}");
            Console.WriteLine($"Остаток золота: {gold}");

        }
        catch
        {
            Console.WriteLine("Введите корректоное значение");
            
        }
        goto a;
    }
}