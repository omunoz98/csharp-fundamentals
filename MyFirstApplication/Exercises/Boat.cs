namespace MyFirstApplication;
// Exercise 10, encapsulation with using Expression Body Def Properties


// Create a class based on your Boat object. You will follow the same instructions as exercise 1except for the following.
// Include your attributes as Expression Body Definition Properties.




public class Boat
{
    private string _color;
    private string _type;
    private string _wheel;

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
    public string Wheel
    {
        get => _wheel;
        set => _wheel = value;
    }
    public Boat(string color, string type, string wheel)
    {
        Color = color;
        Type = type;
        Wheel = wheel;
    }

    public Boat()
        :this($"White", "Sailboat", "Big Wheel") { }

    public virtual void BoatMethod()
    {
        Console.WriteLine($"the new boat color is {Color}");
    }



    public void BoatMethod()
    {
        Console.WriteLine($"The color of the boat is {Color}");
    }

}
