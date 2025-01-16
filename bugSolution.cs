public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        // Now, MyProperty is guaranteed to be initialized
        int value = this.MyProperty * 2; 
    }

    //Alternative way to handle cases where the property might not be initialized
    public int MyMethodSafe()
    {
        int value = (MyProperty == 0) ? 0 : this.MyProperty * 2; 
        return value;
    }
}