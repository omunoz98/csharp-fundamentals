using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment


/*
 Multi-line comment
The below statement is a function. Local functions 
are inside of members and are private by default. This means
They are specific to that member and can only be called 
inside that member. 
 */

// Lesson Examples
// HouseExample();
// Lesson2Example();
// Lesson3Example();

// Lesson4Example();
Lesson5Example();


// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    // Call method of myLesson5
   // myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
  //  handler("Hello CSharp");

    // Func Delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"func example = {add(23)}");

    // Lambda expression 
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    // Switch expression 
   string value1 = myLesson5.BasicSwitch("red");
    Console.WriteLine(value1); 
   string value2 = myLesson5.FavoriteColor("green");
    Console.WriteLine(value2);

    // myLesson5.DrinkSize(33);

    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);


}


// Lesson 4 Control Flow 
// void Lesson4Example()
{
    // Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatment(11);
    // myLesson4.BasicIfElseStatement(12);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(55));
    // myLesson4.BasicSwitchStatement(3);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatements();
     
}

// Relational patten


// Lesson3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    //  myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // myLesson3.BasicUncheckedExamples();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    myLesson3.BasicRelationalExample("Tom", "Tim");


   // int alpha = 2147483647;
   // int total = alpha + 11;
   // Console.WriteLine(total);
    // -2147483638
}


// Lesson 2 Strings
// void Lesson2Example()
{
   //  Lesson2 myLesson2 = new Lesson2();
   // myLesson2.MyTrimExample();
   // int able = myLesson2.MyStringLength();
   // Console.WriteLine(able);
   // myLesson2.MyEqualsExample("Hello World");
   // myLesson2.MyExampleChar();
   // Console.WriteLine(myLesson2.myEscapeExample());
   // myLesson2.MyJoinedStrings("CSharp", "Rules");
   // Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
  //  myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

/* 
 This local function is for my first exercise lab
 */
// MyLocalFunction();

// Console.WriteLine("This is my first sentence");
// Console.WriteLine("I am new to CSharp");
// Console.WriteLine("This CSharp course is cool");
// Console.WriteLine("I am learning stuff everyday.");

void MyLocalFunction()
{

}

// Lesson 1 Value types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();  
}
