namespace MyFirstApplication;

// Exercise14 Arrays

/*
 Write a method with no parameters and no return type. Write a single dimensional string array of ice cream flavors. 
Using a foreach loop in your method, print out the results of your array using a Console WriteLine statement
 */

internal class Exercise14
{
    public void IceCream()
    {
        string[] flavors = { "vanilla", "strawberry", "chocolate" };

        foreach (string flavor in flavors)
        {
            Console.WriteLine(flavor);
        }

    }


    /*
     Write a method with no parameters and no return type.
     Write a two-dimensional array using the int data type. 
    Using the link below, fill in each dimension with the KC Chiefs Regular season scores. 
    The first dimension will be the home team, while the second dimension will be the away team.
    Using a foreach loop, print out the results of your array using a Console WriteLine statement.
    To determine whichteam is home and away, the website includes the link to the box score. 
    The link label shows both teams. The first team in the label is the away team
     */
    public void Chiefs()
    {

        int[,] scores = { { 34, 23, 34, 26, 40, 26, 43, 35, 33, 35, 27, 22, 33, 32, 17, 38 },
            { 20, 20, 20, 10, 40, 17, 16, 9, 31, 31, 24, 22, 27, 29, 14, 38} };

        foreach(int score in scores)
        {
            Console.WriteLine(score);

        }
    }







}
