internal static class GetStatHelpers
{
    // This method is now public and has a method body
    public static string GetStat(string statName)
    {
        Console.WriteLine($"Enter {statName}:");
        return Console.ReadLine();
    }
}
