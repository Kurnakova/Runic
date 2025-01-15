using System.Dynamic;
using Runic.Enums;
using Runic.Models;
public class SpellBook
{
    public List<CreationSpell> CreationSpells = new List<CreationSpell>
    {
        new CreationSpell("Breathing Bubble", Corporeality.Corporeal, Material.Air, Shape.Ball),
        new CreationSpell("Earth Protection", Corporeality.Corporeal, Material.Earth, Shape.Shield),
        new CreationSpell("Enrichment", Corporeality.Corporeal, Material.Gold, Shape.Ingot),
        new CreationSpell("Fire Strike", Corporeality.Corporeal, Material.Fire, Shape.Burst),
        new CreationSpell("Ghastly Light", Corporeality.Illusionary, Material.Light, Shape.Ball),
        new CreationSpell("Tame Flame", Corporeality.Illusionary, Material.Fire, Shape.Ball),
        new CreationSpell("Waterfall", Corporeality.Corporeal, Material.Water, Shape.Burst)
    };
    public SpellBook()
    {

    }
}