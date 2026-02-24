void StartLevel()
{
    char[,] map =
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#' },
    { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
    { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#' },
    { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
    { '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', ' ', '#' },
    { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
    { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', ' ', 'E' },
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
};
int X;
int Y;
int playerX = 1;
int playerY = 1;

DateTime start = DateTime.Now;

while(true) 
{   
    int secsPassed = (int)(DateTime.Now - start).TotalSeconds;
    int secsLeft = 15 - secsPassed;
    if(secsLeft <= 0)
    {
        Console.WriteLine("Game Over!");
        break;
    }

    Console.Clear();

    Console.WriteLine("===============");
    Console.WriteLine($" TIME LEFT: {secsLeft}s");
    Console.WriteLine("===============");

    for(X = 0; X < map.GetLength(0); X++)
    {
        for(Y = 0; Y < map.GetLength(1); Y++)
        {
            if(X == playerY && Y == playerX)
        {
            Console.Write('P');
        } else
        {
            Console.Write(map[X, Y]);
        }
        }
        
    Console.WriteLine();
    }

    if (Console.KeyAvailable)
    {
    ConsoleKeyInfo input = Console.ReadKey(true);
    ConsoleKey key = input.Key;
    if (key == ConsoleKey.UpArrow) if(map[playerY -1, playerX] == ' ' || map[playerY -1, playerX] == 'E') playerY--;
    if (key == ConsoleKey.DownArrow) if(map[playerY +1, playerX] == ' ' || map[playerY +1, playerX] == 'E') playerY++;
    if(key == ConsoleKey.LeftArrow) if(map[playerY, playerX -1] == ' ' || map[playerY, playerX -1] == 'E') playerX--;
    if(key == ConsoleKey.RightArrow) if(map[playerY, playerX +1] == ' '|| map[playerY, playerX +1]  =='E') playerX++;

    }
  
    Thread.Sleep(30);
    if(map[playerY, playerX] == 'E')
    {
        Console.WriteLine("You win!");
        break;
    }
}
}

void Title(string title)
{
    int numerOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numerOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void Menu()
{
    bool gameMenu = true;
    while (gameMenu == true)
    {
        Console.Clear();
        Title("Console Labyrinth");
        Console.WriteLine("This game has 5 levels of difficulty, level 1 being the easiest. Please chose your challenge:\n");
        Console.WriteLine("- Level 1 -");
        Console.WriteLine("- Level 2 -");
        Console.WriteLine("- Level 3 -");
        Console.WriteLine("- Level 4 -");
        Console.WriteLine("- Level 5 -");
        Console.WriteLine("- Exit  6 -");
        int option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1: Console.WriteLine("- Level 1 -");
            break;
            case 2: Console.WriteLine("- Level 1 -");
            break;
            case 3: Console.WriteLine("- Level 1 -");
            break;
            case 4: Console.WriteLine("- Level 1 -");
            break;
            case 5: Console.WriteLine("- Level 1 -");
            break;
            case 6: Console.Clear();
            Console.WriteLine("Bye bye... :)");
            Thread.Sleep(2300);
            Console.Clear();
            gameMenu = false;
            break;
            default: Console.WriteLine("Error! Type a number between 1 and 6.");
            Thread.Sleep(2300);
            Console.Clear();
            break;
        }
    }
}

Menu();