public abstract class Human
{
    // fields: class variable
    private string _firstName;

    private string _lastName;
    
    // constructor, has same name as the class
    public Human(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    // class property, expose private class fields
    public string FullName
    {
        get
        {
            // stirng.Format is convenient, clean
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }

    // class method
    // abstract method, no implementation/defination, must be overriden in the subclass
    // virtual method, has implementation/defination, can be overriden in the subclass
    public virtual void Speak()
    {
        Console.WriteLine(string.Format("I'm a human! My name is {0}.", this.FullName));
    }

    // static polymorphism
    public abstract void Speak(string message);

    // encapsulation example
    // protected method, only accessible within the class and its subclasses
    // aka "class-level public method"
    protected abstract void Greeting();
}