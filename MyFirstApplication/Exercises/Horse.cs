namespace MyFirstApplication;
// Exercise 10 Horse,encapsulation 

// Create a class based on your Horse object. Include your attributes as auto properties.
// Create 3 constructors.
// The first constructor should have parameters equal to your properties.
// Assign each parameter to your properties. The second constructor should have 2 parameters.
// Using the :this() keyword, you will pass your information to the first constructor.
// This includes the 2 parameters and default values. For the last constructor, you will createthe default constructor.
// Using the :this()keyword, you will pass 2 default valuesin that will pass to the 2nd constructor.
// Also include in the class, your method for Horse.
public class Horse
{
    public string Color { get; set; }
    public string Size { get; set; }
    public string Tail { get; set; }

    public Horse(string color, string size, string length)
    {
        Size = size;
        Tail = color;
        Tail = length;
        
    }

    public Horse()
        :this ("Brown", "Tall","Long" ) { }


    public void HorseMethod()
    {
        Console.WriteLine($"The new horse is {Size}");
    }


}
