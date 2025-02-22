namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is Yutai's CSharp OOP project!");

            // ============================================
            // inheritance
            // the CarSalesman object can be treated as Human object or ISalesman object
            // but you will loose the access to the fields and methods that are not defined in the Human or ISalesman
            CarSalesman carSalesman = new CarSalesman("Yutai", "Liu", 30);
            Human human = new CarSalesman("John", "Doe", 40);
            carSalesman.Speak();
            carSalesman.Speak(carSalesman.Age);
            human.Speak();
            Console.WriteLine("");
            carSalesman.Sell();
            carSalesman.Age = carSalesman.Age + 1;
            Console.WriteLine("");
            carSalesman.Speak();

            // ============================================
            // polymorphism
            // static polymorphism
            // you will achieve this by method overloading
            // aka passing different parameters to the same method
            // means difference in number of parameters, difference in type of parameters or difference in sequence of parameters
            // for example, the Speak method in Human class has two overloaded versions
            carSalesman.Speak("You are a good person!");

            // dynamic polymorphism
            // we have already seen dynamic polymorphism in the above example
            // the Speak method in CarSalesman class overrides the Speak method in Human class
            // the Sell method in CarSalesman class overrides the Sell method in ISalesman interface
            // this is called dynamic polymorphism

            // ============================================
            // encapsulation
            // encapsulation is to hide the implementation details from the outside world
            // implemented with access specifiers
            // such as public, private, protected, internal, protected internal
            // public: accessible from anywhere, e.g. you can call Sell method from the Main method
            // private: only accessible within the class
            // protected: only accessible within the class and its subclasses
            // internal: only accessible within the same assembly
            // protected internal: only accessible within the same assembly or its subclasses
            
            // example, the Greeting method in Human class is protected
            // you cannot call it from the Main method

            // ============================================
            // abstraction
            // abstraction is to hide the implementation details from the outside world
            // implemented with abstract class or interface
            // the purpose of abstraction includes: simplify the code, reuse the code, increase the security, scalability, maintainability etc.
            // in a word, abstraction is the reason of encapsulation
        }
    }
}