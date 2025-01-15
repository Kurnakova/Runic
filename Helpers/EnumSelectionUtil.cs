namespace Runic.Helpers;

public static class EnumSelectionUtil
{
    public static TSpellParameter SelectSpellParameter<TSpellParameter>(string parameterName, TSpellParameter defaultParameter)
        where TSpellParameter : Enum
        {
        string[] parameters = Enum.GetNames(typeof (TSpellParameter));
        Console.WriteLine($"Select rune of {parameterName}:");
        for(int i = 0; i < parameters.Length; i++)
        {
            Console.WriteLine($"{i+1}. {parameters[i]}");
        }
        int option;

        while (true)
    {
        var input = ReadingOptionUtil.ReadNonNullStringOption();
        if (int.TryParse(input, out option))
        {
            if (option >= 1 && option <= (parameters.Length+1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorect number.");
            }
        }
        else
        {
            Console.Write("Invalid Input.\n");
        }
    }

    for(int i = 0; i < parameters.Length; i++)
    {
        if(i+1 == option)
        {
            string stringValue = parameters[i];
            return (TSpellParameter)Enum.Parse(typeof(TSpellParameter), stringValue);
        }
    }
        return defaultParameter;
    }
}
