using QodanaCoverageTest;

namespace UnitTestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cls = new Class1();
        cls.UsedMethod();
        cls.UsedMethodWithIf(1);
        cls.UsedLambdaMethod();
        Assert.Pass();
    }
}