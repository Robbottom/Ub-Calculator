using System;
using System.IO;

public class Export
{
    public static void SaveStatsToFile(int roundedHP, int roundedATK, int roundedDEF, int roundedSPATK, int roundedSPDEF, int roundedSPE)
    {
        // Define a relative file path
        string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output");
        string filePath = Path.Combine(directoryPath, "PokemonStats.txt");

        // Ensure the directory exists
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Write stats to file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Converted HP: {roundedHP}");
            writer.WriteLine($"Converted ATK: {roundedATK}");
            writer.WriteLine($"Converted DEF: {roundedDEF}");
            writer.WriteLine($"Converted SPATK: {roundedSPATK}");
            writer.WriteLine($"Converted SPDEF: {roundedSPDEF}");
            writer.WriteLine($"Converted SPE: {roundedSPE}");
        }

        Console.WriteLine($"Stats have been saved to {filePath}");
    }
}
