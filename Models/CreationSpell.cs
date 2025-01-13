using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;
using Runic.Enums;

namespace Runic.Models;

public class CreationSpell
{
    string _name;
    Corporeality _corporeality;
    Material _material;
    Shape _shape;

    public CreationSpell(string name, Corporeality corporeality, Material material, Shape shape)
    {
        _name = name;
        _corporeality = corporeality;
        _material = material;
        _shape = shape;
    }
}
