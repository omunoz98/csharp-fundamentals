// exercise 1

namespace MyFirstApplication;

public class exercise1
{
    public void Exercise1Method()
    {
        int value1 = 35;
        int value2 = 0x23;
        int value3 = 0b0100011;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // exercise 1, obj 2:
    byte args1 = (22);
    byte args2 = (23);
    byte args3 = (24);

    public void Obj()
    {
        int BytetoInt = args1;
        long ShortToLong = args2;
        float IntToFloat = args3;
        Console.WriteLine(BytetoInt);
        Console.WriteLine(ShortToLong);
        Console.WriteLine(IntToFloat);
    } //end of objective


    // exercise 1, ob3

    byte parameters1 = 1;
    byte parameters2 = 0;
    byte parameters3 = 18;


    public void obj3()
    {

        long DoubleToLong = parameters1;
        float IntToFloat = parameters2;
        long LongToShort = parameters3;
        Console.WriteLine(DoubleToLong);
        Console.WriteLine(IntToFloat);
        Console.WriteLine(LongToShort);
    }

    // exercise 1 objective 4
    int range = (int)123456.987;
    int range1 = -9516248;
    short range2 = 3500;
    int range3 = 988562486;
    short range4 = (short)-19733.14895;


    public void obj4()
    {
        Console.WriteLine(range1);
        Console.WriteLine(range2);
        Console.WriteLine(range3);
        Console.WriteLine(range4);
      
    }

}
