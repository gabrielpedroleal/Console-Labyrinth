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
private List<Map> maps = new List<Map>();

private void Title(string title)
{
    int numerOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numerOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}
private int GetSecondsLeft()
    {
        int secsPassed = (int)(DateTime.Now - Start).TotalSeconds;
        return CurrentMap.TimeLimit - secsPassed;
    }
private void ProcessInput()
    {
        var key = Console.ReadKey(true).Key;
        if(key == ConsoleKey.UpArrow) Player.Move(0,-1,CurrentMap);
        if(key == ConsoleKey.DownArrow) Player.Move(0,1,CurrentMap);
        if(key == ConsoleKey.LeftArrow) Player.Move(-1,0,CurrentMap);
        if(key == ConsoleKey.RightArrow) Player.Move(1,0,CurrentMap);
    }
private void Update()
    {
   if (CurrentMap.IsExit(Player.PlayerY, Player.PlayerX))
        {
            Thread.Sleep(1500);
            Console.Clear();
            Title("You win!");
            Thread.Sleep(2500);
            IsRunning = false;
        }
    if(GetSecondsLeft() <= 0)
    {
        Thread.Sleep(1500);
        Console.Clear();
        Title("Game Over");
        Thread.Sleep(2500);
        Console.Clear();
        IsRunning = false;
    }
    }
private void Render()
    {
        Console.Clear();
        Title($"TIME LEFT: {GetSecondsLeft()}s");
        CurrentMap.DrawMap(Player.PlayerX,Player.PlayerY);
    }
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