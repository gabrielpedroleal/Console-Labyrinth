internal static class UI
{
 public static void Title(string title)
{
    int numerOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numerOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}
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
