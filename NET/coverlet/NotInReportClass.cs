namespace QodanaCoverageTest;

public class NotInReportClass : Interface1
{
    public NotInReportClass()
    {
        var y = 42;
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
}