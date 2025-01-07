public class ExampleClass{
    private int _myPrivateVariable;

    public int MyPublicProperty { get; set; }

    public ExampleClass() { }

    public void MyMethod() {
        // Accessing the private variable via property
        MyPublicProperty = 10; 
        Console.WriteLine(MyPublicProperty); // More maintainable; changes to the property will not break external code
    }
}