
using System.Runtime.InteropServices.Marshalling;
using Runic.Enums;

namespace Runic.Models;

public class Spell
{
    private protected readonly string _name;

    public Spell(string name)
    {
        _name = name;
    }
}
