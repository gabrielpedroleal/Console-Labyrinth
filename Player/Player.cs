internal class Player
{
    public Player()
    {
        PlayerX = 1;
        PlayerY = 1;
    }

    public int PlayerX {get; private set;}
    public int PlayerY {get; private set;}

    public void Move(int X, int Y, Map map)
    {
        int newPositionX = PlayerX + X;
        int newPositionY = PlayerY + Y;
        if (!map.IsWall(newPositionY, newPositionX))
        {
            PlayerY = newPositionY;
            PlayerX = newPositionX;
            
        }
    }
      }