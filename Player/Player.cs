internal class Player
{
    public Player()
    {
        PlayerX = 1;
        PlayerY = 1;
    }

    public int PlayerX {get; private set;}
    public int PlayerY {get; private set;}

    //Process the atempt of movement verifying any collisions on the current map.
    public void Move(int X, int Y, Map map)
    {
        int newPositionX = PlayerX + X;
        int newPositionY = PlayerY + Y;
        //Only uptade the position if destiny is not a wall.
        if (!map.IsWall(newPositionY, newPositionX))
        {
            PlayerY = newPositionY;
            PlayerX = newPositionX;
            
        }
    }
      }