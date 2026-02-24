internal class Map
{
    public Map(char[,] grid, int timeLimit)
    {
        Grid = grid;
        TimeLimit = timeLimit;
    }
    public char[,] Grid { get;}
    public int TimeLimit { get;}
    public int Width => Grid.GetLength(0);
    public int Height => Grid.GetLength(1);

    public bool IsWall(int X, int Y)
    {   
        return Grid[X, Y] == '█';
        
    }
    public bool IsExit(int X, int Y)
    {
        return Grid[X, Y] == 'E';
        
    }

    public void DrawMap(int playerX, int playerY)
    {
        for(int X = 0; X < Width; X++)
    {
        for(int Y = 0; Y < Height; Y++)
        {
            if(X == playerY && Y == playerX)
        {
            Console.Write('☺');
        } else
        {
            Console.Write(Grid[X, Y]);
        }
        }
        
    Console.WriteLine();
    }
    }
}