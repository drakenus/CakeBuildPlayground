namespace SimpleLib.Tests;

public class HelloWorldTests
{
    [Fact]
    public void HelloWorld_SaysHelloWorld()
    {
        Assert.Equal("Hello World!", new HelloWorld().SayHello());
    }
}