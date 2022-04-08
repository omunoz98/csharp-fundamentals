namespace MyFirstApplication;

/*
    
    This lesson goes over Expressions & Pattern Matching. 
    It will also include an intro to delegates. 
    
 */
internal class Lesson5
{

    // Delegate
    public delegate void Del(string message);

    /*
     The is operator checks if the result of an expression is 
    compatible with another type.
     */
    public void IsOperatorExample(int able)
    {
        object bravo = able;
        Console.WriteLine(bravo is int);
        Console.WriteLine(bravo is long);
    }

    /*
     Create a method for delegate example
     */
    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    /*
     Method for Func delegate
     */
    public int Sum(int beta)
    {
        return beta * 2;
    }

    /*
     Lambda using the Func Delegate
     */

    public void LambdaSquare()
    {
        Func<int, int> square = able => able * able; 


        Console.Write(square(4));
    }

    /*
     Lambda using the action delegate
     */
    public void LambdaGreeting()
    {
        Action<string> greet = name =>
        {
            string greeting = $"Hello{name}! We are learning";
            Console.WriteLine(greeting);
        };

        greet("Lambda");


    }
    /* Basic switch*/
    public string BasicSwitch(string able)
    {

        switch (able)
        {
            case "blue":
                return "favorite color is blue";
            case "red":
                return "favorite color is red";
            case "green":
                return "favorite color is green";
            default:
                return "not sure";
        }

    }
    
    /*
     Switch Expression based on above switch
     */
    public string FavoriteColor(string charlie)
    {
        string result = charlie switch
        {
            "blue" => "favorite color is blue",
            "red" => "favorite color is red",
            "green" => "favorite color is green",
              _ => "Not sure"
        };
    
        return result;
    
    }
    /*
   Relational Pattern compares an expression result with a constant
   */

    public void DrinkSize(int size)
    {
        string result = size switch
        {
            <= 20 => "Can",
            <= 32 => "Bottle",
            <= 64 => "Big Gulp",
            _ => "We dont that size."
        };
        Console.WriteLine(result);
    }


    /*
     Logical pattern and matches an expression when both patterns 
    match the expression
     */
    public void TemperatureGuide(double temp)
    {
        string result = temp switch
        {
            < -10.0 and < 0 => "Negative Cold",
            >= 0 and < 32.0 => "Freezing Cold",
            >= 32.0 and < 49.0 => "Cold",
            >= 49.0 and < 69.0 => "Warm",
            >= 60.0 and < 90.0 => "Nice",
            >= 90.0 and < 105.0 => "Too hot",
            _ => "Unknown"
        };
        Console.WriteLine(result);

    }
    /*
     Logical Pattern OR matches an expression when either pattern matches the expression.
     */
    public void NumberChoice(int able)
    {
        string result = able switch
        {
            1 or 2 => $"{able} is 1 or 2",
            3 or 4 => $"{able} is 3 or 4",
            5 => $"{able} is 5",
            _ => $"{able} was not on the list"
        };
        Console.WriteLine(result);

    }


} // end class 
