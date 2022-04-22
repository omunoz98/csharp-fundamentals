namespace MyFirstApplication;


// Exercise 13 Interface and Abstracts

/*
 O1. In your Exercise13.cs file, change your class to an Interface and name it IMovement.
This interface will have 1 property. The property will an int and called Speed. 
It will have a get and init
 */
/*
 O2. Under the interface you will create an Abstract class called WaterBirds. 
This abstract class will implement the IMovement interface. 
The interface property should be implemented in the Abstract class as an abstract property. 
Create two abstract methods for the abstract class that is related to WaterBirds. 
Create a constructor that will take an int parameter and be assigned to the Speed property.
 */

/*
 Under the Abstract class Waterbirds, create a derived class that will extend the WaterBird class.
Implement the abstract methods and property. Use Console Writeline statements in your methods that provide information related to the methods.
One of them should use an Interpolation string and consume the Speed property.
Create a constructorthat will take an int parameter and use the :base() to pass that int value back to the base Abstract class.
 */
internal interface IMovement
{
    // objective 1
    int Speed { get; init; }
}

internal abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }


    public abstract int Altitude();

    public abstract int Flying();


    public WaterBirds(int speed)
    {
        this.Speed = speed;
    }
     
}
    internal class Velocity : WaterBirds
{ 

   public override int Altitude()
    {
        return this.Speed;
    }
   public override int Flying()
    {
        return this.Speed / this.Speed;
    }
    
    public Velocity(int speeds)
        :base(speeds) { }

}




