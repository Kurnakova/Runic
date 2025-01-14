using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Runic.Enums;
using Runic.Helpful;
using Runic.Models;

SpellBook mySpellBook = new SpellBook();
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
    Material material = SelectionUtil.SelectSpellParameter<Material>("material", Material.Air);
    Shape shape = SelectionUtil.SelectSpellParameter<Shape>("shape", Shape.Ball);
    if (mySpellBook.CreationSpells.Exists(
        i => i.Corporeality == corporeality
        && i.Material == material
        && i.Shape == shape)
        )
    {
        CreationSpell spells = mySpellBook.CreationSpells.Find(
        i => i.Corporeality == corporeality
        && i.Material == material
        && i.Shape == shape);
    }
    else
    {
        Console.WriteLine("This spell is not yet known to the magical science! Would you like to create it? \nY/N");
        string option;
        while(true)
        {
            option = ReadingOptionUtil.ReadNonNullStringOption();
            if(option == "Y")
            {
                AddNewCreationSpell(ref mySpellBook.CreationSpells, corporeality, material, shape);
            }
            else if(option == "N")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}

void AddNewCreationSpell(ref List<CreationSpell> list, Corporeality corporeality, Material material, Shape shape)
{
    Console.WriteLine("Your spell creates an object that is:");
    Console.WriteLine($"- {corporeality}");
    Console.WriteLine($"- made of {material}");
    Console.WriteLine($"- shaped as {shape}");
    Console.WriteLine("How would you like to call it?");
    string name = ReadingOptionUtil.ReadNonNullStringOption();
    list.Add(new CreationSpell(name, corporeality, material, shape));
    Console.WriteLine($"Congrats! A new creation spell, {name}, was added to your spell book.");
}
