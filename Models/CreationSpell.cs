using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;
using Runic.Enums;

namespace Runic.Models;

public class CreationSpell
{
    string Name {get;}
    Corporeality Corporeality {get;}
    Material Material {get;}
    Shape Shape {get;}

    public CreationSpell(string name, Corporeality corporeality, Material material, Shape shape)
    {
        Name = name;
        Corporeality = corporeality;
        Material = material;
        Shape = shape;
    }
}
