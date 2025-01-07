public class ExampleClass{
    private int _myPrivateVariable;

    public int MyPublicProperty { get; set; }

    public ExampleClass() { }

    public void MyMethod() {
        // Accessing the private variable directly
        _myPrivateVariable = 10; // This is fine within the class
        Console.WriteLine(_myPrivateVariable); // But should be done via getter/setter for maintainability 
    }
}