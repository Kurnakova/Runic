namespace Runic.Helpful;
using Runic.Enums;

public static class SelectionUtil
{
    public static TSpellParameter SelectSpellParameter<TSpellParameter>(string parameterName, TSpellParameter SpellParameter)
        where TSpellParameter : Enum
        {
        string[] parameters = Enum.GetNames(typeof (TSpellParameter));
        Console.WriteLine($"Select {parameterName}:");
        for(int i = 0; i < parameters.Length; i++)
        {
            Console.WriteLine($"{i+1}. {parameters[i]}");
        }
        int a = 1;

        TSpellParameter selectedParameter = (TSpellParameter)a;
        
        return SpellParameter;
        }
    
}
