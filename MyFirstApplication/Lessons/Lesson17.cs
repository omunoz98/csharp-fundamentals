namespace MyFirstApplication;
// Lesson 17
internal class Lesson17

{
    public void MyThrowExample(House house)
    {
        if (house == null)
        {
            throw new NullReferenceException("House object is null");
        }
        else
        {
            Console.WriteLine(house.DoorColor);
        }

    }

    
    // This example will use a try and catch
    public void MyExceptionExample(House house)
    {
        try
        {
            Console.WriteLine($"The house door color is {house.DoorColor}");
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine($"Null Reference was thrown: {ex.Message}");
        }
    }

    // Try catch finally exception/blocks used to evaluate an array and parsing 
    public void MyArrayException()
    {
        string[] names = { "David", "Matt", "Jody" };
        string[] values = { "257", "254", "385" };

        try
        {
            byte beta = byte.Parse(values[3]);
            Console.WriteLine(beta);
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Please provide at least one argument: {ex.Message}");
        }
        catch(FormatException fe)
        {
            Console.WriteLine($"That is not a number: {fe.Message}");
        }
        catch(OverflowException oe)
        {
            Console.WriteLine($"You have given me more than a byte: {oe.Message}");
        }
        finally
        {
            Console.WriteLine($"finally block is executed");
        }



    }














} //end class



