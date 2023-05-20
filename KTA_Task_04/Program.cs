using System;

class Program
{
    static void Main()
    {
        int ShoreHealth = 1000;
        int playerHealth = 500;
        bool ShadowSummon = false;
        bool ShadowRaincoat = false;

        Console.WriteLine("Подойдя к камнной ветхой двери, вы отваряете её.");
        Console.WriteLine("За ней вы увидели древний железный гроб, вы ощутили будто он на вас смотрит,");
        Console.WriteLine("но гробовую тишину нарушает падующая крышка гроба.");
        Console.WriteLine("Из него выходит древний военочальник проклятый охранять свою же гробницу, по древним записям звали его Шор.");
        Console.WriteLine("Используя Глаз Велки, вы определяете жизненую силу Шора. Она равна 1000 когда, ваша уже достигла 500. ");

        while (ShoreHealth > 0 && playerHealth > 0)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выберите заклинание заклинание (СБЕЖАТЬ НЕВОЗМОЖНО!!!) : ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Открытие врат Обливиона, для призыва теневого черта, но при открытии вы выпускаете миазмы (100 урона себе, 50 урона Шору)");
            Console.WriteLine("-----------------------");
            Console.WriteLine("2. Теневой разрез, команда для теневого черта (200 урона)");
            Console.WriteLine("-----------------------");
            Console.WriteLine("3. Плащ теней (Вы восстановите 250 жизненной силы )");
            Console.WriteLine("-----------------------");
            Console.WriteLine("4. Теневая стрела (50 урона)");
            Console.WriteLine("-----------------------");
            Console.WriteLine("5. Теневые колья (80 урона)");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                /////////////////
                ///
                case 1:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Открыв врата Обливиона, вызвав теневого черта, но вы чувствуете как миазмы забрали часть ваших сил (100 урона себе), но и Шор пострадал от них (50 урона Шору).");
                    playerHealth -= 75;
                    ShoreHealth -= 50;
                    break;

                /////////////////
                ///
                case 2:
                    if (ShadowSummon)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Черт использовав свои когди нанёс Шору 200 урона");
                        ShoreHealth -= 200;
                        ShadowSummon = false;
                    }
                    else
                    {
                        Console.WriteLine("Чёрт не может атаковать если его нет (Нужно использовать Открытие врат Обливиона)");
                    }
                    break;

                ///////////////////
                ///
                case 3:
                    ShadowRaincoat = true;
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Использовав Плащ теней вы восстановили себе 250 жизненной силы ");
                    playerHealth += 250;
                    break;

                ///////////////////////
                ///
                case 4:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Используя Теневую стрелу и пустив её в Шора он пошатнулся и он потерял 50 жизненных сил");
                    ShoreHealth -= 50;
                    break;
                ////////////////
                ///
                case 5:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Призвав теневые колья под Шором вы изрешитили его нанеся 80");
                    ShoreHealth -= 80;
                    break;
                //////////////////////
                ///
                default:
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Такого заклинания нет");
                    break;
            }
            if (!ShadowRaincoat && ShoreHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Шор атакует вас своим двуручным эбонитовым молотом, рана не смертельна");
                playerHealth -= 200;
            }
            else
            {
                ShadowRaincoat = false;
                Console.WriteLine("-----------------------");
                Console.WriteLine("В Теневом плаще Шор потерял вас из виду, он пропускает свою атаку");
                playerHealth -= 0;
            }

            Console.WriteLine($"У Шора осталось {ShoreHealth} жизненных сил. У вас {playerHealth} здоровья");
        }
            if (ShoreHealth <= 0)
            {
                Console.WriteLine("Шор пал, как и более века назад, но на этот раз окончательно. Стоит это отпраздновать!!!");
            }
            else
            {
                Console.WriteLine("Шор прикончил вас. Ваше приключение закончелось в древней забытой гробнице, где вы теперь покоитесь.");
            }
        
        Console.ReadLine();
    }
}