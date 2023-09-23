using War1;

ConsoleKeyInfo choise;
bool flag = false;
Player player1 = new Player();
EnemyOrk ork1 = new EnemyOrk();
Inventory inventory = new Inventory();

do
{
    Console.WriteLine("Главное меню\n" +
                     "1 - Создать персонажа\n" +
                     "2 - Выход");
    choise=Console.ReadKey();
    Console.Clear();
    switch (choise.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Введите имя персонажа");
            player1.Name=Console.ReadLine();
            Console.WriteLine("Выберите расу\n" +
                              "1 - Человек - Сила +7 Ловкость +5 Интелект +6\n"+
                              "2 - Эльф - Сила +5 Ловкость +8 Интелект +7\n" +
                              "3 - Гном - Сила +9 Ловкость +4 Интелект +4\n");
            choise = Console.ReadKey();
            Console.Clear();
            switch (choise.Key)
            {
                case ConsoleKey.D1:
                    player1.Raca = "Человек";
                    player1.Power = 7;
                    player1.Dexterity = 5;
                    player1.Intelligence = 6;
                    break;
                case ConsoleKey.D2:
                    player1.Raca = "Эльф";
                    player1.Power = 5;
                    player1.Dexterity = 8;
                    player1.Intelligence = 7;
                    break;
                case ConsoleKey.D3:
                    player1.Raca = "Гном";
                    player1.Power = 9;
                    player1.Dexterity = 4;
                    player1.Intelligence = 4;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Выберите класс\n" +
                             "1 - Воин - Сила +5 Ловкость +3 Интелект +2\n" +
                             "2 - Маг - Сила +2 Ловкость +3 Интелект +5\n" +
                             "3 - Ренджер - Сила +3 Ловкость +5 Интелект +3");
            choise = Console.ReadKey();
            Console.Clear();
            switch (choise.Key)
            {
                case ConsoleKey.D1:             // Класс Воин
                    player1.NameClass = "Воин";
                    player1.Power +=5;
                    player1.Dexterity += 3;
                    player1.Intelligence += 2;
                    Console.WriteLine("Выберите оружие\n" +
                            "1 - Двуручный меч - урон +20\n" +
                            "2 - Меч и щит - урон +7 защита +7\n" +
                            "3 - Два меча - урон 10");
                    choise = Console.ReadKey();
                    Console.Clear();
                    switch(choise.Key)
                    {
                        case ConsoleKey.D1:
                            inventory.AddItem("Двуручный меч", 1);
                            player1.Damage += 20;
                            break;
                        case ConsoleKey.D2:
                            inventory.AddItem("Меч", 1);
                            inventory.AddItem("Щит", 1);
                            player1.Damage += 7;
                            player1.Defence += 7;
                            break;
                        case ConsoleKey.D3:
                            inventory.AddItem("Меч", 1);
                            inventory.AddItem("Меч", 1);
                            player1.Damage += 10;
                            break;
                        default:
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    player1.NameClass = "Маг";       // Класс Маг
                    player1.Power += 2;
                    player1.Dexterity += 3;
                    player1.Intelligence += 5;
                    Console.WriteLine("Выберите оружие\n" +
                            "1 - Посох - урон +10 интелект +1 \n" +
                            "2 - Посох и меч - урон +15\n" +
                            "3 - Жезл и меч - урон 7 интелект +2");
                    choise = Console.ReadKey();
                    Console.Clear();
                    switch (choise.Key)
                    {
                        case ConsoleKey.D1:
                            inventory.AddItem("Посох", 1);
                            player1.Damage += 10;
                            player1.Intelligence += 1;
                            break;
                        case ConsoleKey.D2:
                            inventory.AddItem("Посох", 1);
                            inventory.AddItem("Меч", 1);
                            player1.Damage += 15;
                            break;
                        case ConsoleKey.D3:
                            inventory.AddItem("Жезл", 1);
                            inventory.AddItem("Меч", 1);
                            player1.Damage += 7;
                            player1.Intelligence += 2;
                            break;
                        default:
                            break;
                    }
                    break;
                case ConsoleKey.D3:
                    player1.NameClass = "Ренджер";      // Класс Ренджер
                    player1.Power += 3;
                    player1.Dexterity += 5;
                    player1.Intelligence += 3;
                    Console.WriteLine("Выберите оружие\n" +
                            "1 - Арбалет - урон +15\n" +
                            "2 - Лук короткий - урон +8 ловкость +2\n" +
                            "3 - Лук длинный - урон 10 ловкость +1");
                    choise = Console.ReadKey();
                    Console.Clear();
                    switch (choise.Key)
                    {
                        case ConsoleKey.D1:
                            inventory.AddItem("Арбалет", 1);
                            player1.Damage += 15;
                            break;
                        case ConsoleKey.D2:
                            inventory.AddItem("Лук корокий", 1);
                            player1.Damage += 8;
                            player1.Dexterity += 2;
                            break;
                        case ConsoleKey.D3:
                            inventory.AddItem("Лук длинный", 1);
                            player1.Damage += 10;
                            player1.Dexterity += 1;
                            break;
                        default:
                            break;
                    }
                    break;
            }
            flag =true;
            break;
        case ConsoleKey.D2:
            Environment.Exit(0);
            break;
        default:
            break;
    }
}while(!flag);

flag = false;

do
{
    Console.WriteLine("Меню персонажа\n" +
                      "1 - Информация о персонаже\n" +
                      "2 - Инвентарь\n" +
                      "3 - Сражаться с противником\n" +
                      "4 - Выход");
    choise = Console.ReadKey();
    Console.Clear();
    switch (choise.Key)
    {
        case ConsoleKey.D1:
            player1.PrintInfo();
            Console.ReadKey();
            break;
        case ConsoleKey.D2:
            inventory.ShowInventory();
            Console.ReadKey();
            break;
        case ConsoleKey.D3:
            ork1.PrintInfo();
            bool flag1 = false;
            int round = 1;
            do
            {
                Console.WriteLine($"Бой начался! Раунд: {round}");
                player1.Attack(ork1, player1);
                ork1.HealthInfo();
                Console.ReadLine();
                if (ork1.Health <= 0)
                {
                    Console.WriteLine("Бой закончен!");
                    flag1 = true;
                    break;
                }

                ork1.Attack(player1, ork1);
                player1.HealthInfo();
                Console.ReadLine();

                if (player1.Health <= 0)
                {
                    Console.WriteLine("Бой закончен!");
                    flag1 = true;
                    break;
                }
                round++;
            } while (!flag1);

            break;
        case ConsoleKey.D4:
            flag = true;
            break;
        default:
            break;
    }
} while (!flag);



