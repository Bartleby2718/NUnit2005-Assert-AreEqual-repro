namespace MyProject.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var actual = 1;
		Assert.That(expected: 1, Is.EqualTo(actual: actual));
    }
}