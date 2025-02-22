// Salesman class is called the base class, or parent class
// CarSalesman class is called the subclass, or child class
// CarSalesman class inherits from Salesman class
// CarSalesman class has access to all public and protected members of Salesman class
// CarSalesman class can override abstract methods of Salesman class
// CarSalesman class can add new fields, new methods, new properties and new constructors etc.

public class CarSalesman: Human, ISalesman
{
    // class fields
    // you can define new fields in the subclass
    private int _age;

    // class constructor, but pass the parameters to the base class constructor
    // base class constructor is called before the subclass constructor
    // you have to define a constructor in the subclass
    public CarSalesman(string firstName, string lastName, int age) : base(firstName, lastName)
    {
        this._age = age;
    }

    // class property
    public int Age 
    {
        get { return _age; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative!");
            }
            _age = value; 
        }
    }

    // class method, override the virtual method in the base class
    // also called dynamic polymorphism
    public override void Speak()
    {
        this.Greeting();
    }

    // class method, override the abstract method in the base class
    // also called static polymorphism
    public override void Speak(string message)
    {
        Console.WriteLine(string.Format("Hi! My name is {0}. I have this message for you: {1}.", this.FullName, message));
    }

    // another overloaded method as a demonstration of static polymorphism
    // even though the base class does not have this method
    // you can still define it in the subclass
    public void Speak(int age)
    {
        Console.WriteLine(string.Format("I'm {0} years old. Please show your respect!", age));
    }

    // implement abstract method in the base class
    protected override void Greeting()
    {
        Console.WriteLine(string.Format("I'm a car salesman! My name is {0}. I'm {1} years old.", this.FullName, this.Age));
    }

    // to override the default implementation in the interface
    // but you do not need to use 'override' keyword
    public void Sell()
    {
        Console.WriteLine(string.Format("I'm a car salesman! I sell cars!"));
    }
}