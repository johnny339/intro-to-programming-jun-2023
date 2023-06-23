
using System.Threading.Tasks;

namespace Greeter.UnitTests;
public class GreetingTests
{
    [Fact]
    public void SingleName()
    {
        
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet("Windom");

        Assert.Equal("Hello, Windom!", greeting);
    }

    [Fact]
    public void AcceptANullValueAndGiveADefaultName()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(null); //null value being taken in

        Assert.Equal("Hello, Cheif!", greeting);

    }

    //[Fact]
    [Theory]
    [InlineData("JOHNNY", "HELLO, JOHNNY!")]
    [InlineData("ERIK", "HELLO, ERIK!")]
    [InlineData("JIMMY", "HELLO, JIMMY!")]
    [InlineData("SAM", "HELLO, SAM!")]
    public void GreetMethodWithEnthusiasm(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal($"HELLO, {name}!", expected);
    }

    //[Fact]
    [Theory]
    [InlineData("Bob", "Sue", "Hello, Bob and Sue!")]
    [InlineData("John", "Rob", "Hello, John and Rob!")]
    [InlineData("Jimmy", "Greg", "Hello, Jimmy and Greg!")]
    public void TwoNames(string name1, string name2, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name1, name2);

        Assert.Equal($"Hello, {name1} and {name2}!", expected);
    }

    [Fact]  
    public void ArbitraryListOfNames()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet("Cole", "Cooper", "Rosenfield", "Preston", "Milford", "Jeffries");

        Assert.Equal("Hello, Cole, Cooper, Rosenfield, Preston, Milford, and Jeffries!", greeting);
    }

    [Fact]
    public void ShoutingForListOfNames()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet("COLE", "COOPER", "ROSENFIELD", "PRESTON", "MILFORD", "JEFFRIES");

        Assert.Equal("HELLO, COLE, COOPER, ROSENFIELD, PRESTON, MILFORD, AND JEFFRIES!", greeting);

    }


    // TAKEN OUT OF REQUIREMENTS
    //[Fact]
    //public void SplitCommaSeperatedNames()
    //{
    //    var greeter = new GreetingMaker();
    //    string greeting = greeter.Greet("Bob", "Mike, Karl");
    //    Assert.Equal("Hello, Bob, Mike and Karl!", greeting);
    //}

}
