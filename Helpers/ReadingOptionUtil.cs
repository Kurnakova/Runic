namespace Runic.Helpers;
using System.Security.Cryptography;

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
                Console.WriteLine("Invalid input.\n");
            }
            else
            {
                break;
            }
        }
        return name;
    }
}
