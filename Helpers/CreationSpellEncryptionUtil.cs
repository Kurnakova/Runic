namespace Runic.Helpers;
using Runic.Models;
using Runic.Enums;
using System.Diagnostics.Tracing;

public static class CreationSpellEncryptionUtil
{
    
    public static void EncriptCreationSpell(SpellBook mySpellBook)
    {
        Corporeality corporeality = EnumSelectionUtil.SelectSpellParameter<Corporeality>("corporeality", Corporeality.Illusionary);
        Material material = EnumSelectionUtil.SelectSpellParameter<Material>("material", Material.Air);
        Shape shape = EnumSelectionUtil.SelectSpellParameter<Shape>("shape", Shape.Ball);
        string customShape = "none";
        if(shape == Shape.Custom)
        {
            Console.WriteLine("Type in name of your shape:");
            customShape = ReadingOptionUtil.ReadNonNullStringOption();
        }
        if(mySpellBook.CreationSpells.Exists(
            i => i.Corporeality == corporeality
            && i.Material == material
            && i.Shape == shape
            && i.CustomShape == customShape)
            )
        {
            CreationSpell encryptedSpell = mySpellBook.CreationSpells.Find(
            i => i.Corporeality == corporeality
            && i.Material == material
            && i.Shape == shape);
            Console.WriteLine($"You have encrypted spell: {encryptedSpell.Name}!");
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
                    AddNewCreationSpell(ref mySpellBook.CreationSpells, corporeality, material, shape, customShape);
                    break;
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

    static void AddNewCreationSpell(
    ref List<CreationSpell> list,
    Corporeality corporeality,
    Material material,
    Shape shape,
    string customShape = "none")
    {
        Console.WriteLine("Your spell creates an object that is:");
        Console.WriteLine($"- {corporeality}");
        Console.WriteLine($"- made of {material}");
        string newShape = shape == Shape.Custom ? customShape : shape.ToString();
        Console.WriteLine($"- shaped as {newShape}");
        Console.WriteLine("What would you like to call it?");
        string name = ReadingOptionUtil.ReadNonNullStringOption();
        list.Add(new CreationSpell(name, corporeality, material, shape, customShape));
        Console.WriteLine($"Congrats! A new creation spell, {name}, was added to your spell book.");
    }
}
