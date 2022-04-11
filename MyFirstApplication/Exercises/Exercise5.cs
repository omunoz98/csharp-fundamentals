namespace MyFirstApplication;

public class Exercise5
{
    /*
    Write a method that takes 2 int parameters and an int return type. 
    Using the formula below from Ohm’s law, determine the voltage. 
    The first method parameter will represent current and the second parameter will represent resistance. 
    Using the Func<int, int, int>and a lambda expression, determine the voltage calculation 
    and return the value.a.
    Voltage = Current x Resistance
    */
    public int Exercise5Method(int current, int resistance)
    {
        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        int value = voltage(current, resistance);

        return value;
    } // end of class

    // Write a method that will take 1 char parameter
    // and a string return type.Using a switch expression
    // and the table below, return the description.
    // If the value does not match the grade, return the default message, “Not a valid grade”

    public string ExerciseMethod5a(char input)
    {
        switch (input)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "not a valid grade";
        }
    }   
 // Write a method that takes 1 argument
 // and a void return type. Using a Relational Pattern and switch expression
 // determine a size of popcornbased on the table below and using a Console WriteLine,
 // print the popcorn size

    public void Exercise5Methodb(int size)
        {
              string sizes = size switch
                {
                    <= 3 => "Microwave bag",
                    <= 16 => "Movie sack",
                    <= 32 => "Movie cup",
                    <= 64 => "Movie tub",
                    _ => "We don't have that size"
                };
               Console.WriteLine(sizes);
        }

} // end class