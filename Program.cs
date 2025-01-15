using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Runic.Enums;
using Runic.Helpers;
using Runic.Models;

SpellBook mySpellBook = new SpellBook();
Console.WriteLine("Let's encript a spell! Choose type:");
Console.WriteLine("1. Creation spell");
string option = ReadingOptionUtil.ReadNonNullStringOption();
while(true)
{
    if(option == "1")
    {
        CreationSpellEncryptionUtil.EncriptCreationSpell(mySpellBook);
    }
    break;
}
