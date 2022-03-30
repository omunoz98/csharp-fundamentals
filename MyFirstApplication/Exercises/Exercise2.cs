namespace MyFirstApplication;

// Lesson 2 Objective 2

public class Exercise2
{
    public void ExerciseMethod2(string phase)
    {
        Console.WriteLine(phase.Trim());
        Console.WriteLine(phase.ToLower());
        Console.WriteLine(phase.Contains("Tow"));
        Console.WriteLine(phase.Length);
        Console.WriteLine(phase.IndexOf('C'));
        Console.WriteLine(phase.Trim() + phase.ToLower() + " " + phase.Contains("tow") + phase.Length + phase.IndexOf('C'));

    }


    // Lesson 2 Lab exercise objective 2
    public void ExerciseMethod3()
    {
        char variable = '\u00B6';
        Console.WriteLine(variable);
    }

    // Lesson 2 Lab exercise objective 3
    public void Output(string output)
    {
        output = "Jack and Jill \nwent up the hill \n to fetch a pail of water. \nJack fell down and broke his crown \nand Jill came tumbling after.";
        Console.WriteLine(output);
    }

    public string inter(string name, string movie, string snack, string drink)
    {
        return $"Hello my name is {name}, my current favorite movie is {movie}, my favorite snack is {snack}, and favorite drink is {drink}";
        Console.WriteLine(inter("Omar", "Batman", "protein bars", "water"));
    }

}


