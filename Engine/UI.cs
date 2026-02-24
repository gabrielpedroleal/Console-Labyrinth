internal static class UI
{
//Draws a title centralized by lines of asterisks (So it looks a little better... :D)
 public static void Title(string title)
{
    int numerOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numerOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}
//Grants that the user types only valid numbers, avoiding crashes.
public static int IntValidation()
{
    int result;
    while(!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("Erro! Digite apenas números.");
        Console.Write("Tente novamente: ");
    }
    return result;
}
}
