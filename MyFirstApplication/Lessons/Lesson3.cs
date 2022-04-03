

namespace MyFirstApplication;

/*
 This lesson goes over Operators and Overflo checking
 */
internal class Lesson3
{

    // Check this keyword will produce an error if values exceed max or min capacity
    public void BasicCheckedOperator(int val)
    {
        int total = checked(2147483647 + val);
        Console.WriteLine(total);
    }

    public void BasicCheckedExample2()
    {
        int able = 10;
        checked
        {
            int total = 2147483647 + able;
            Console.WriteLine(total);
        }
    }
   

    // Unchecked will remove the Exception from constant values
    public void BasicUncheckedExamples()
    {
        int total = unchecked(Int32.MaxValue + 10);
        Console.WriteLine(total);
    }

    // Arithmetic Operator 
    public void BasicMath()
    {
        int able = 20, beta = 10;

        int addTotal = able + beta;
        int subtractTotal = able - beta;
        int multipyTotal = able * beta;
        int divideTotal = able / beta;

        Console.WriteLine($"Addition = {addTotal}, Subtraction {subtractTotal}");
        Console.WriteLine($"Multiplication = {multipyTotal}, Division = {divideTotal}");
    }

    // Modulus Operator
    public void BasicModulus(int beta)
    {
        int total = 10 % beta;
        Console.WriteLine(total);

        Console.WriteLine(+24);
        Console.WriteLine(-345);

    }

    // Boolean Logical Operators
    public void BasicBooleanLogical(bool arg, bool arg2)
    {
        // And
        Console.WriteLine(arg & arg2);
        // Or
        Console.WriteLine(arg | arg2);
        // Exclusive Or
        Console.WriteLine(arg ^ arg2);
        // &&
        Console.WriteLine(23 > 10 && 10 < 5);
        // ||
        Console.WriteLine(23 > 10 || 10 < 7);

    }
    // Compound Assignment Operators 
    public void BasicCompoundExample(int val1, int val2, int val3)
    {
        // val1 = 12, val2 = 35
        // same as val1 = val1 + val2 or val1 = 12 + 35
        val1 += val2;
        Console.WriteLine(val1);

        val2 += (val3 + val1);
        Console.WriteLine(val2);
    }
        // Relational operators
     public void BasicRelationalExample(string name, string beta)
     {
        Console.WriteLine(name == beta);
        Console.WriteLine(name != beta);

     }
 
}

// end class


