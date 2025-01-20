using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;
using Runic.Enums;

namespace Runic.Models;

public class CreationSpell
{
    public string Name {get;}
    public Corporeality Corporeality {get;}
    public Material Material {get;}
    public Shape Shape {get;}
    public string CustomShape {get;}

    public CreationSpell(string name, Corporeality corporeality, Material material, Shape shape, string customShape = "none")
    {
        Name = name;
        Corporeality = corporeality;
        Material = material;
        Shape = shape;
        CustomShape = customShape;
    }
}
