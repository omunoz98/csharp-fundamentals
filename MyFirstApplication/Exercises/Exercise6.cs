namespace MyFirstApplication;
// Exercise 6 Constructors and Methods
internal class Exercise6
/* Write a constructor for your exercise file that takes 2 parameters.
 The first parameter should have an int type and a variable name of showSize.
 The second parameter should have a string type and a variable name of shoeType.
 Create private class variables for these types and use an underscore when defining them.
 Inside the constructor associate the class variables with the constructor parameters. */
{

    private string _type;
    private int _size;

    public void ExerciseMethod6(int showSize, string shoeType)
    {

        _type = shoeType;
        _size = showSize;
        Console.WriteLine($" shoe is {shoeType} and size is {showSize}");
    }

    /* Write the properties for the class variables
    defined in exercise 1.
    Ensure they are labeled as public and are spelled using a capital letter */
    public string _shoeType
    {
        get { return _type; }
        set { _type = value; }
    }
    public int _showSize
    {
        get { return _size; }
        set { _size = value; }
    }
    /*  Write a delegate that takes a string parameter.
      This delegate should be named TryOn. 
      Write a method that takes a string argument and void return type.
      In the method body include a Console WriteLine statement that will print the message. 
      Test your delegate in Program.cs to ensure everything works properly.
      Using a mult-line comment on your Exercise6.cs file, provide the information you used to test the delegate */

    public delegate void TryOn (string type);
    public void shoesize (string message)
    {
        Console.WriteLine(message);
    }

}