namespace MyFirstApplication;
// Exercise 11 Inheritance 


/*
 Create a child class based on your Horse object. 
Include one child attribute as an auto property. Create 3 constructors. 
The first constructor should have 4 parameters with 3 of them from Horse and your child property. 
Using the keyword :base(),you will put the four horse parameters in theparenthesis. 
In the body of the constructor you will assign your child parameter to your property. 
The second constructorshould have 2 parameters, 2 based on the horse and 1 from your child. 
Using the :this()keyword, you will pass 2 of the parent attributes and your child attribute information to the first constructor.
Include default values to represent the 2 remaining horse parameters. 
For the last constructor, you will create the default constructor. 
Using the :this()keyword, you will pass 2 default values in that will pass to the 2nd constructor. 
Also include in the class, your method for your child class
 */
public class Donkey : Horse
{
    
    public string EyeColor { get; set; }

    public Donkey(string noseSize, string eyeColor, string tail, string size)
        :base(noseSize, eyeColor, size)
    {
        EyeColor = eyeColor;
    }

    public Donkey(string noseSize, string size, string color)
        :this(noseSize, size, color, null) { }


    public Donkey()
        :this("big nose", "short", "grey") { }

    public override void HorseMethod(string size)
    {
        Console.WriteLine($"The donkey is {size}");
    }
    public void HorseMethod()
    {
        Console.WriteLine($"The donkey is {Size} compared to the horse");
    }

}