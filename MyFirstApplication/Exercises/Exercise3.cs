
namespace MyFirstApplication;



public class ExerciseMethod3
{
    // Objective 1:
    public int Excerise3a(int arg)
    {
        int arg1 = 15;
        int arg2 = 456;
        int arg3 = 23;
        int arg4 = 89;
        int arg5 = 245;
        Console.WriteLine(arg1 % arg);
        Console.WriteLine(arg2 % arg);
        Console.WriteLine(arg3 % arg);
        Console.WriteLine(arg4 % arg);
        return (arg5 % arg);
    }

    // Objective 2
    public void Exercise3b()
    {
        int val1 = 10, val2 = 32, val3 = 12, val4 = 3;
        Console.WriteLine(val1 + val2 * val3 / val4);
        Console.WriteLine(val2 * val3 / val4 + val1);
        Console.WriteLine(val2 * val3 / val4 + val4); 

    }

    // Objective 3
    public void Exercise3c(int value1, int value2)
    {
        value1 += value2;
        Console.WriteLine(value1);
        value1 /= value2;
        Console.WriteLine(value1);
        value1 *= value2;
        Console.WriteLine(value1);
        value1 %= value2;
        Console.WriteLine(value1);
    }

    // Objective 4
    public void Exercise3d(bool argument, bool argument1)
    {
        Console.WriteLine(argument & argument1);
        Console.WriteLine(argument | argument1);
        Console.WriteLine(argument ^ argument1);
        Console.WriteLine(argument || argument1);
        Console.WriteLine(10 > 5 && 10 < 5);
        Console.WriteLine(10 < 5 || 5 > 10);
        Console.WriteLine(10 > 5 ^ 5 < 10);
        Console.WriteLine(5 > 10 | 5 < 10);
    }
 
}
