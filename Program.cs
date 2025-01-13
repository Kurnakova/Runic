using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Runic.Enums;
using Runic.Helpful;
using Runic.Models;

Console.WriteLine("Let's encript a spell! Choose type:");
Console.WriteLine("1. Creation spell");
string option = ReadingOptionUtil.ReadNonNullStringOption();
while(true)
{
    if(option == "1")
    {
        EncriptCreationSpell();
    }
    break;
}
void EncriptCreationSpell()
{
    Corporeality corporeality = SelectionUtil.SelectSpellParameter<Corporeality>("corporeality", Corporeality.Illusionary);
    Material material = SelectionUtil.SelectSpellParameter<Material>("material", Material.Gold);
    Shape shape = SelectionUtil.SelectSpellParameter<Shape>("shape", Shape.Ball);
}
