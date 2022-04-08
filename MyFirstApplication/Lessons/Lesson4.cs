﻿

namespace MyFirstApplication;
/* Lesson 4 - Control Flow Statements */
    internal class Lesson4
{
        // basic if statement
        public void BasicIfStatment(int value)
    {
        Console.WriteLine("Before if statement");
        if (value > 10)
        {
            Console.WriteLine($"Our {value} was greater than 10.");
        }   
            Console.WriteLine("After if statement");
    }   
    // basic if-else statement
    public void BasicIfElseStatement(int able)
    {
        if(able >= 15)
        {
            Console.WriteLine($"Our {able} is greater than 15");
        }
        else
        {
            Console.WriteLine($"Our {able} was less than 15");
        }
    }
    // Basic if-else chain
    public void BasicIfElseChainStatement(int beta)
    {
        if(beta == 10)
        {
            Console.WriteLine($"Our {beta} is 10.");
        } 
        else if (beta == 20)
        {
            Console.WriteLine($"Our {beta} is 20");
        }
        else
        {
            Console.WriteLine($"Our {beta} is not the same.");
        }
    }

    // Basic if with Boolean Logical Operators
    public void BasicAndOrCondition(int charlie, int delta)
    {
        if(charlie > 15 && delta < 30)
        {
            Console.WriteLine($"{charlie} and {delta}");
        }

        if(charlie == 18 || delta < 25)
        {
            Console.WriteLine($"{charlie} or {delta}");
        }
    }
    // ternary operator
    public bool BasicTernaryExample(int echo)
    {
        return (echo > 30) ? true : false;
    }

    // The switch statement
    public void BasicSwitchStatement(int able)
    {
        switch (able)
        {
            case 1:
            case 2:
                Console.WriteLine($"{able} is 1 or 2");
                break;
            case 3:
                Console.WriteLine($"{able} is 3");
                break;
            case 4:
                Console.WriteLine($"{able} is 4");
                break;
            default:
                Console.WriteLine($"{able} was not in the list");
                break;
        }

    }   // end method
    // The while statement
    public void BasicWhileStatement()
    {
        int fox = 0; // intialization
        while (fox < 10) // condition
        {
            Console.WriteLine($"Number = {fox}");
            fox++; // increment
        }
    }

    // do statement
    public void BasicDoStatement()
    {
        int hotel = 0; // intialization
        do
        {
            Console.WriteLine($"Do Number = {hotel}");
            hotel++; // increment
        }   while (hotel < 13); // condition
    }
    // The for statement 
    public void BasicForStatement()
    {
        for (int i = 0; i < 12; i++)
        { 
            Console.WriteLine($"For Number = {i}");

        }
    }

    // The foreach statement
    public void BasicForeachStatement()
    {
        foreach(char word in "Something")
        {
            Console.WriteLine($"Char value = {word}");

        }
    }

    // the jump statements
    public void BasicJumpStatements()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                Console.WriteLine($"The {i} was skipped");
                continue;
            }
            if (i == 4)
            {
                Console.WriteLine($"The loop breaks at {i}");
                break;
            }
            Console.WriteLine($"Number = {i}");
        }
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
            _=> "We dont that size."
        };
        Console.WriteLine(result);
    }


} // end class
