internal class Map
{
    public Map(char[,] grid, int timeLimit)
    {
        Grid = grid;
        TimeLimit = timeLimit;
    }
    public char[,] Grid { get;}
    public int TimeLimit { get;}

    // Automatic calculated dimensions from the matrix.
    public int Width => Grid.GetLength(0);
    public int Height => Grid.GetLength(1);

    //Verify if the indicated position has a wall.
    public bool IsWall(int X, int Y)
    {   
        return Grid[X, Y] == '█';
        
    }
    //Verify if the indicated position is the exit.
    public bool IsExit(int X, int Y)
    {
        return Grid[X, Y] == 'E';
        
    }

    //Draws the map on the console, verifying where the player.
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
    // Breaks the line on the end of each matrix.
    Console.WriteLine();
    }
    }
}