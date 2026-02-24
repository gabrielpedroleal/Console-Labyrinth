internal class Game 
{
public Game (Map map)
    {
        CurrentMap = map;
    }
private Player Player  = new Player();
private Map CurrentMap;
private bool IsRunning = true;
private DateTime Start;

//Calculate how many seconds left the player has.
private int GetSecondsLeft()
    {
        int secsPassed = (int)(DateTime.Now - Start).TotalSeconds;
        return CurrentMap.TimeLimit - secsPassed;
    }
//Capture the key and sends to the Player movement method.
private void ProcessInput()
    {
        var key = Console.ReadKey(true).Key;
        if(key == ConsoleKey.UpArrow) Player.Move(0,-1,CurrentMap);
        if(key == ConsoleKey.DownArrow) Player.Move(0,1,CurrentMap);
        if(key == ConsoleKey.LeftArrow) Player.Move(-1,0,CurrentMap);
        if(key == ConsoleKey.RightArrow) Player.Move(1,0,CurrentMap);
    }
//Verify the conditions of winning or loosing.
private void Update()
    {
        if(GetSecondsLeft() <= 0)
    {
        Thread.Sleep(1500);
        Console.Clear();
        UI.Title("Game Over");
        Thread.Sleep(2500);
        Console.Clear();
        IsRunning = false;
    }
   if (CurrentMap.IsExit(Player.PlayerY, Player.PlayerX))
        {
            Thread.Sleep(1500);
            Console.Clear();
            UI.Title("You win!");
            Thread.Sleep(2500);
            IsRunning = false;
        }
    }
//Draws the map and time in the console screen.
private void Render()
    {
        Console.Clear();
        UI.Title($"TIME LEFT: {GetSecondsLeft()}s");
        CurrentMap.DrawMap(Player.PlayerX,Player.PlayerY);
    }
// Where the magic happens... :D
public void Run()
    {   
        Start = DateTime.Now;
        while (IsRunning)
        {
            Render();
            ProcessInput();
            Update();
        }
    }
}