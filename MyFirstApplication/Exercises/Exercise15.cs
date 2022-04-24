namespace MyFirstApplication;
// Exercise 15 Enums and tuples

/*
 Above the class, write an enum called Favorite Movies. 
Add your own favorite movies to the enum. Write a method that hasa string return type and an enum parameter. 
This enum parameter will be your favorite movie enum. 
Write a switch expression that takes the enum and prints out a string return. 
Use string interpolation in your return message that includes the name of the movie chosen
 */

public enum FavoriteMovies { Batman, Interstellar, Marvel}

internal class Exercise15
{
    public string Movies(FavoriteMovies Batman)
    {
        string message = Batman switch
        {
            FavoriteMovies.Batman => $"One of my favorite movies is {FavoriteMovies.Batman}",
            FavoriteMovies.Interstellar => $"One of my favorite movies {FavoriteMovies.Interstellar}",
            _ => $"One of my favorite movie series are {FavoriteMovies.Marvel}"
        };
        return message;
    }

    /*
     Write a method that takes an enum parameter. 
    This enum will be your favorite movie enum. 
    The method will have a tuple return type (intnum, stringmovie).
    Using an explicit int caston one of your enum, assign the value to an int variable.
    Create second variable of type string. Assign the same enum value you used and use the ToString() at the end of it.
    Return both variables as a tuple.See example below for clarity. a.Int value = (int)Enum.Value; b.string something = Enum.Value.ToString()
     */


  //  public void Movies(int 1, string Batman)
   // {
        //int batman = 1;
      //  batman = (int)batman.1;


   // }
 
   

    
    
    

}
