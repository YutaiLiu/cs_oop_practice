// interface is completely abstract class
// the reason to have interface: solve the problem of multiple inheritance in C#
// you can inherit from multiple interfaces, but only one class in C#
// to share functionality between classes, you should use abstract class
// interface only has method, property, event, but no fields, no constructors
// In .Net 8.0, you can define static fields, method and property in interface
// and you can define default implementation for method in interface

// static member in interface can be changed but could not be overridden
// default implementation in interface can be overridden

// readonly and const fields could not be changed

public interface ISalesman
{
    // interface method
    // after .Net 8.0, you can define default implementation for method in interface
    public void Sell()
    {
        Console.WriteLine("I'm a salesman! I sell things!");
    }
}