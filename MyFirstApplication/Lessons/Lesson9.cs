namespace MyFirstApplication;

// access modifiers
internal class Lesson9
{
    private int _value = 10;
    /*
     Private access modifier can only be seen within the class, struct or nested type
     */
    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     Protect access modifier can only be seen within the type or a child(derived) class.
     */
    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected");
    }
    /*
     Internal access modifier can be seen within the assembly, not others
     */
    internal void SampleInternal()
    { 
        Console.WriteLine("This method is internal");
    }



    public class Nested
    {

        public Nested(Lesson9 parent)
        {
            Console.WriteLine($"The value is {parent._value}");
        }

    }// end nested class
}
