namespace MyFirstApplication;
// Exercise16 Collections


/*
 Write a method that has no parameters and a no return type. 
Create a List<T> of your Horse objects. When creating your list, utilize all the constructors you created with your Horse class. 
Using a foreach loop, printout the results of your collection using a Console WriteLine statement
 */
internal class Exercise16
{
    public void HorseList()
    {
        List<string> myHorseList = new List<string>();
        myHorseList.Add("Size");
        myHorseList.Add("Color");
        myHorseList.Add("Tail");
        

        foreach(string horse in myHorseList)
        {
            Console.WriteLine(horse);
        }
    }


    /*
     Write a method that has no parameters and noreturn type. 
    Using only the data you used when building your favorite movies from exercise 15, 
    create a Dictionary collection that takes an int key and string value.
    When adding Dictionary elements, pick an int value as the key and use the favorite movies data as the string.
    Using a foreach loop, print out the results of your collection using a Console WriteLine statement.
     */

    public void MovieMethod()
    {

    }






}
