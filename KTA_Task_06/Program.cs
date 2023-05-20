using System;

class Program
{
    static string[] names = new string[0]; 
    static string[] positions = new string[0]; 

    static void Main(string[] args)
    {
        bool konec = false;

        while (!konec)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Добавить досье.");
            Console.WriteLine("2. Вывести все досье.");
            Console.WriteLine("3. Удалить досье.");
            Console.WriteLine("4. Поиск по фамилии.");
            Console.WriteLine("5. Выход.");
            Console.WriteLine("-------------------");
            Console.Write("Введите номер действия: ");
            Console.WriteLine("-------------------");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddDossier();
                    break;
                case 2:
                    PrintDossiers();
                    break;
                case 3:
                    RemoveDossier();
                    break;
                case 4:
                    SearchByLastName();
                    break;
                case 5:
                    konec = true;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
    static void AddDossier()
    {
        /////////
        ///
        Console.Write("Введите ФИО: ");
        string name = Console.ReadLine();
        ///////////
        ///
        Console.Write("Введите должность: ");
        string position = Console.ReadLine();

        Array.Resize(ref names, names.Length + 1);
        names[names.Length - 1] = name;

        Array.Resize(ref positions, positions.Length + 1);
        positions[positions.Length - 1] = position;

        Console.WriteLine("Досье добавлено.");
    }

    static void PrintDossiers()
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {names[i]} - {positions[i]}");
        }
    }

    static void RemoveDossier()
    {
        Console.Write("Введите ФИО для удаления: ");
        string name = Console.ReadLine();

        bool found = false;

      
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == name)
            {
              
                names[i] = names[names.Length - 1];
                positions[i] = positions[positions.Length - 1];

               
                Array.Resize(ref names, names.Length - 1);
                Array.Resize(ref positions, positions.Length - 1);

                Console.WriteLine("Досье удалено.");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Досье не найдено.");
        }
    }
    static void SearchByLastName()
    {
        Console.Write("Введите фамилию: ");
        string lastNameToFind = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < names.Length; i++)
        {
            string[] parts = names[i].Split(' ');

            if (parts.Length > 1 && parts[0] == lastNameToFind)
            {
                Console.WriteLine($"{i + 1}. {names[i]} - {positions[i]}");

                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Досье не найдено.");
        }
    }
}

