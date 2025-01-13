using System.Security.Cryptography;

namespace Runic.Helpful;

public static class ReadingOptionUtil
{
    public static string ReadNonNullStringOption()
    {
        string? name;
        while (true)
        {
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                break;
            }
        }
        return name;
    }
}