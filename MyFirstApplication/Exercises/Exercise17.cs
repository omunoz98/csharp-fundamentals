namespace MyFirstApplication;
// Exercise 17 Exception Handling


/*
 Write a method that has two int parameters and no return type. You will use a try/catch for this method. 
Create a division problem in the try block. The catch block will utilize the DivideByZeroException. 
Provide a Console WriteLine messagefor both the try block and the catch block. 
The one in the try block should display the answer to the division problem. 
The one in the catch block should have a message using Interpolation along with a variable.Messagesyntax. 
Test the method with different numbers, including 0 so you can ensure the catch executes. 
 */
internal class Exercise17
{
    public void ExerciseMethod17(int width, int length)
    {
        try
        {
            Console.WriteLine(width / length);
        }
        catch (DivideByZeroException de)
        {
            Console.WriteLine($"The answer is height: {de.Message}");
        }
    }



    /*
     Write a method that has a horse parameter and no return type.
    Using and if statement, determine if your horse is null. 
    If it is null, use the throw keyword and a message to indicate it is null. 
    If the horse is not null, use a Console WriteLine statement to print out one of your horse properties.
     */

    public void Horse(string color)
    {
        if (color == null)
        {
            throw new ArgumentNullException("Horse color is null");
        }
        else
        {
            Console.WriteLine(color);
        }


    }



}
