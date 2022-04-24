namespace MyFirstApplication;

/*
Exercise 7, structs & records
*/

internal struct Employee
{
    /* 1.Change the type from class to struct. 
     * Change the name of the struct from Exercise7 to Employee.
     * The filename should not be changed.Create 2 struct variables.The first one will be of type int and be named _id.
     * The second variable should be of type string and be named _name. 
     * Create a construct or that takes 2 arguments, with the first being an int and the second a string. 
     * The struct variables should be assigned to the constructor parameters.Create properties for these 2 variables*/
    private int _id;
    private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    }

}

/* Objective 2. Create a Record based on your Boat object from the Object Oriented Programming lesson.
In your record body, include the boat method that you defined.
This record can be in the same file as exercise 1. Just put the code under it as seen in the lecture.
Test your record to ensure it is working correctly.*/

/* internal record Boat
{
    private int _size;
    private string _color;
    private string _type;
    private string _steeringWheel;

    public int Size
    {
        get { return _size; }
        set { _size = value; }
    } 
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public string SteeringWheel
    {
        get { return _steeringWheel; }
        set { _steeringWheel = value; }
    }

    public Boat (int size, string color, string type, string Wheel)
    {
        Size = size;
        Color = color;
        Type = type;
        SteeringWheel = Wheel;

    }

    


}
*/

