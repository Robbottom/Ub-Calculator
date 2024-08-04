using System;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml;

class Program
{



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon to Ultra Beast calculator! (press enter to continue)");
            Console.ReadKey();

            int HP = GetStat("HP");
            int ATK = GetStat("ATK");
            int DEF = GetStat("DEF");
            int SPATK = GetStat("SPATK");
            int SPDEF = GetStat("SPDEF");
            int SPE = GetStat("SPE");
        Output.OutputStats(HP, ATK, DEF, SPATK, SPDEF, SPE);
        Export.SaveStatsToFile(HP, ATK, DEF, SPATK, SPDEF, SPE);
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
        static int GetStat(string statName)
        {
            Console.WriteLine($"Enter {statName}:");
            string? input = Console.ReadLine();
            int stat = int.Parse(input);
            return stat;
        }
    }

    class PrimeNumbers
    {
        public static int RoundUpToPrime(int number)
        {
            if (number < 2)
            {
                return 2; // The smallest prime number is 2
            }

            int candidate = number;
            while (!IsPrime(candidate))
            {
                candidate++;
            }

            return candidate;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
class Output
{
    public static void OutputStats(int HP, int ATK, int DEF, int SPATK, int SPDEF, int SPE)
    {
        int roundedHP = PrimeNumbers.RoundUpToPrime(HP);
        int roundedATK = PrimeNumbers.RoundUpToPrime(ATK);
        int roundedDEF = PrimeNumbers.RoundUpToPrime(DEF);
        int roundedSPATK = PrimeNumbers.RoundUpToPrime(SPATK);
        int roundedSPDEF = PrimeNumbers.RoundUpToPrime(SPDEF);
        int roundedSPE = PrimeNumbers.RoundUpToPrime(SPE);

        WriteAllStats(roundedHP, roundedATK, roundedDEF, roundedSPATK, roundedSPDEF, roundedSPE);
    }

    private static void WriteAllStats(int roundedHP, int roundedATK, int roundedDEF, int roundedSPATK, int roundedSPDEF, int roundedSPE)
    {
        Console.WriteLine($"Converted HP: {roundedHP}");
        Console.WriteLine($"Converted ATK: {roundedATK}");
        Console.WriteLine($"Converted DEF: {roundedDEF}");
        Console.WriteLine($"Converted SPATK: {roundedSPATK}");
        Console.WriteLine($"Converted SPDEF: {roundedSPDEF}");
        Console.WriteLine($"Converted SPE: {roundedSPE}");
    }
}


