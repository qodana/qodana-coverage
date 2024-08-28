namespace QodanaCoverageTest;

public class Class1 : Interface1
{
    public Class1()
    {
        var y = 5;
    }

    public void UsedMethod()
    {
        LocalMethod();
        void LocalMethod()
        {
            var x = 5;
        }
        void UnusedLocalMethod() { }
    }

    public void UsedMethodWithIf(int i)
    {
        if (i == 1)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i);
            Console.Write(i);
        }
    }

    public int UsedLambdaMethod() => 4;
    
    public int UnusedLambdaMethod() => 5;

    private void UnusedMethod()
    {
        void UnusedLocalMethod()
        {
            
        }
    }
}