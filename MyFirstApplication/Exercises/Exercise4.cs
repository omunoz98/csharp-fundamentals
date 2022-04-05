
namespace MyFirstApplication;

public class Exercise4
{
    // objective 1 
    public void Exercise4A(int arg, int arg2)
    {
        if (arg2 <= 5)
        {
            Console.WriteLine($"{arg2} is less or equal to 5");
        }
        if (arg == 5)
        {
            Console.WriteLine($"{arg} is equal to 5");
        }
        else
        {
            Console.WriteLine($"{arg2} {arg} was less 5");
        }
    }   // end of class

    // objective 2 
    public void Exercise4B(int grade)
    {
        foreach(char description in "grade")
        {
            switch (grade)
            {
                case 1:
                case 2:
                    Console.WriteLine($"{grade} E == Excellent");
                    break;
                case 3:
                    Console.WriteLine($"{grade} V == Very Good");
                    break;
                case 4:
                    Console.WriteLine($"{grade} G == Good");
                    break;
                case 5:
                    Console.WriteLine($"{grade} A == Average");
                    break;
                case 6:
                    Console.WriteLine($"{grade} F == Fail");
                    break;
                default:
                    Console.WriteLine($"{grade} Not a valid grade");
                    break;
            }
        }
    } // end of class

    // objective 3
    public void Exercise4c()
    {
        for(int i = 0; i < 3; i++)     
        {
            int total = 30 % i;
            Console.WriteLine(i);
        }
    }
}