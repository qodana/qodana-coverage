namespace QodanaCoverageTest;

public class Class2
{
    public Class2()
    {
        
    }

    public void UnusedMethod()
    {
        
    }

    public int MyProperty => 42;

    public int MyProperty1
    {
        get => MyProperty;
        set => MyProperty2 = value;
    }

    public int MyProperty2
    {
        get;
        set;
    }
}