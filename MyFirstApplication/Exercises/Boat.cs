namespace MyFirstApplication;
// Exercise 10, encapsulation with using Expression Body Def Properties


// Create a class based on your Boat object. You will follow the same instructions as exercise 1except for the following.
// Include your attributes as Expression Body Definition Properties.




internal class Boats
{
    private string _color;
    private string _type;
    private string _size;

    public string Color
    {
        get => _color;
        set => _color = value;
    }

    public string Type
    {
        get => _type;
        set => _type = value;
    }

    public Boats(string color, string type)
    {
        Color = color;
        Type = type;
    }

    public Boats()
        :this($"White", "Sailboat") { }

    public void BoatMethod()
    {
        Console.WriteLine($"The color of the boat is {Color}");
    }

}
