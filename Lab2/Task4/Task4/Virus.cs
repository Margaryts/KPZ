using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string type, double weight, int age)
    {
        Name = name;
        Type = type;
        Weight = weight;
        Age = age;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clone = new Virus(Name, Type, Weight, Age);
        foreach (var child in Children)
        {
            clone.AddChild((Virus)child.Clone()); 
        }
        return clone;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name} ({Type}), Age: {Age}, Weight: {Weight}");
        foreach (var child in Children)
        {
            child.Print(indent + "  ");
        }
    }
}
