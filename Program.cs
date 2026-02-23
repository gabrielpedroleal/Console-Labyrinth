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

while(true) 
{   
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
    
    ConsoleKeyInfo input = Console.ReadKey(true);
    ConsoleKey key = input.Key;
    if (key == ConsoleKey.UpArrow) if(map[playerY -1, playerX] != '#') playerY--;
    if (key == ConsoleKey.DownArrow) if(map[playerY +1, playerX] != '#') playerY++;
    if(key == ConsoleKey.LeftArrow) if(map[playerY, playerX -1] != '#') playerX--;
    if(key == ConsoleKey.RightArrow) if(map[playerY, playerX +1] != '#') playerX++;


    if(map[playerY, playerX] == 'E')
    {
        Console.WriteLine("You win!");
        break;
    }
}