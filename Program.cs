using System.Collections.Generic;
//Grab the maps
List<Map> maps = LevelData.GetLevels();

bool MenuRunning = true;
void Menu()
{
    while (MenuRunning)
    {
        Console.Clear();
        UI.Title("Console Labyrinth");
        Console.WriteLine("This game has 5 levels of difficulty, level 1 being the easiest. Please chose your challenge:\n");
        Console.WriteLine("- Level 1 -");
        Console.WriteLine("- Level 2 -");
        Console.WriteLine("- Level 3 -");
        Console.WriteLine("- Level 4 -");
        Console.WriteLine("- Level 5 -");
        Console.WriteLine("- Exit  6 -");
        int option = UI.IntValidation();

        if(option >= 1 && option <= 5)
        {
            //Creates a new game instance for the selected level and starts the level.
            Game game = new Game(maps[option -1]);
            game.Run();
        } else if(option == 6)
        {   Console.Clear();
            Console.WriteLine("Bye bye... :)");
            Thread.Sleep(2500);
            MenuRunning = false;
        }
        
    }
}

Menu();