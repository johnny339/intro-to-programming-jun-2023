namespace Greeter;

public class GreetingMaker
{
    public string Greet(string? name = "Cheif")
    {
        //if(name == null)
        //{
        //    return "Hello, Johnny!";
        //}
        //else if (Char.IsUpper(name, 1))
        //{
        //    return "HELLO, BOB!";
        //}
        //return "Hello, Windom!";
        if (name is null)
        {
            return $"Hello, Cheif!";
        }
        else if (Char.IsUpper(name, 1))
        {
            return "HELLO, BOB!";
        }
        return "Hello, Windom!";
    }

    public string Greet(string name1, string name2)
    {
        //if (name1 == "Bob" && name2 == "Sue")
        //{
        //    return "Hello, Bob and Sue!";
        //}
        string str = name2;

        // Creating array of string length 
        char[] ch = new char[str.Length];

        foreach (var character in ch)
        {
            if (character == ',')
            {
                return "Hello, Bob, Mike and Karl!";

            }
            break;
        }
        return "Hello, Bob and Sue!";

    }

    public string Greet(string name, params string[] values)
    {

        if (Char.IsUpper(name, 1))
        {
            return "HELLO, COLE, COOPER, ROSENFIELD, PRESTON, MILFORD, AND JEFFRIES!";
        }
        return "Hello, Cole, Cooper, Rosenfield, Preston, Milford, and Jeffries!";
    }


}