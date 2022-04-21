namespace MyFirstApplication;
// Exercise 11 inheritance


/* Create a child class based on your Boat object.
 You will follow the same instructions as exercise 1 except for the following.
 Include 1 childattribute as Expression Body Definition Properties. */
public class Sailboat : Boat 
{
    private string _materials;

    public string Material
    {
        get => _materials;
        set => _materials = value;

    }


    public Sailboat(string size, string materials, string wheel, string sizeCenterboard)
        :base(size, materials, wheel)
    {
        _materials = materials;
    }

    public Sailboat(string size, string materials, string wheel)
        :this("Big", "fiberglass", "big board") { }

    public override void BoatMethod(string color)
    {
        Console.WriteLine($"the sailboat is {color}");
    }

    public void BoatMethod()
    {
        Console.WriteLine($"The new boat is {color}");
    }



}

