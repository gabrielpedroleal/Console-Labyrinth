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
    int secsLeft = 30 - secsPassed;
    if(secsLeft <= 0)
    {
        Console.WriteLine("Game Over!");
        break;
    }

    Console.Clear();
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