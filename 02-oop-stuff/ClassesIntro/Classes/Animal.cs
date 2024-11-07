using System.Reflection.Metadata.Ecma335;

namespace ClassesIntro.Classes;

public class Animal
{
    private string _name;

    public string Name
    {
        get {
            return _name;
        }
        set {
            _name = value;
        }
    }

    public string Type { get; set; }

    public Animal(string name, string type) 
    {
        Name = name;
        Type = type;
    }
}
